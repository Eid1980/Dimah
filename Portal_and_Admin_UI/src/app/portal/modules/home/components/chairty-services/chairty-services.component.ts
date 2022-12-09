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
    }
  ]

  constructor() { }

  ngOnInit(): void {
  }

}
