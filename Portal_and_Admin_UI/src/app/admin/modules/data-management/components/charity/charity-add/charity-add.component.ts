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
  createForm: FormGroup;
  isFormSubmitted: boolean;
  createDto = {} as CreateCharityDto;

  constructor(private formBuilder: FormBuilder, private charityService: CharityService,
    private globalService: GlobalService) {
  }

  ngOnInit(): void {
    this.globalService.setAdminTitle('اضافة جهة جديدة');
    this.buildForm();
  }

  buildForm() {
    this.createForm = this.formBuilder.group({
      nameAr: [this.createDto.nameAr || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      nameEn: [this.createDto.nameEn || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace]],
      email: [this.createDto.email || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace, Validators.email]],
      phoneNumber: [this.createDto.phoneNumber || '', [Validators.required, WhiteSpaceValidator.noWhiteSpace, MobileNumberValidator.validateMobileNumber]],
      address: [this.createDto.address || ''],
      isActive: [this.createDto.isActive || true, Validators.required]
    });
  }

  onSubmit() {
    this.isFormSubmitted = true;
    if (this.createForm.valid) {
      this.createDto = { ...this.createForm.value } as CreateCharityDto;
      this.charityService.create(this.createDto)
        .subscribe((response) => {
          this.globalService.showMessage(response.message);
          if (response.isSuccess) {
            this.globalService.navigate("/admin/data-management/charity-list");
          }
        });
    }
  }
}
