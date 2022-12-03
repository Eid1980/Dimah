import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { GlobalService } from '@shared/services/global.service';
import { WhiteSpaceValidator } from '@shared/custom-validators/whitespace.validator';
import { CreateCharityDto } from '@shared/proxy/charities/models';
import { CharityService } from '@shared/proxy/charities/charity.service';
import { MobileNumberValidator } from '@shared/custom-validators/mobileNumber.validator';

@Component({
  selector: 'app-charity-add',
  templateUrl: './charity-add.component.html'
})
export class CharityAddComponent implements OnInit {
  createCharityForm: FormGroup;
  isFormSubmitted: boolean;
  createCharityDto = {} as CreateCharityDto;

  constructor(private formBuilder: FormBuilder, private charityService: CharityService,
    private globalService: GlobalService) {
  }

  ngOnInit(): void {
    this.globalService.setAdminTitle('اضافة جهة جديدة');
    this.buildForm();
  }

  buildForm() {
    this.createCharityForm = this.formBuilder.group({
      nameAr: [this.createCharityDto.nameAr || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      nameEn: [this.createCharityDto.nameEn || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      email: [this.createCharityDto.email || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace, Validators.email]],
      phoneNumber: [this.createCharityDto.phoneNumber || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace, MobileNumberValidator.validateMobileNumber]],
      address: [this.createCharityDto.address || ''],
      isActive: [this.createCharityDto.isActive || true, Validators.required]
    });
  }

  onSubmit() {
    this.isFormSubmitted = true;
    if (this.createCharityForm.valid) {
      this.createCharityDto = { ...this.createCharityForm.value } as CreateCharityDto;
      this.charityService.create(this.createCharityDto)
        .subscribe((response) => {
          this.globalService.showMessage(response.message);
          if (response.isSuccess) {
            this.globalService.navigate("/admin/data-management/charity-list");
          }
        });
    }
  }
}
