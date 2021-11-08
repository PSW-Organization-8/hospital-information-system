import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { Content } from '@angular/compiler/src/render3/r3_ast';
import { serverPort } from '../app.consts';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root',
})
export class RandomNumberGeneratorService {
  private _url = serverPort;
  constructor(private http: HttpClient, private router:Router) {}

  public getFeedbackFromServer(): Observable<any> {
    return this.http.get<any>(this._url + 'feedback');
  }

  public sendFeedbackToServer(content: string, anonymous: boolean, publishable: boolean): void {
    let feedback = {
      Content: content,
      IsAnonymous: anonymous,
      IsPublishable: publishable,
      IsApproved: false,
      PatientId: 1,
    };
    this.http.post<any>(this._url + 'feedback', feedback).subscribe( () => {
      this.router.navigate(['']);
    }
    );
  }

  public getApprovedFeedbackFromServer(): Observable<any> {
    return this.http.get<any>(this._url + 'feedback/approved');
  }
}
