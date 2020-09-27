import { Component, OnInit } from '@angular/core';
import { IProduct } from 'src/app/shared/models/product';
import { ShopService } from '../shop.service';
import { ActivatedRoute } from '@angular/router';
import { BreadcrumbService } from 'xng-breadcrumb';

@Component({
  selector: 'app-product-details',
  templateUrl: './product-details.component.html',
  styleUrls: ['./product-details.component.scss'],
})
export class ProductDetailsComponent implements OnInit {
  product: IProduct;

  constructor(
    private shopServices: ShopService,
    private activateRoute: ActivatedRoute,
    private bcService: BreadcrumbService
  ) {}

  ngOnInit(): void {
    this.loadProduct();
  }
  loadProduct() {
    this.shopServices
      .getProducts(+this.activateRoute.snapshot.paramMap.get('id'))
      .subscribe(
        (result) => {
          this.product = result;
          this.bcService.set('@productDetails', result.name);
        },
        (error) => {
          console.log(error);
        }
      );
  }
}
