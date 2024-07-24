import { Component } from '@angular/core';
import { NotificationService } from '../../Services/notification.service';
import { ToastrService } from 'ngx-toastr';
import { AddEmailDto } from '../../Types';
import { Router } from '@angular/router';

@Component({
  selector: 'app-add',
  templateUrl: './add.component.html',
  styleUrl: './add.component.css'
})
export class AddComponent {
  constructor(private service:NotificationService, private toastr:ToastrService, private router: Router,){

  }
  Email = ""
  DateTime = ""
  Submit(){
    if(!this.Email && !this.DateTime){
      this.toastr.error("Please fill all fields")
      return
    }
    const emailToGo:AddEmailDto = {
      email: this.Email,
      sentAt:this.DateTime
    }
    console.log(emailToGo)
    this.service.AddEmail(emailToGo).subscribe(e=>{
      if(e.status!=204){
        this.toastr.error("Something wrong please contact admin")
        return
      }
      this.router.navigate(['/','Notification'])
    })
  }
}
