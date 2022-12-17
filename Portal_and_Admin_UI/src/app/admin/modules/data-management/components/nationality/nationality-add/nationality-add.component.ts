import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { GlobalService } from '@shared/services/global.service';
import { CreateNationalityDto } from '@proxy/nationalities/models';
import { NationalityService } from '@proxy/nationalities/nationality.service';
import { WhiteSpaceValidator } from '@shared/custom-validators/whitespace.validator';

@Component({
  selector: 'app-nationality-add',
  templateUrl: './nationality-add.component.html'
})
export class NationalityAddComponent implements OnInit {
  createForm: FormGroup;
  isFormSubmitted: boolean;
  createDto = {} as CreateNationalityDto;

  constructor(private formBuilder: FormBuilder, private nationalityService: NationalityService,
    private globalService: GlobalService) {
  }

  ngOnInit(): void {
    this.globalService.setAdminTitle('اضافة جنسية جديدة');
    this.buildForm();
  }

  buildForm() {
    this.createForm = this.formBuilder.group({
      nameAr: [this.createDto.nameAr || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      nameEn: [this.createDto.nameEn || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      code: [this.createDto.code || ''],
      iso2: [this.createDto.iso2 || ''],
      dialCode: [this.createDto.dialCode || ''],
      isActive: [this.createDto.isActive || true, Validators.required]
    });
  }

  onSubmit() {
    this.isFormSubmitted = true;
    if (this.createForm.valid) {
      this.createDto = { ...this.createForm.value } as CreateNationalityDto;
      this.nationalityService.create(this.createDto)
        .subscribe((response) => {
          this.globalService.showMessage(response.message);
          if (response.isSuccess) {
            this.globalService.navigate("/admin/data-management/nationality-list");
          }
        });
    }
  }
}
