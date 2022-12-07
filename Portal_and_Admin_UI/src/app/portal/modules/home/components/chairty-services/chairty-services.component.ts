import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-chairty-services',
  templateUrl: './chairty-services.component.html',
  styleUrls: ['./chairty-services.component.scss']
})
export class ChairtyServicesComponent implements OnInit {

  chairtyItems: any = [
    {
      "id": 1,
      "title": "سقيا الماء",
      "imageUrl": "assets/images/icons/png/cart.png"
    },
    {
      "id": 2,
      "title": "وجبة معتمر",
      "imageUrl": "assets/images/icons/png/cart.png"
    },
    {
      "id": 3,
      "title": "إفطار صائم",
      "imageUrl": "assets/images/icons/png/cart.png"
    },
    {
      "id": 4,
      "title": "زواج أرامل",
      "imageUrl": "assets/images/icons/png/cart.png"
    },
    {
      "id": 4,
      "title": "زواج أرامل",
      "imageUrl": "assets/images/icons/png/cart.png"
    }
  ]

  constructor() { }

  ngOnInit(): void {
  }

}
