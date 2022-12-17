import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { FileManagerService } from '@shared/services/file-manager.service';
import { GlobalService } from '@shared/services/global.service';
import { CreatePosterDto } from '@shared/proxy/posters/models';
import { PosterService } from '@shared/proxy/posters/poster.service';
import { WhiteSpaceValidator } from '@shared/custom-validators/whitespace.validator';
import { environment } from 'src/environments/environment';
import { FileCateguery } from '@shared/enums/file-categuery.enum';

@Component({
  selector: 'app-add-poster',
  templateUrl: './add-poster.component.html',
})
export class AddPosterComponent implements OnInit {
  createForm: FormGroup;
  isFormSubmitted: boolean;
  createDto = {} as CreatePosterDto;

  //#region for uploader
  @ViewChild('uploader', { static: true }) uploader;
  isMultiple: boolean = false;
  fileSize: number = environment.postersfileSize ? environment.postersfileSize : environment.fileSize;
  acceptType: string = environment.postersallowedExtensions ? environment.postersallowedExtensions : environment.allowedExtensions;
  isCustomUpload: boolean = true;
  isDisabled: boolean = false;
  //#endregion

  constructor(private formBuilder: FormBuilder, private fileManagerService: FileManagerService,
    private posterService: PosterService, private globalService: GlobalService)
  {
  }

  ngOnInit() {
    this.globalService.setAdminTitle('إضافة إعلان جديد');
    this.buildForm();
  }

  buildForm() {
    this.createForm = this.formBuilder.group({
      titleAr: [this.createDto.titleAr || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      titleEn: [this.createDto.titleEn || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      order: [this.createDto.order || '', Validators.required],
      image: [this.createDto.image || null, Validators.required],
      isActive: [this.createDto.isActive || true, Validators.required],
    });
  }

  onUpload(event: any) {
    this.createForm.get('image').setValue(event.files[0]);
  }

  onRemove(event) {
    this.createForm.get('image').setValue(null);
  }

  onSubmit() {
    this.isFormSubmitted = true;
    if (this.createForm.valid) {
      this.createDto = { ...this.createForm.value } as CreatePosterDto;
      let imageContent = this.createForm.get('image').value;
      if (imageContent) {
        this.createDto.imageName = imageContent.name;
      }
      this.posterService.create(this.createDto).subscribe((response) => {
        this.globalService.showMessage(response.message);
        if (response.isSuccess) {
          if (imageContent) {
            this.fileManagerService.uploadFile(FileCateguery.Posters, response.data.fileName, [imageContent]).subscribe(res => {
              this.globalService.navigate('/admin/data-management/poster-list');
            });
          }
          else {
            this.globalService.navigate('/admin/data-management/poster-list');
          }
        }
      });
    }
  }
}
