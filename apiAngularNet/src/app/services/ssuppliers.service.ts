import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Isupplier } from '../interfaces/isupplier';

@Injectable({
  providedIn: 'root'
})
export class SSuppliersService {
  private url: string = environment.endpoint;
  private endpointListSuppliers: string = 'api/values/'

  constructor(private httpclient: HttpClient) { }

  getListSuppliers() : Observable<Isupplier[]>{
    return this.httpclient.get<Isupplier[]>(this.url+this.endpointListSuppliers)
  }

  getSupplier(id?:number) : Observable<Isupplier>{
    return this.httpclient.get<Isupplier>(this.url+this.endpointListSuppliers+id)
  }

  deleteSupplier(id?:number) : Observable<string>{
    return this.httpclient.delete<string>(this.url+this.endpointListSuppliers+id)
  }

  insertUpdateSupplier(id:number, supplier: Isupplier) : Observable<string>{
    if(id == 0){
      return this.httpclient.post<string>(this.url+this.endpointListSuppliers, supplier)  
    }
    else{
      supplier.ID = id;
      return this.httpclient.put<string>(this.url+this.endpointListSuppliers, supplier)  
    }
   
  }

  
}