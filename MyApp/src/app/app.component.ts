import { Component } from '@angular/core';
import { IProduct } from './product/IProduct';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = "Angular Demo";
  showDataBindingDemo=true;
  showDirectiveDemo=false;
  showProductsTable=false;

  showdbdemo():void{
    this.showDataBindingDemo=true;
    this.showDirectiveDemo=false;
    this.showProductsTable=false;
  }
  showdirectivedemo():void{
    this.showDirectiveDemo=true;
    this.showDataBindingDemo=false;
    this.showProductsTable=false;
  }
   

  showProducts():void{
    this.showProductsTable=true;
    this.showDataBindingDemo=false;
    this.showDirectiveDemo=false;
  }



}
