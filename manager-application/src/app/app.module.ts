import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { AllFeedbackViewComponent } from './feedbacks/all-feedback-view/all-feedback-view.component';
import { AllFeedbackViewService } from './feedbacks/all-feedback-view/all-feedback-view.service';

@NgModule({
  declarations: [
    AppComponent,
    AllFeedbackViewComponent,
  ],
  imports: [
    BrowserModule,
    HttpClientModule
  ],
  providers: [AllFeedbackViewService],
  bootstrap: [AppComponent]
})
export class AppModule { }
