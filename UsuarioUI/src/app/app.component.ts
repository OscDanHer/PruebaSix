import { Component } from '@angular/core';
import { Userservice } from './Usuario.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  dataTable:any=[];

  constructor(private Userservice: Userservice){}
  OnDataTable() {
    this.Userservice.getUsers().subscribe(res => {
      if(!res.error){
        this.dataTable=res.values
      }
      console.log(res);
    });
  }
  OnGetUsers():void{
    this.OnDataTable();
  }
}
