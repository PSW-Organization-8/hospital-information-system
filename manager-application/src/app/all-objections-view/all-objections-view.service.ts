import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { serverPort } from '../app.consts';

@Injectable({
  providedIn: 'root'
})
export class AllObjectionsViewService {

  private _url = serverPort;
  constructor(private http: HttpClient) { }

  public getAllObjectionsFromServer(): Observable<any>{
    return this.http.get<any>(this._url + 'objection');
  }
}
