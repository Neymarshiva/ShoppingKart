import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { BreadcrumbService } from 'xng-breadcrumb';
import { Breadcrumb } from 'xng-breadcrumb/lib/types/breadcrumb';

@Component({
  selector: 'app-section-header',
  templateUrl: './section-header.component.html',
  styleUrls: ['./section-header.component.scss']
})
export class SectionHeaderComponent implements OnInit {


  breadCrumb$: Observable<any[]>;

  constructor(private bcServices: BreadcrumbService) { }

  ngOnInit(): void {
    this.breadCrumb$ = this.bcServices.breadcrumbs$;
  }

}
