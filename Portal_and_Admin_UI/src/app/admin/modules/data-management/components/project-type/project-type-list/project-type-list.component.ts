import { Component, OnInit, ViewChild } from '@angular/core';
import { PageListComponent } from '@shared/components/page-list/page-list.component';
import { PageListSetting } from '@shared/interfaces/page-list-setting';
import { ActionButtonClass } from '@shared/enums/action-button-class';
import { ActionButtonIcon } from '@shared/enums/action-button-icon';
import { ColumnType } from '@shared/enums/column-type.enum';
import { GlobalService } from '@shared/services/global.service';
import { ProjectTypeService } from '@shared/proxy/project-types/project-type.service';

@Component({
  selector: 'app-project-type-list',
  templateUrl: './project-type-list.component.html'
})
export class ProjectTypeListComponent implements OnInit {
  @ViewChild(PageListComponent, { static: true }) list: PageListComponent;
  pageListSettings: PageListSetting;

  constructor(private projectTypeService: ProjectTypeService, private globalService: GlobalService) {
  }

  ngOnInit() {
    this.globalService.setAdminTitle(this.globalService.translate('project-type.title'));
    this.pageSetting();
  }

  pageSetting() {
    this.pageListSettings = {
      PageTitle: this.globalService.translate('project-type.searchTitle'),
      listPermissionCode: '*',
      createButtonLink: '/admin/data-management/project-type-add',
      createButtonText: this.globalService.translate('project-type.addTitle'),
      Url: this.projectTypeService.serviceUrl,

      cols: [
        { Field: 'id', Header: this.globalService.translate('global.lables.code'), Searchable: false, Hidden: true },
        { Field: 'nameAr', Header: this.globalService.translate('global.lables.nameAr') },
        { Field: 'nameEn', Header: this.globalService.translate('global.lables.nameEn') },
        {
          Field: 'isActive',
          Header: this.globalService.translate('global.lables.status'),
          Searchable: false,
          Sortable: false,
          Type: ColumnType.Status,
          FuncName: (id, event) => this.changeStatus(id, event),
        },
        {
          Field: 'Action',
          Header: this.globalService.translate('global.lables.actions'),
          Searchable: false,
          Type: ColumnType.Action,
        },
      ],

      actions: [
        {
          title: this.globalService.translate('global.buttons.update'),
          routerLink: '/admin/data-management/project-type-edit',
          IsQueryParams: true,
          buttonclass: ActionButtonClass.Edit,
          buttonIcon: ActionButtonIcon.Edit,
        },
        {
          title: this.globalService.translate('global.buttons.details'),
          routerLink: '/admin/data-management/project-type-view',
          IsQueryParams: true,
          buttonclass: ActionButtonClass.View,
          buttonIcon: ActionButtonIcon.View,
        },
        {
          title: this.globalService.translate('global.buttons.delete'),
          FuncName: (id) => this.delete(id),
          buttonclass: ActionButtonClass.Delete,
          buttonIcon: ActionButtonIcon.Delete,
        },
      ],
    };
  }

  changeStatus(id: string, e: any) {
    this.projectTypeService.changeStatus(id).subscribe((result) => {
      if (result.isSuccess) {
        this.list.getData();
      }
    });
  }

  delete(id: string) {
    this.globalService.showConfirm(this.globalService.translate('global.messages.deleteMessage'));
    this.globalService.confirmSubmit = () => this.isconfirm(id);
  }
  isconfirm(id: string) {
    this.projectTypeService.delete(id).subscribe((result) => {
      if (result.isSuccess) {
        this.globalService.clearMessages();
        this.list.getData();
      }
      this.globalService.showMessage(result.message);
    });
  }
}
