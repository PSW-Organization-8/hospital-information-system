import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { RandomNumberGeneratorService } from '../feedback.service';

@Component({
  selector: 'app-feedback',
  templateUrl: './feedback.component.html',
  styleUrls: ['./feedback.component.css']
})
export class FeedbackComponent implements OnInit {
  feedback: any;
  constructor(private _feedbackService:RandomNumberGeneratorService) { }

  ngOnInit(): void {
    this.getFeedback();
  }

  getFeedback(): void{
    this._feedbackService.generate().subscribe(f => this.feedback = f);
  }

}
