import {
  Directive,
  Input,
  TemplateRef,
  ViewContainerRef,
  OnInit
} from "@angular/core";
import { AccountService } from "@proxy/accounts/account.service";

@Directive({
  selector: "[appAuthorize]"
})
export class AuthorizeDirective implements OnInit {
  @Input("appAuthorize") code: string;

  constructor(
    private templateRef: TemplateRef<any>,
    private viewContainer: ViewContainerRef,
    private accountService: AccountService
  ) {}

  ngOnInit() {
    this.viewContainer.createEmbeddedView(this.templateRef);
    
    // commented in super marke app
    // if (this.accountService.isAuthorizedPermission(this.code)) {
    //   this.viewContainer.createEmbeddedView(this.templateRef);
    // } else {
    //   this.viewContainer.clear();
    // }
  }
}
