import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import Swal from 'sweetalert2';
import { RandomNumberGeneratorService } from '../feedback.service';

@Component({
  selector: 'app-feedback',
  templateUrl: './feedback.component.html',
  styleUrls: ['./feedback.component.css']
})
export class FeedbackComponent implements OnInit {
  feedback: any;
  content: string = "";
  anonymous: boolean = false;
  publishable: boolean = true;
  isContentEmpty: boolean = true;

  constructor(private _feedbackService:RandomNumberGeneratorService) { }

  ngOnInit(): void {
    this.getFeedback();
  }

  getFeedback(): void{
    this._feedbackService.getFeedbackFromServer().subscribe(f => this.feedback = f);
  }

  sendFeedback(): void{
    if(this.content == ""){
      Swal.fire({
        icon: 'error',
        title: 'Error',
        text: 'Please fill out the text field',
      })
    }
    else{
      this._feedbackService.sendFeedbackToServer(this.content, this.anonymous, this.publishable);
      const Toast = Swal.mixin({
        toast: true,
        position: 'top-end',
        showConfirmButton: false,
        timer: 3000,
        timerProgressBar: true,
        didOpen: (toast) => {
          toast.addEventListener('mouseenter', Swal.stopTimer)
          toast.addEventListener('mouseleave', Swal.resumeTimer)
        }
      })
      
      Toast.fire({
        icon: 'success',
        title: 'Successfully sent feedback'
      })
      this.content = "";
    }
  }
}
