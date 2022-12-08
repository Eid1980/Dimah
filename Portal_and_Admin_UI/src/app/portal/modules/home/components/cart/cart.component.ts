import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-cart',
  templateUrl: './cart.component.html',
  styleUrls: ['./cart.component.scss']
})
export class CartComponent implements OnInit {
  showEditItemsModal: any = false;
  showDeleteItemsModal: any = false;

  cartItems: any = [
    {
      "id": 1,
      "title": "سقيا الماء",
      "dailyDonation": 5,
      "donationPeriod": 5,
      "totalCost": 25,
    },
    {
      "id": 2,
      "title": "إطعام",
      "dailyDonation": 5,
      "donationPeriod": 5,
      "totalCost": 25,
    },
    {
      "id": 3,
      "title": "مساعدة",
      "dailyDonation": 5,
      "donationPeriod": 5,
      "totalCost": 25,
    }
  ]

  constructor() { }

  ngOnInit(): void {
  }

  increaseProduct(item: any) {
    let input_item = (item.target).closest(".number-counter").querySelector("input[type='number']");
    let input_value = Number((input_item).value);

    input_value += 1;

    (input_item).setAttribute('value', input_value);
  }

  decreaseProduct(item: any) {
    let input_item = (item.target).closest(".number-counter").querySelector("input[type='number']");
    let input_value = Number((input_item).value);

    if (input_value > 1) {
      input_value -= 1;

      (input_item).setAttribute('value', input_value);
    }
  }

  // open edit item modal
  openEditItemModal(item: any) {
    console.log(item);

    this.showEditItemsModal = true;
  }

  // open delete item modal
  openDeleteItemModal(item: any) {
    console.log(item);

    this.showDeleteItemsModal = true;
  }

  // edit item data
  editItem() {
    this.showEditItemsModal = false;
  }

  // close edit modal
  closeEditModal() {
    this.showEditItemsModal = false;
  }

  // delete item from cart
  deleteItem() {
    this.showDeleteItemsModal = false;
  }

  // close delete modal
  closeDeleteModal() {
    this.showDeleteItemsModal = false;
  }
}