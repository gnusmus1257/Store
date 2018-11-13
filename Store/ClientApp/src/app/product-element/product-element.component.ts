import { HttpClient } from '@angular/common/http';
import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-product-element',
  templateUrl: './product-element.component.html',
  styleUrls: ['./product-element.component.scss']
})
export class ProductElementComponent implements OnInit {

  @Input() name: string;
  @Input() price: number;
  @Input() shortDescription: string;
  @Input() category: string;
  @Input() imageUrl: string;
  constructor() { }

  ngOnInit() {
  }

}
