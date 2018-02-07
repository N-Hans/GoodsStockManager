import { Component, OnInit } from '@angular/core';
import { Good } from '../../../models/good.model';

@Component({
  selector: 'add-edit-good',
  templateUrl: 'add-edit-good.component.html'
})
export class AddEditGoodComponent implements OnInit {

  goodModel: Good;

  ngOnInit(): void {
    this.goodModel = new Good();
  }

}
