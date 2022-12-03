import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'listString'
})
export class ListStringPipe implements PipeTransform {

  transform(content: string) {
    if (!content) {
      return '';
    }
    let myContent = content.split("\n");
    if (myContent.length <= 1) {
      return `<span>${content}</span>`;
    }
    else {
      let li = "";
      for (var i = 0; i < myContent.length; i++) {
        li +=`<li class="card-basic-list-item">
                  <span>${myContent[i]}</span>
                </li>`
      }
      return `<ul>${li}</ul>`;
    }
  }

}
