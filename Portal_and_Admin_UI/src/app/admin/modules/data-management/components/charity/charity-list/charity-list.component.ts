import { Component, OnInit, ViewChild } from '@angular/core';
import { PageListComponent } from '@shared/components/page-list/page-list.component';
import { PageListSetting } from '@shared/interfaces/page-list-setting';
import { ActionButtonClass } from '@shared/enums/action-button-class';
import { ActionButtonIcon } from '@shared/enums/action-button-icon';
import { ColumnType } from '@shared/enums/column-type.enum';
import { GlobalService } from '@shared/services/global.service';
import { CharityService } from '@shared/proxy/charities/charity.service';
import { CharityProjectService } from '@shared/proxy/charity-projects/charity-project.service';
import { GetCharityProjectListDto } from '@shared/proxy/charity-projects/models';

@Component({
  selector: 'app-charity-list',
  templateUrl: './charity-list.component.html'
})
export class CharityListComponent implements OnInit {
  @ViewChild(PageListComponent, { static: true }) list: PageListComponent;
  pageListSettings: PageListSetting;
  showRolesDialog: boolean = false;
  charityProjects = [] as GetCharityProjectListDto[];

  constructor(private charityService: CharityService, private charityProjectService: CharityProjectService,
    private globalService: GlobalService) {
  }

  ngOnInit() {
    this.globalService.setAdminTitle('الجهات');
    this.pageSetting();
  }

  pageSetting() {
    this.pageListSettings = {
      PageTitle: 'البحث في الجهات',
      listPermissionCode: '*',
      createButtonLink: '/admin/data-management/charity-add',
      createButtonText: 'اضافة جهة جديدة',
      Url: this.charityService.serviceUrl,

      cols: [
        { Field: 'id', Header: 'الكود', Searchable: false, Hidden: true },
        { Field: 'nameAr', Header: 'الاسم عربي' },
        { Field: 'nameEn', Header: 'الاسم انجليزي' },
        { Field: 'phoneNumber', Header: 'رقم الجوال' },
        {
          Field: 'isActive',
          Header: 'الحالة',
          Searchable: false,
          Sortable: false,
          Type: ColumnType.Status,
          FuncName: (id, event) => this.changeStatus(id, event),
        },
        {
          Field: 'Action',
          Header: 'الإجراءات',
          Searchable: false,
          Type: ColumnType.Action,
        },
      ],

      actions: [
        {
          title: 'اضافة مشاريع',
          routerLink: '/admin/data-management/charity-add-project',
          IsQueryParams: true,
          buttonclass: ActionButtonClass.Edit,
          buttonIcon: ActionButtonIcon.Add,
        },
        {
          title: 'تعديل',
          routerLink: '/admin/data-management/charity-edit',
          IsQueryParams: true,
          buttonclass: ActionButtonClass.Edit,
          buttonIcon: ActionButtonIcon.Edit,
        },
        {
          title: 'التفاصيل',
          routerLink: '/admin/data-management/charity-view',
          IsQueryParams: true,
          buttonclass: ActionButtonClass.View,
          buttonIcon: ActionButtonIcon.View,
        },
        {
          title: 'المشاريع المضافة',
          FuncName: (id) => this.previewCharityProjects(id),
          buttonclass: ActionButtonClass.View,
          buttonIcon: ActionButtonIcon.Roles,
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

  previewCharityProjects(id: number) {
    if (id) {
      this.charityProjectService.getByCharityId(id).subscribe((response) => {
        this.charityProjects = response.data;
      });
      this.showRolesDialog = true;
    }
  }
  closeRolesDialog() {
    this.charityProjects = [];
    this.showRolesDialog = false;
  }

  changeStatus(id: number, e: any) {
    this.charityService.changeStatus(id).subscribe((result) => {
      if (result.isSuccess) {
        this.list.getData();
      }
    });
  }

  delete(id: number) {
    this.globalService.showConfirm('هل تريد حذف هذا العنصر؟');
    this.globalService.confirmSubmit = () => this.isconfirm(id);
  }
  isconfirm(id: number) {
    this.charityService.delete(id).subscribe((result) => {
      if (result.isSuccess) {
        this.globalService.clearMessages();
        this.list.getData();
      }
      this.globalService.showMessage(result.message);
    });
  }
}
