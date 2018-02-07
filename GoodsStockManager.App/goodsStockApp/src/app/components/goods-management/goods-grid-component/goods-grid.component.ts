import { Component } from '@angular/core';
import { MatTableDataSource, MatSort } from '@angular/material';
import { GoodsCRUDService } from '../../../services/goods.crud.service';

@Component({
  selector: "goods-grid",
  templateUrl: "goods-grid.component.html"
})
export class GoodsGridComponent {

  constructor(public goodsCrudService: GoodsCRUDService) {}

}
