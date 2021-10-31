import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class RandomNumberGeneratorService {

    private _url = "http://localhost:16934/"
  constructor(private http: HttpClient) { }

  public generate(): Observable<any> {
    return this.http.get<any>(this._url + 'weatherforecast');
  }
}