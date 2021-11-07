import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss']
})
export class DashboardComponent implements OnInit {

  units = {
    mapOfTheHospitalComplex: 1,
    mainHospitalBuilding: 2,
    laboratory: 3,
    ambulance: 4,
    parkingLot: 5,

    mainHospitalBuildingFloor1: 6,
    mainHospitalBuildingFloor2: 7,

    laboratoryFloor1: 8,

    ambulanceFloor1: 9,
    ambulanceFloor2: 10,

    parking:11,
    park: 12,
    backBotton: 13,
    floorButton: 14,
    
  }

  currentUnit = 1

  constructor() { }

  ngOnInit(): void {
  }

  changeUnit(unit: any) {
    this.currentUnit = unit
  }

  isUnitSelected(unit: any) {
    return this.currentUnit == unit
  }

}




