import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { GoodsItem } from '../models/goodsItem.model';

@Injectable()
export class GoodsCRUDService {

  goods: GoodsItem[];

  constructor(private http: HttpClient) {
    this.getGoods();
  }

  getGoods() {
    this.http.get<GoodsItem[]>("/api/goods").subscribe(response => this.goods = response);
  }
}
