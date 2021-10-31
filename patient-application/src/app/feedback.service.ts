import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { Content } from '@angular/compiler/src/render3/r3_ast';

@Injectable({
  providedIn: 'root'
})
export class RandomNumberGeneratorService {

    private _url = "http://localhost:16934/"
  constructor(private http: HttpClient) { }

  public getFeedbackFromServer(): Observable<any> {
    return this.http.get<any>(this._url + 'feedback');
  }

  public sendFeedbackToServer(content: string): void {
    this.http.post(this._url + 'feedback', content);
  }
}