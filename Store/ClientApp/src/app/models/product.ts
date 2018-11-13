export interface Product {
  price:            number;
  shortDescription: string;
  description:      string;
  category:         Category;
  reviews:          null;
  uploadedImage:    null;
  imageUrl:         null;
  specifications:   Specification[];
  name:             string;
  id:               string;
}

export interface Category {
  order: number;
  name:  string;
  id:    string;
}

export interface Specification {
  value: string;
  name:  string;
  id:    string;
}
