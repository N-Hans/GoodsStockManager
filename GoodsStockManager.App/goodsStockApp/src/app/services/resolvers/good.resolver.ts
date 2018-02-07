import { Injectable } from '@angular/core';
import { Good } from '../../models/good.model';
import { Resolve, RouterStateSnapshot, ActivatedRouteSnapshot } from '@angular/router';
import { GoodsCRUDService } from '../goods.crud.service';
import { Observable } from 'rxjs/Observable';

@Injectable()
export class GoodResolver implements Resolve<Good>  {

  constructor(private goodsService: GoodsCRUDService) { }

  resolve(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): Good | Observable<Good> | Promise<Good> {
    return this.goodsService.getGood(parseInt(route.paramMap.get('id')));
  }

}
