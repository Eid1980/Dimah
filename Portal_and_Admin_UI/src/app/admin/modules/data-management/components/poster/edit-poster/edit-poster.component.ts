import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { PosterService } from '@shared/proxy/posters/poster.service';
import { GlobalService } from '@shared/services/global.service';
import { UpdatePosterDto } from '@shared/proxy/posters/models';
import { FileManagerService } from '@shared/services/file-manager.service';
import { DomSanitizer } from '@angular/platform-browser';
import { WhiteSpaceValidator } from '@shared/custom-validators/whitespace.validator';
import { environment } from 'src/environments/environment';
import { FileCateguery } from '@shared/enums/file-categuery.enum';

@Component({
  selector: 'app-edit-poster',
  templateUrl: './edit-poster.component.html'
})
export class EditPosterComponent implements OnInit {
  updateForm: FormGroup;
  isFormSubmitted: boolean;
  id: string;
  updateDto = {} as UpdatePosterDto;

  //#region for uploader
  @ViewChild('uploader', { static: true }) uploader;
  isMultiple: boolean = false;
  fileSize: number = environment.postersfileSize ? environment.postersfileSize : environment.fileSize;
  acceptType: string = environment.postersallowedExtensions ? environment.postersallowedExtensions : environment.allowedExtensions;
  isCustomUpload: boolean = true;
  isDisabled: boolean = false;
  //#endregion

  constructor(private formBuilder: FormBuilder, private fileManagerService: FileManagerService,
    private posterService: PosterService, private activatedRoute: ActivatedRoute,
    private globalService: GlobalService,
    public sanitizer: DomSanitizer
  ) {
  }

  ngOnInit() {
    this.globalService.setAdminTitle('تعديل الإعلان');
    this.buildForm();
    this.id = this.activatedRoute.snapshot.params['id'];
    if (this.id) {
      this.getDetails();
    }
    else {
      this.globalService.navigate("/admin/data-management/poster-list");
    }
  }

  buildForm() {
    this.updateForm = this.formBuilder.group({
      titleAr: [this.updateDto.titleAr || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      titleEn: [this.updateDto.titleEn || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      order: [this.updateDto.order || '', Validators.required],
      image: [null],
      isActive: [this.updateDto.isActive, Validators.required]
    });
  }
  getDetails() {
    this.posterService.getById(this.id).subscribe((response) => {
      this.updateDto = response.data as UpdatePosterDto;
      this.buildForm();
    });
  }
  onUpload(event: any) {
    this.updateForm.get('image').setValue(event.files[0]);
  }
  onRemove(event) {
    this.updateForm.get('image').setValue(null);
  }

  onSubmit() {
    this.isFormSubmitted = true;
    if (this.updateForm.valid) {
      this.updateDto = { ...this.updateForm.value } as UpdatePosterDto;
      this.updateDto.id = this.id;
      let imageContent = this.updateForm.get('image').value;
      if (imageContent) {
        this.updateDto.imageName = imageContent.name;
      }
      this.posterService.update(this.updateDto).subscribe((response) => {
        this.globalService.showMessage(response.message);
        if (response.isSuccess) {
          if (imageContent) {
            this.fileManagerService.uploadFile(FileCateguery.Posters, response.data.fileName, [imageContent]).subscribe(res => {
              this.globalService.navigate("/admin/data-management/poster-list");
            });
          }
          else {
            this.globalService.navigate("/admin/data-management/poster-list");
          }
        }
      });
    }
  }
}
