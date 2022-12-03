import { Pipe, PipeTransform } from "@angular/core";
import { TableColumn } from "@shared/interfaces/table-column.interface";
import { AccountService } from "@proxy/accounts/account.service";

@Pipe({
  name: "HiddenAuthorizeColumnFilter"
})
export class HiddenAuthorizeColumnFilterPipe implements PipeTransform {
  constructor(private accountService: AccountService) {}

  transform(cols: TableColumn[]): TableColumn[] {
    return cols.filter(
      col =>
        !col.Hidden 

        // ToDo: Permissions
        // (!col.PermissionCode ||
        //   col.PermissionCode === "" ||
        //   this.accountService.isAuthorizedPermission(col.PermissionCode))
    );
  }
}
