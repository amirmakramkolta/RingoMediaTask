import { Component, OnInit } from '@angular/core';
import { GetEmailDto } from '../../Types';
import { NotificationService } from '../../Services/notification.service';

@Component({
  selector: 'app-get',
  templateUrl: './get.component.html',
  styleUrl: './get.component.css'
})
export class GetComponent implements OnInit{
  Emails:GetEmailDto[] = []
  constructor(private services:NotificationService){

  }
  ngOnInit(): void {
    this.services.GetEmails().subscribe(e=>{
      this.Emails = e
    })
  }

}
