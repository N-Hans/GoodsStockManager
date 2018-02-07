import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Good } from '../models/good.model';
import { Observable } from 'rxjs/Observable';
import { SelectOption } from '../models/select-option.model';

@Injectable()
export class GoodsCRUDService {

  goods: Good[];
  managementTypes: SelectOption[];

  constructor(private http: HttpClient) {
    this.getGoods();
    this.getManagementTypes();
  }

  getGoods() {
    this.http.get<Good[]>("/api/goods").subscribe(response => this.goods = response);
  }

  getGood(id: number): Observable<Good> {
    return this.http.get<Good>("/api/goods/" + id);
  }

  getManagementTypes() {
    return this.http.get<SelectOption[]>("/api/goods/management-types").subscribe(response => this.managementTypes = response);
  }

}
