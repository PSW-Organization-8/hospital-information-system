import { Component, OnInit } from '@angular/core';
import { CreateObjectionService } from './create-objection.service';


@Component({
  selector: 'app-create-objection',
  templateUrl: './create-objection.component.html',
  styleUrls: ['./create-objection.component.css']
})
export class CreateObjectionComponent implements OnInit {
  
  pharmacyName: string="";
  text: string="";

  constructor(private service: CreateObjectionService) { }
 

  ngOnInit(): void {
   
  }

  sendObjection(): void{
    this.service.sendObjectionToServer(this.pharmacyName,this.text);
  }

}
