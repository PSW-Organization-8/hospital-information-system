import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { serverPort } from '../app.consts';
import { Pharmacy } from './pharmacy';

@Injectable({
  providedIn: 'root'
})
export class PharmacyRegistrationService {
  private _url = serverPort
  constructor(private http: HttpClient) { }
  
  public registerPharmacy(pharmacy: Pharmacy){
    return this.http.post<Pharmacy>(this._url + 'pharmacy', pharmacy)
  };

}
