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
  createNationalityForm: FormGroup;
  isFormSubmitted: boolean;
  createNationalityDto = {} as CreateNationalityDto;

  constructor(private formBuilder: FormBuilder, private nationalityService: NationalityService,
    private globalService: GlobalService) {
  }

  ngOnInit(): void {
    this.globalService.setAdminTitle('اضافة جنسية جديدة');
    this.buildForm();
  }

  buildForm() {
    this.createNationalityForm = this.formBuilder.group({
      nameAr: [this.createNationalityDto.nameAr || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      nameEn: [this.createNationalityDto.nameEn || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      code: [this.createNationalityDto.code || ''],
      iso2: [this.createNationalityDto.iso2 || ''],
      dialCode: [this.createNationalityDto.dialCode || ''],
      isActive: [this.createNationalityDto.isActive || true, Validators.required]
    });
  }

  onSubmit() {
    this.isFormSubmitted = true;
    if (this.createNationalityForm.valid) {
      this.createNationalityDto = { ...this.createNationalityForm.value } as CreateNationalityDto;
      this.nationalityService.create(this.createNationalityDto)
        .subscribe((response) => {
          this.globalService.showMessage(response.message);
          if (response.isSuccess) {
            this.globalService.navigate("/admin/data-management/nationality-list");
          }
        });
    }
  }
}
