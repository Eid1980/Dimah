import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { UpdateNationalityDto } from '@proxy/nationalities/models';
import { NationalityService } from '@proxy/nationalities/nationality.service';
import { ActivatedRoute } from '@angular/router';
import { GlobalService } from '@shared/services/global.service';
import { WhiteSpaceValidator } from '@shared/custom-validators/whitespace.validator';

@Component({
  selector: 'app-nationality-edit',
  templateUrl: './nationality-edit.component.html'
})
export class NationalityEditComponent implements OnInit {
  id: number;
  updateForm: FormGroup;
  isFormSubmitted: boolean;
  updateDto = {} as UpdateNationalityDto;

  constructor(private formBuilder: FormBuilder, private nationalityService: NationalityService,
    private activatedRoute: ActivatedRoute, private globalService: GlobalService) {
  }

  ngOnInit(): void {
    this.globalService.setAdminTitle('تعديل بيانات الجنسية');
    this.buildForm();
    this.id = this.activatedRoute.snapshot.params['id'];
    if (this.id) {
      this.getDetails();
    }
    else {
      this.globalService.navigate("/admin/data-management/nationality-list");
    }
  }

  buildForm() {
    this.updateForm = this.formBuilder.group({
      nameAr: [this.updateDto.nameAr || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      nameEn: [this.updateDto.nameEn || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      code: [this.updateDto.code || ''],
      iso2: [this.updateDto.iso2 || ''],
      dialCode: [this.updateDto.dialCode || ''],
      isActive: [this.updateDto.isActive, Validators.required]
    });
  }

  getDetails() {
    this.nationalityService.getById(this.id).subscribe((response) => {
      this.updateDto = response.data as UpdateNationalityDto;
      this.buildForm();
    });
  }

  onSubmit() {
    this.isFormSubmitted = true;
    if (this.updateForm.valid) {
      this.updateDto = { ...this.updateForm.value } as UpdateNationalityDto;
      this.updateDto.id = this.id;
      this.nationalityService.update(this.updateDto)
        .subscribe((response) => {
          this.globalService.showMessage(response.message);
          if (response.isSuccess) {
            this.globalService.navigate("/admin/data-management/nationality-list");
          }
        });
    }
  }
}
