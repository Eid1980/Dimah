import { Component, OnInit, ViewChild } from '@angular/core';
import { PageListComponent } from '@shared/components/page-list/page-list.component';
import { PageListSetting } from '@shared/interfaces/page-list-setting';
import { ActionButtonClass } from '@shared/enums/action-button-class';
import { ActionButtonIcon } from '@shared/enums/action-button-icon';
import { ColumnType } from '@shared/enums/column-type.enum';
import { GlobalService } from '@shared/services/global.service';
import { UserRoleService } from '@shared/proxy/user-roles/user-role.service';
import { AccountService } from '@shared/proxy/accounts/account.service';
import { UserDataViewComponent } from '@shared/components/user-data-view/user-data-view.component';
import { GetUserRoleListDto } from '@shared/proxy/user-roles/models';

@Component({
  selector: 'app-user-list',
  templateUrl: './user-list.component.html'
})
export class UserListComponent implements OnInit {
  @ViewChild(PageListComponent, { static: true }) list: PageListComponent;
  @ViewChild(UserDataViewComponent, { static: true }) userDataView: UserDataViewComponent;
  pageListSettings: PageListSetting;
  showRolesDialog: boolean = false;
  showDetailsDialog: boolean = false;
  userRolesDto = [] as GetUserRoleListDto[];

  constructor(private userRoleService: UserRoleService, private accountService: AccountService,
    private globalService: GlobalService) {
  }

  ngOnInit() {
    this.globalService.setAdminTitle('المستخدمون');
    this.pageSetting();
  }

  pageSetting() {
    this.pageListSettings = {
      PageTitle: 'البحث في المستخدمين',
      listPermissionCode: '*',
      createButtonLink: '/admin/home/user-add',
      createButtonText: 'اضافة مستخدم جديد',
      Url: this.userRoleService.serviceUrl,

      cols: [
        { Field: 'id', Header: 'الكود', Searchable: false, Hidden: true },
        { Field: 'userName', Header: 'اسم المستخدم' },
        { Field: 'fullName', Header: 'الاسم' },
        { Field: 'phoneNumber', Header: 'رقم الجوال' },
        { Field: 'nationalityName', Header: 'الجنسية' },
        {
          Field: 'Action',
          Header: 'الإجراءات',
          Searchable: false,
          Sortable: false,
          Type: ColumnType.Action,
        },
      ],

      actions: [
        {
          title: 'اضافة صلاحيات',
          routerLink: '/admin/home/user-role-add',
          IsQueryParams: true,
          buttonclass: ActionButtonClass.Edit,
          buttonIcon: ActionButtonIcon.Add,
        },
        {
          title: 'تفاصيل المستخدم',
          FuncName: (id) => this.previewDetails(id),
          buttonclass: ActionButtonClass.View,
          buttonIcon: ActionButtonIcon.View,
        },
        {
          title: 'الصلاحيات المضافة',
          FuncName: (id) => this.previewRoles(id),
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

  previewRoles(id: number) {
    if (id) {
      this.userRoleService.getRolesByUserId(id).subscribe((response) => {
        this.userRolesDto = response.data;
      });
      this.showRolesDialog = true;
    }
  }
  closeRolesDialog() {
    this.userRolesDto = [];
    this.showRolesDialog = false;
  }

  previewDetails(id: number) {
    if (id) {
      this.userDataView.initializeForm(id);
      this.showDetailsDialog = true;
    }
  }
  closeDetailsDialog() {
    this.showDetailsDialog = false;
  }

  delete(id: number) {
    this.globalService.showConfirm('هل تريد حذف هذا العنصر؟');
    this.globalService.confirmSubmit = () => this.isconfirm(id);
  }
  isconfirm(id: number) {
    this.accountService.deleteEmployee(id).subscribe((result) => {
      if (result.isSuccess) {
        this.globalService.clearMessages();
        this.list.getData();
      }
      this.globalService.showMessage(result.message);
    });
  }
}
