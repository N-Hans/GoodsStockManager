import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';


import { AppComponent } from './components/app.component/app.component';
import { GoodsGridComponent } from './components/goods-grid-component/goods-grid.component';


@NgModule({
  declarations: [
    AppComponent,
    GoodsGridComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
