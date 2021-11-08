import { Component, OnInit } from '@angular/core';
import { RandomNumberGeneratorService } from '../services/feedback.service';
import { PatientService } from '../services/patient.serivce';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  approvedFeedback: any;
  patient: any;
  constructor(private _feedbackService:RandomNumberGeneratorService, private _patientService:PatientService) { }

  ngOnInit(): void {
    this.getApprovedFeedback();
  }

  getApprovedFeedback(): void{
    this._feedbackService.getApprovedFeedbackFromServer().subscribe(f => this.approvedFeedback = f);
  }
}
