import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Product } from '../models/product';

@Component({
  selector: 'app-product-list',
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.scss']
})
export class ProductListComponent implements OnInit {

  public products: any;
  constructor(private httpClient: HttpClient) { }

  ngOnInit() {
    this.httpClient.get('api/SampleData/GetSamplesOfProducts').subscribe(p => {
      console.log(p);
      this.products = p;
    });
  }

}
