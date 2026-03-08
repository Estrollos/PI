import { Component } from '@angular/core';
import { NgOptimizedImage } from "@angular/common";
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-product',
  imports: [NgOptimizedImage, FormsModule],
  templateUrl: './product.html',
  styleUrl: './product.css',
})
export class Product {
  size:string = "";
  color:string ="";

  toggleSize(value: string) {
    if (this.size === value) {
      this.size = '';
    }
  }

  toggleColor(value:string){
    if(this.color === value){
      this.color = '';
    }
  }
}
