import { Component, OnChanges, OnInit, SimpleChanges } from '@angular/core';
import { Observable } from 'rxjs';
import { AllFeedbackViewService } from './all-feedback-view.service';

@Component({
  selector: 'app-all-feedback-view',
  templateUrl: './all-feedback-view.component.html',
  styleUrls: ['./all-feedback-view.component.css']
})
export class AllFeedbackViewComponent implements OnInit {

  feedbacks: any;

  constructor(private _allFeedbackViewService: AllFeedbackViewService) { }

  ngOnInit(): void {
    this.getAllFeedbacks();
  }

  getAllFeedbacks(): void{
    this._allFeedbackViewService.getFeedbackFromServer().subscribe(f => this.feedbacks = f);
  }

  aprroveFeedback(feedbackId: string): void {
    this._allFeedbackViewService.approveFeedback(feedbackId).subscribe(() => this.getAllFeedbacks());
  }

  removeFeedback(feedbackId: string): void {
    this._allFeedbackViewService.removeFeedback(feedbackId).subscribe(() => this.getAllFeedbacks());
  }
}
