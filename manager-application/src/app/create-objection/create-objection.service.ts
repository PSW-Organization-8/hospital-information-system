import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { serverPort } from '../app.consts';

@Injectable({
  providedIn: 'root'
})
export class CreateObjectionService {

  private _url = serverPort;
  constructor(private http: HttpClient) { }

public sendObjectionToServer(pharmacyName: string,textObjection:string): void {
  let objection = {
    PharmacyName: pharmacyName,
    TextObjection: textObjection
  };
  this.http.post<any>(this._url + 'objectionCreate', objection).subscribe();
 }
}
