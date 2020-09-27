import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { IPagination } from '../shared/models/pagination';
import { IBrand } from '../shared/models/brand';
import { IType } from '../shared/models/productType';
import { map } from 'rxjs/operators';
import { ShopParams } from '../shared/models/shopParams';
import { IProduct } from '../shared/models/product';

@Injectable({
  providedIn: 'root',
})
export class ShopService {
  baseUrl = 'https://localhost:44372/api/';

  constructor(private http: HttpClient) {}

  getProduct(shopParams: ShopParams) {
    debugger;
    let params = new HttpParams();
    if (shopParams.brandId !== 0) {
      params = params.append('brandId', shopParams.brandId.toString());
    }
    if (shopParams.typeId !== 0) {
      params = params.append('typeId', shopParams.typeId.toString());
    }
    params = params.append('Sort', shopParams.sort.toString());
    params = params.append('PageSize', shopParams.pageSize.toString());
    params = params.append('PageIndex', shopParams.pageNumber.toString());
    if(shopParams.search){
      params = params.append('Search', shopParams.search);
    }
   

    return this.http
      .get<IPagination>(this.baseUrl + 'products', {
        observe: 'response',
        params,
      })
      .pipe(
        map((response) => {
          debugger;
          return response.body;
        })
      );
  }

  getBrand() {
    return this.http.get<IBrand[]>(this.baseUrl + 'Products/brands');
  }

  getType() {
    return this.http.get<IType[]>(this.baseUrl + 'Products/types');
  }

  getProducts(id: number){
    return this.http.get<IProduct>(this.baseUrl + 'Products/' + id);
  }
}
