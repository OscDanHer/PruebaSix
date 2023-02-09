import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { Response } from "./Entidad/Response";

@Injectable({
    providedIn:'root'
})

export class Userservice {
    httpOptions = {
        headers: new HttpHeaders({ 
          'Access-Control-Allow-Origin':'*',
          'Authorization':'authkey',
          'userid':'1'
        })
      };

    constructor(private http:HttpClient){}
        url: string ="http://localhost:5209/Usuario/GetUsuario";
        getUsers():Observable<Response>{
            return this.http.get<Response>(this.url,this.httpOptions);
        }
    
}