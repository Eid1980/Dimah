import { TableColumn } from '@shared/interfaces/table-column.interface';
import { PagingMetaData } from '@shared/models/paging-meta-data.model';
import { FormGroup } from '@angular/forms';
import { Subscription } from 'rxjs';
import { SearchOperator } from '@shared/models/search-operator.model';
import { HelperFunctions } from '@shared/helpers/helper-functions';
import { OnInit, Optional } from '@angular/core';
import { DataAccessService } from '@shared/services/data-access.service';
import { ServiceLocator } from '@shared/services/service-locator';
import { TableAction } from '@shared/models/table-action';
import { SearchModel } from '@proxy/shared/search-model.model';
import { DynamicSearchService } from '@proxy/shared/dynamic-search.service';

export abstract class BaseList<TService extends DataAccessService>
  implements OnInit {
  dataItems: any[];
  cols: TableColumn[];
  actions: TableAction[];
  serviceUrl: string;
  progressSpinner: boolean;
  // search form
  pagingMetaData: PagingMetaData;
  searchForm: FormGroup;
  searchModel: SearchModel;
  searchOperators: SearchOperator[];
  subscription: Subscription;
  dynamicSearchService: DynamicSearchService;
  helper: HelperFunctions;
  service: TService;

  constructor() {
    this.dynamicSearchService = ServiceLocator.injector.get(
      DynamicSearchService
    );
    this.helper = ServiceLocator.injector.get(HelperFunctions);
    //this.service = ServiceLocator.injector.get(TService);

    this.searchModel = {};
    this.progressSpinner = true;
    this.subscription = new Subscription();
    this.actions = [];
  }

  ngOnInit() {
    // build search form
    this.createCols();
    this.searchForm = this.dynamicSearchService.buildSearchForm(this.cols);
    this.searchOperators = this.dynamicSearchService.searchOperators;
    this.getData();
  }

  getData() {
    this.subscription.add(
      this.service.getListPage(this.searchModel).subscribe(result => {
        if (result.isSuccess) {
          this.dataItems = result.data.GridItemsVM;
          this.pagingMetaData = result.data.PagingMetaData;
        }
      })
    );
  }

  onTableLazyLoad(event: any) {
    this.dynamicSearchService.lazy(event, this.searchModel, () =>
      this.getData()
    );
  }

  onSearchReset() {
    this.searchModel = {};
    this.dynamicSearchService.reset(this.searchForm, () => this.getData());
  }

  search() {
    this.dynamicSearchService.search(this.searchForm, this.searchModel, () =>
      this.getData()
    );
  }

  abstract createCols();
}
