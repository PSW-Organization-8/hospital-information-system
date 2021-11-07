import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { Routes, RouterModule } from '@angular/router';

import { DashboardComponent } from './editor/dashboard.component';
import { AllFeedbackViewComponent } from './feedbacks/all-feedback-view/all-feedback-view.component';
import { AllFeedbackViewService } from './feedbacks/all-feedback-view/all-feedback-view.service';
import { PharmacyRegistrationComponent } from './pharmacy-registration/pharmacy-registration.component';

import { AppComponent } from './app.component';
import { CommonModule } from '@angular/common';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ToastrModule } from 'ngx-toastr';

const routes: Routes = [
  { path: 'dashboard', component: DashboardComponent },
  { path: 'feedbackview', component: AllFeedbackViewComponent },
  { path: 'pharmacyRegistration', component: PharmacyRegistrationComponent },
];

@NgModule({
  declarations: [
    DashboardComponent,
    AppComponent,
    AllFeedbackViewComponent,
    PharmacyRegistrationComponent,
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    FormsModule,
    CommonModule,
    BrowserAnimationsModule,
    ToastrModule.forRoot(),
    RouterModule.forRoot(routes),
  ],
  exports: [RouterModule],
  providers: [AllFeedbackViewService],
  bootstrap: [AppComponent]
})
export class AppModule { }
