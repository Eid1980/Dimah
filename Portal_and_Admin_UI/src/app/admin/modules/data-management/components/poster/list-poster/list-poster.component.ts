import { Component, OnInit, ViewChild } from '@angular/core';
import { FileManagerService } from '@shared/services/file-manager.service';
import { GlobalService } from '@shared/services/global.service';
import { PageListComponent } from '@shared/components/page-list/page-list.component';
import { PageListSetting } from '@shared/interfaces/page-list-setting';
import { PosterService } from '@shared/proxy/posters/poster.service';
import { ColumnType } from '@shared/enums/column-type.enum';
import { ActionButtonClass } from '@shared/enums/action-button-class';
import { ActionButtonIcon } from '@shared/enums/action-button-icon';

@Component({
  selector: 'app-list-poster',
  templateUrl: './list-poster.component.html'
})
export class ListPosterComponent implements OnInit {
  @ViewChild(PageListComponent, { static: true }) list: PageListComponent;
  pageListSettings: PageListSetting;

  constructor(private posterService: PosterService, private fileManagerService: FileManagerService,
    private globalService: GlobalService)
  {
  }

  ngOnInit() {
    this.globalService.setAdminTitle('الإعلانات');
    this.pageSetting();
  }

  pageSetting() {
    this.pageListSettings = {
      PageTitle: "قائمة الإعلانات",
      listPermissionCode: "*",
      createButtonLink: "/admin/data-management/poster-add",
      createButtonText: "انشاء إعلان جديد",
      Url: this.posterService.serviceUrl,

      cols: [
        { Field: "id", Header: "الكود", Searchable: false, Hidden: true },
        { Field: "titleAr", Header: "العنوان عربي" },
        { Field: "titleEn", Header: "العنوان انجليزي" },
        { Field: "order", Header: "الترتيب" },
        {
          Field: "isActive",
          Header: "الحالة",
          Searchable: false,
          Sortable: false,
          Type: ColumnType.Status,
          FuncName: (id, event) => this.changeStatus(id, event),
        },
        {
          Field: "Action",
          Header: this.globalService.translate('global.lables.actions'),
          Searchable: false,
          Type: ColumnType.Action,
        },
      ],

      actions: [
        {
          title: "تعديل",
          routerLink: "/admin/data-management/poster-edit",
          IsQueryParams: true,
          buttonclass: ActionButtonClass.Edit,
          buttonIcon: ActionButtonIcon.Edit,
        },
        {
          title: "التفاصيل",
          routerLink: "/admin/data-management/poster-view",
          IsQueryParams: true,
          buttonclass: ActionButtonClass.View,
          buttonIcon: ActionButtonIcon.View,
        },
        {
          title: 'حذف',
          FuncName: (id) => this.delete(id),
          buttonclass: ActionButtonClass.Delete,
          buttonIcon: ActionButtonIcon.Delete,
        },
      ],
    };
  }

  changeStatus(id: string, e: any) {
    this.posterService.changeStatus(id).subscribe((result) => {
      if (result.isSuccess) {
        this.list.getData();
      }
    });
  }

  delete(id: string) {
    this.globalService.showConfirm('هل تريد حذف هذا العنصر؟');
    this.globalService.confirmSubmit = () => this.isconfirm(id);
  }
  isconfirm(id: string) {
    this.posterService.delete(id).subscribe((result) => {
      if (result.isSuccess) {
        this.globalService.clearMessages();
        this.list.getData();
      }
      this.globalService.showMessage(result.message);
    });
  }

}
