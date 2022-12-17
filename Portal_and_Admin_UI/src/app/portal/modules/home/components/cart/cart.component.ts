import { Component, OnInit } from '@angular/core';
import { ChartItemService } from '@shared/proxy/chart-items/chart-item.service';
import { GlobalService } from '@shared/services/global.service';
import { CurrentChartListDto, GetChartItemDetailsDto, UpdateChartItemDto } from '@shared/proxy/chart-items/models';
import { MessageType } from '@shared/enums/message-type.enum';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-cart',
  templateUrl: './cart.component.html'
})
export class CartComponent implements OnInit {
  currentChartListDto = [] as CurrentChartListDto[];
  totlalChart: number = 0;

  operationId: string = '';
  showEditItemsModal: boolean = false;
  showDeleteItemsModal: boolean = false;
  updateForm: FormGroup;
  updateDto = {} as UpdateChartItemDto;
  detailsDto = {} as GetChartItemDetailsDto;
  isFormSubmitted: boolean = false;

  constructor(private formBuilder: FormBuilder, private chartItemService: ChartItemService,
    private globalService: GlobalService)
  {
  }

  ngOnInit(): void {
    this.getCurrentChart();
    this.buildForm();
  }
  getCurrentChart() {
    this.chartItemService.getCurrentChart().subscribe((res) => {
      this.currentChartListDto = res.data;
      this.totlalChart = res.data.reduce((accumulator, obj) => {
        return accumulator + obj.donationTotal;
      }, 0);
    });
  }

  //#region Edit
  openEditItemModal(id: string) {
    this.operationId = id;
    if (this.operationId) {
      this.getItemDetails();
    }
    else {
      this.globalService.messageAlert(MessageType.Warning, 'برجاء اختيار العنصر الذي تريد تعديله أولا');
    }
    this.showEditItemsModal = true;
  }
  closeEditModal() {
    this.operationId = '';
    this.updateDto = {} as UpdateChartItemDto;
    this.detailsDto = {} as GetChartItemDetailsDto;
    this.showEditItemsModal = false;
  }
  editItem() {
    if (this.operationId) {
      this.isFormSubmitted = true;
      if (this.updateForm.valid) {
        this.updateDto = { ...this.updateForm.value } as UpdateChartItemDto;
        this.updateDto.id = this.detailsDto.id;
        this.chartItemService.update(this.updateDto).subscribe((response) => {
          this.globalService.showMessage(response.message);
          if (response.isSuccess) {
            this.getCurrentChart();
            this.closeEditModal();
          }
        });
      }
    }
    else {
      this.globalService.messageAlert(MessageType.Warning, 'برجاء اختيار العنصر الذي تريد تعديله أولا');
      this.closeEditModal();
    }
  }

  getItemDetails() {
    this.chartItemService.getById(this.operationId).subscribe((response) => {
      this.detailsDto = response.data;
      this.updateDto = response.data as UpdateChartItemDto;
      this.buildForm();
    });
  }
  buildForm() {
    this.updateForm = this.formBuilder.group({
      donationValue: [this.updateDto.donationValue || 1, [Validators.required]],
      donationPeriod: [this.updateDto.donationPeriod || 1, [Validators.required]]
    });
  }
  increaseProduct() {
    this.updateDto.donationPeriod += 1;
    this.updateForm.controls['donationPeriod'].setValue(this.updateDto.donationPeriod);
  }
  decreaseProduct() {
    if (this.updateDto.donationPeriod > 1) {
      this.updateDto.donationPeriod -= 1;
      this.updateForm.controls['donationPeriod'].setValue(this.updateDto.donationPeriod);
    }
  }
  //#endregion

  //#region Delete
  openDeleteItemModal(id: string) {
    this.operationId = id;
    this.showDeleteItemsModal = true;
  }
  closeDeleteModal() {
    this.operationId = '';
    this.showDeleteItemsModal = false;
  }
  deleteItem() {
    if (this.operationId) {
      this.chartItemService.delete(this.operationId).subscribe((result) => {
        if (result.isSuccess) {
          this.getCurrentChart();
        }
        this.globalService.showMessage(result.message);
      });
    }
    else {
      this.globalService.messageAlert(MessageType.Warning, 'برجاء اختيار العنصر الذي تريد حذفة أولا');
    }
    this.closeDeleteModal();
  }
  //#endregion

}
