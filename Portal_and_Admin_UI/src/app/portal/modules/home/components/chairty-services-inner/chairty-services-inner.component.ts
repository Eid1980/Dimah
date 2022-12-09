import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { OwlOptions } from 'ngx-owl-carousel-o';

@Component({
  selector: 'app-chairty-services-inner',
  templateUrl: './chairty-services-inner.component.html',
  styleUrls: ['./chairty-services-inner.component.scss']
})
export class ChairtyServicesInnerComponent implements OnInit {

  confirmationBox: any = false;

  chairtyItems: any = [
    {
      "id": 1,
      "title": "سقيا الماء",
      "imageUrl": "assets/images/icons/svg/water-dot.svg"
    },
    {
      "id": 2,
      "title": "وجبة معتمر",
      "imageUrl": "assets/images/icons/svg/food-method.svg"
    },
    {
      "id": 3,
      "title": "إفطار صائم",
      "imageUrl": "assets/images/icons/svg/food.svg"
    },
    {
      "id": 4,
      "title": "زواج أرامل",
      "imageUrl": "assets/images/icons/svg/maried.svg"
    },
    {
      "id": 1,
      "title": "سقيا الماء",
      "imageUrl": "assets/images/icons/svg/water-dot.svg"
    },
    {
      "id": 2,
      "title": "وجبة معتمر",
      "imageUrl": "assets/images/icons/svg/food-method.svg"
    },
    {
      "id": 3,
      "title": "إفطار صائم",
      "imageUrl": "assets/images/icons/svg/food.svg"
    },
    {
      "id": 4,
      "title": "زواج أرامل",
      "imageUrl": "assets/images/icons/svg/maried.svg"
    }
  ]

  // ads banner slider config
  itemsOptions: OwlOptions = {
    loop: false,
    autoplay: false,
    mouseDrag: true,
    touchDrag: true,
    pullDrag: true,
    dots: false,
    navSpeed: 1500,
    rtl: true,
    navText: ['', ''],
    responsive: {
      0: {
        items: 1,
        margin: 0,
      },
      380: {
        items: 2,
        margin: 26,
      },
      576: {
        items: 3,
        margin: 26,
      },
      767: {
        items: 4,
        margin: 26,
      },
      991: {
        items: 4,
        margin: 26,
      },
    },
    nav: true,
  };

  constructor(private router: Router) { }

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

  addToCart() {
    this.confirmationBox = true;

    setTimeout(() => {
      this.confirmationBox = false;
    }, 5000);
  }

  showCart() {
    this.confirmationBox = false;
    this.router.navigateByUrl('/cart');
  }
}
