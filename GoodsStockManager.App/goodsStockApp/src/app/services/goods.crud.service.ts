import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable()
export class GoodsCRUDService {

  constructor(private http: HttpClient) { }

  getGoods() {}
}
