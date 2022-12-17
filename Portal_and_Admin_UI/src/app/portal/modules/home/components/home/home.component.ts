import { Component, OnInit } from '@angular/core';
import { DomSanitizer } from '@angular/platform-browser';
import { SearchModel } from '@shared/proxy/shared/search-model.model';
import { GlobalService } from '@shared/services/global.service';
import { OwlOptions } from 'ngx-owl-carousel-o';
import { TranslationServiceService } from '@shared/services/translation-service.service';
import { GetPosterDetailsDto } from '@shared/proxy/posters/models';
import { PosterService } from '@shared/proxy/posters/poster.service';
import { HomeService } from '@shared/proxy/home/home.service';
import { DimahProjectsListDto } from '@shared/proxy/home/models';
declare let $: any;

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html'
})
export class HomeComponent implements OnInit {
  currentLang: string;
  electronicUrl: string;
  searchModel: SearchModel = {};
  posters = [] as GetPosterDetailsDto[];
  charityProjects = [] as DimahProjectsListDto[];

  governorateNews = [];
  reports = [];

  internalServices = [];
  internalServicesTop = [];
  externalServices = [];
  serviceGuidFirst = [];
  serviceGuidLength = [];

  latestNews: any = [
    {
      "id": 1,
      "imageUrl": "https://picsum.photos/id/10/1200/400",
      "title": "سقيا الماء",
      "desc": "قام فريق التطوع بتوزيع مياه على حجاج بيت الله الحرام",
      "date": "الثلاثاء، 13 جمادى الأولى 1444 هـ - 6 ديسمبر 2022 م",
    },
    {
      "id": 2,
      "imageUrl": "https://picsum.photos/id/90/1200/400",
      "title": "سقيا الماء",
      "desc": "قام فريق التطوع بتوزيع مياه على حجاج بيت الله الحرام",
      "date": "الثلاثاء، 13 جمادى الأولى 1444 هـ - 6 ديسمبر 2022 م",
    },
    {
      "id": 3,
      "imageUrl": "",
      "title": "الدفع الأمن",
      "desc": "قام فريق التطوع بتوزيع مياه على حجاج بيت الله الحرام",
      "date": "الثلاثاء، 13 جمادى الأولى 1444 هـ - 6 ديسمبر 2022 م",
    },
  ]

  adsItems: any = [
    {
      "id": "adsBanner1",
      "imageUrl": "assets/images/banner2.png",
      "title": "ads banner 1",
      "requestLink": ""
    },
    {
      "id": "adsBanner2",
      "imageUrl": "https://picsum.photos/id/120/1200/330",
      "title": "ads banner 2",
      "requestLink": ""
    },
    {
      "id": "adsBanner3",
      "imageUrl": "https://picsum.photos/id/200/1200/330",
      "title": "ads banner 3",
      "requestLink": ""
    }
  ]

  // home banner slider config
  bannerSliderOptions: OwlOptions = {
    loop: true,
    autoplay: true,
    autoplayTimeout: 5000,
    autoplayHoverPause: false,
    mouseDrag: true,
    touchDrag: true,
    pullDrag: false,
    dots: true,
    navSpeed: 700,
    rtl: true,
    navText: ['', ''],
    responsive: {
      0: {
        items: 1,
      },
      400: {
        items: 1,
      },
    },
    nav: true,
  };

  // news slider config
  newsOptions: OwlOptions = {
    loop: true,
    mouseDrag: false,
    touchDrag: false,
    pullDrag: false,
    dots: false,
    navSpeed: 700,
    rtl: true,
    navText: ['', ''],
    responsive: {
      0: {
        items: 1,
      },
      400: {
        items: 1,
      },
    },
    nav: true,
  };

  // ads banner slider config
  adsBannerOptions: OwlOptions = {
    loop: true,
    autoplay: true,
    autoplayTimeout: 5000,
    autoplayHoverPause: false,
    mouseDrag: true,
    touchDrag: true,
    dots: false,
    navSpeed: 1500,
    rtl: true,
    navText: ['', ''],
    responsive: {
      0: {
        items: 1,
      },
      400: {
        items: 1,
      },
    },
    nav: false,
  };

  constructor(private posterService: PosterService, private homeService: HomeService,
    public globalService: GlobalService, private translateService: TranslationServiceService) {
  }

  ngOnInit() {
    this.globalService.setTitle(this.globalService.translate('homePage'));
    this.currentLang = this.translateService.getCurrentLanguage().Name.toLowerCase();

    this.getPosters();
    this.getCharityProjects();

    let processNumber1 = document.getElementById("processNumber1");
    let processNumber2 = document.getElementById("processNumber2");
    let processNumber3 = document.getElementById("processNumber3");
    let processNumber4 = document.getElementById("processNumber4");

    this.animateValue(processNumber1, 0, 100, 5000);
    this.animateValue(processNumber2, 0, 200, 5000);
    this.animateValue(processNumber3, 0, 300, 5000);
    this.animateValue(processNumber4, 0, 400, 5000);
  }

  animateValue(obj: any, start: any, end: any, duration: any) {
    let startTimestamp = null;
    let step = (timestamp: any) => {
      if (!startTimestamp) startTimestamp = timestamp;
      let progress = Math.min((timestamp - startTimestamp) / duration, 1);
      obj.innerHTML = Math.floor(progress * (end - start) + start);
      if (progress < 1) {
        window.requestAnimationFrame(step);
      }
    };
    console.log(step)
    window.requestAnimationFrame(step);
  }


  getPosters() {
    this.posterService.getAll().subscribe((res) => {
      this.posters = res.data;
    });
  }
  getCharityProjects() {
    this.homeService.getCharityProjects("22d0eeca-467a-48bc-a600-3624ff0887b6").subscribe((res) => {
      this.charityProjects = res.data;
    });
  }

}
