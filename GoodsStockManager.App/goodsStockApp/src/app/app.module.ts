import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';

//Components-------------------------------------------------------------------
import { AppComponent } from './components/app.component/app.component';
import { GoodsGridComponent } from './components/goods-grid-component/goods-grid.component';
//-----------------------------------------------------------------------------

//Services---------------------------------------------------------------------
import { GoodsCRUDService } from './services/goods.crud.service';
//-----------------------------------------------------------------------------

//UI---------------------------------------------------------------------------
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
//----Material Design----------------------------------------------------------
import { MatButtonModule } from '@angular/material/button';
import { MatTableModule } from '@angular/material/table';
import { MatIconModule } from '@angular/material/icon';
import { MatProgressSpinnerModule } from '@angular/material/progress-spinner';
import { MatInputModule, MatPaginatorModule, MatSortModule } from '@angular/material';

//-----------------------------------------------------------------------------

const routes: Routes = [
  { path: '', redirectTo: '/goods-grid', pathMatch: 'full' },
  { path: "goods-grid", component: GoodsGridComponent }
];

@NgModule({
  declarations: [
    AppComponent,
    GoodsGridComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    MatButtonModule,
    MatTableModule,
    MatIconModule,
    MatInputModule,
    MatPaginatorModule,
    MatSortModule,
    MatProgressSpinnerModule,
    HttpClientModule,
    RouterModule.forRoot(routes)
  ],
  providers: [
    HttpClientModule,
    GoodsCRUDService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
