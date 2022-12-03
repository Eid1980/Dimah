import { Component, OnInit, ViewChild } from '@angular/core';
import { PageListComponent } from '@shared/components/page-list/page-list.component';
import { PageListSetting } from '@shared/interfaces/page-list-setting';
import { ActionButtonClass } from '@shared/enums/action-button-class';
import { ActionButtonIcon } from '@shared/enums/action-button-icon';
import { ColumnType } from '@shared/enums/column-type.enum';
import { GlobalService } from '@shared/services/global.service';
import { RoleService } from '@shared/proxy/roles/role.service';
import { UserRoleService } from '@shared/proxy/user-roles/user-role.service';
import { GetRolUsersDto } from '@shared/proxy/user-roles/models';

@Component({
  selector: 'app-role-list',
  templateUrl: './role-list.component.html'
})
export class RoleListComponent implements OnInit {
  @ViewChild(PageListComponent, { static: true }) list: PageListComponent;
  pageListSettings: PageListSetting;
  showDialog: boolean = false;
  rolUsersDto = [] as GetRolUsersDto[]

  constructor(private roleService: RoleService, private userRoleService: UserRoleService,
    private globalService: GlobalService) {
  }

  ngOnInit() {
    this.globalService.setAdminTitle('الصلاحيات');
    this.pageSetting();
  }

  pageSetting() {
    this.pageListSettings = {
      PageTitle: 'البحث في الصلاحيات',
      listPermissionCode: '*',
      createButtonLink: '/admin/home/role-add',
      createButtonText: 'اضافة صلاحية جديدة',
      Url: this.roleService.serviceUrl,

      cols: [
        { Field: 'id', Header: 'الكود', Searchable: false, Hidden: true },
        { Field: 'nameAr', Header: 'الاسم عربي' },
        { Field: 'nameEn', Header: 'الاسم انجليزي' },
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
          title: 'تعديل',
          routerLink: '/admin/home/role-edit',
          IsQueryParams: true,
          buttonclass: ActionButtonClass.Edit,
          buttonIcon: ActionButtonIcon.Edit,
        },
        {
          title: 'التفاصيل',
          routerLink: '/admin/home/role-view',
          IsQueryParams: true,
          buttonclass: ActionButtonClass.View,
          buttonIcon: ActionButtonIcon.View,
        },
        {
          title: 'المستخدمون المضافون',
          FuncName: (id) => this.preview(id),
          buttonclass: ActionButtonClass.View,
          buttonIcon: ActionButtonIcon.Users,
        },
        //{
        //  title: 'حذف',
        //  FuncName: (id) => this.delete(id),
        //  buttonclass: ActionButtonClass.Delete,
        //  buttonIcon: ActionButtonIcon.Delete,
        //},
      ],
    };
  }

  preview(id: number) {
    if (id) {
      this.userRoleService.getUsersByRoleId(id).subscribe((response) => {
        this.rolUsersDto = response.data;
      });
      this.showDialog = true;
    }
  }
  closeDialog() {
    this.rolUsersDto = [];
    this.showDialog = false;
  }

  changeStatus(id: number, e: any) {
    this.roleService.changeStatus(id).subscribe((result) => {
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
    this.roleService.delete(id).subscribe((result) => {
      if (result.isSuccess) {
        this.globalService.clearMessages();
        this.list.getData();
      }
      this.globalService.showMessage(result.message);
    });
  }
}
