import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { Routes, RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { AllFeedbackViewComponent } from './feedbacks/all-feedback-view/all-feedback-view.component';
import { AllFeedbackViewService } from './feedbacks/all-feedback-view/all-feedback-view.service';
import { PharmacyRegistrationComponent } from './pharmacy-registration/pharmacy-registration.component';

import { CommonModule } from '@angular/common';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ToastrModule } from 'ngx-toastr';
import { HeaderComponent } from './header/header.component';
import { HomeComponent } from './home/home.component';

const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'feedbackview', component: AllFeedbackViewComponent },
  { path: 'pharmacyRegistration', component: PharmacyRegistrationComponent },
  { path: 'header', component: HeaderComponent }
];

@NgModule({
  declarations: [
    AppComponent,
    AllFeedbackViewComponent,
    PharmacyRegistrationComponent,
    HeaderComponent,
    HomeComponent,
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
