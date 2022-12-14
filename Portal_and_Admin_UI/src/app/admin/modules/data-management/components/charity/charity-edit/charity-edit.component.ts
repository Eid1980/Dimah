import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { GlobalService } from '@shared/services/global.service';
import { WhiteSpaceValidator } from '@shared/custom-validators/whitespace.validator';
import { UpdateCharityDto } from '@shared/proxy/charities/models';
import { CharityService } from '@shared/proxy/charities/charity.service';
import { MobileNumberValidator } from '@shared/custom-validators/mobileNumber.validator';

@Component({
  selector: 'app-charity-edit',
  templateUrl: './charity-edit.component.html'
})
export class CharityEditComponent implements OnInit {
  id: number;
  updateCharityForm: FormGroup;
  isFormSubmitted: boolean;
  updateCharityDto = {} as UpdateCharityDto;

  constructor(private formBuilder: FormBuilder, private charityService: CharityService,
    private activatedRoute: ActivatedRoute, private globalService: GlobalService) {
  }

  ngOnInit(): void {
    this.globalService.setAdminTitle('تعديل الجهة');
    this.buildForm();
    this.id = this.activatedRoute.snapshot.params['id'];
    if (this.id) {
      this.getDetails();
    }
    else {
      this.globalService.navigate("/admin/data-management/charity-list");
    }
  }

  buildForm() {
    this.updateCharityForm = this.formBuilder.group({
      nameAr: [this.updateCharityDto.nameAr || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      nameEn: [this.updateCharityDto.nameEn || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      email: [this.updateCharityDto.email || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace, Validators.email]],
      phoneNumber: [this.updateCharityDto.phoneNumber || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace, MobileNumberValidator.validateMobileNumber]],
      address: [this.updateCharityDto.address || ''],
      isActive: [this.updateCharityDto.isActive, Validators.required]
    });
  }

  getDetails() {
    this.charityService.getById(this.id).subscribe((response) => {
      this.updateCharityDto = response.data as UpdateCharityDto;
      this.buildForm();
    });
  }

  onSubmit() {
    this.isFormSubmitted = true;
    if (this.updateCharityForm.valid) {
      this.updateCharityDto = { ...this.updateCharityForm.value } as UpdateCharityDto;
      this.updateCharityDto.id = this.id;
      this.charityService.update(this.updateCharityDto)
        .subscribe((response) => {
          this.globalService.showMessage(response.message);
          if (response.isSuccess) {
            this.globalService.navigate("/admin/data-management/charity-list");
          }
        });
    }
  }
}
