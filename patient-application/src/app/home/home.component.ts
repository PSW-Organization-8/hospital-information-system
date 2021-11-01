import { Component, OnInit } from '@angular/core';
import { RandomNumberGeneratorService } from '../feedback.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  approvedFeedback: any;
  f1:any;
  f2:any;
  f3:any;
  constructor(private _feedbackService:RandomNumberGeneratorService) { }

  ngOnInit(): void {
    this.getApprovedFeedback();
    this.f1 = "content";

  }

  getApprovedFeedback(): void{
    this._feedbackService.getApprovedFeedbackFromServer().subscribe(f => this.approvedFeedback = f);
  }
}
