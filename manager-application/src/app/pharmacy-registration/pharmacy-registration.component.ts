import { Component, OnInit } from '@angular/core';
import { PharmacyRegistrationService } from './pharmacy-registration.service';
import { Pharmacy } from './pharmacy';
import { ToastrService } from 'ngx-toastr';
import { empty } from 'rxjs';

@Component({
  selector: 'app-pharmacy-registration',
  templateUrl: './pharmacy-registration.component.html',
  styleUrls: ['./pharmacy-registration.component.css']
})
export class PharmacyRegistrationComponent implements OnInit {

  constructor(
    private pharmacyRegistrationService: PharmacyRegistrationService,
    private toastr: ToastrService
  ) { }

  model = new Pharmacy("", "", "", 0)

  ngOnInit(): void {
  }

  onSubmit(): void {
    this.pharmacyRegistrationService.registerPharmacy(this.model)
    this.toastr.success('Successfully registered a pharmacy')
    this.model = new Pharmacy("", "", "", 0)
  }

}
