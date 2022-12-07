import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-cart',
  templateUrl: './cart.component.html',
  styleUrls: ['./cart.component.scss']
})
export class CartComponent implements OnInit {
  showEditItemsModal: any = false;
  showDeleteItemsModal: any = false;

  chairtyItems: any = [
    {
      "id": 1,
      "title": "سقيا الماء",
      "imageUrl": "assets/images/icons/png/cart.png",
      "donationCost": 5,
      "donationPeriod": 10
    },
    {
      "id": 2,
      "title": "وجبة معتمر",
      "imageUrl": "assets/images/icons/png/cart.png",
      "donationCost": 50,
      "donationPeriod": 2
    },
    {
      "id": 3,
      "title": "إفطار صائم",
      "imageUrl": "assets/images/icons/png/cart.png",
      "donationCost": 15,
      "donationPeriod": 20
    },
    {
      "id": 4,
      "title": "زواج أرامل",
      "imageUrl": "assets/images/icons/png/cart.png",
      "donationCost": 5,
      "donationPeriod": 10
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