import { Component, OnInit } from '@angular/core';
import {HttpClient} from '@angular/common/http';

@Component({
  selector: 'app-item',
  templateUrl: './item.component.html',
  styleUrls: ['./item.component.scss']
})
export class ItemComponent implements OnInit {

  items: any;  

  constructor(private http: HttpClient) { }

  ngOnInit() {

   this.getItems();   
  }
  getItems()
  {
    return this.http.get("http://localhost:5000/api/items").subscribe
    (response => {console.log(response);
     this.items = response;}, 
     error => {console.log(error);}
    );
    
    

  }
  

}
