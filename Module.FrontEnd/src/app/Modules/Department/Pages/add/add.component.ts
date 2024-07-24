import { Component } from '@angular/core';
import { DepartmentService } from '../../Services/department.service';
import { ActivatedRoute, Router } from '@angular/router';
import { AddDepartmentDto, GetDepartmentDto } from '../../Types';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-add',
  templateUrl: './add.component.html',
  styleUrl: './add.component.css'
})
export class AddComponent {
  DepartmentId = 0;
  DepartmentInfo:GetDepartmentDto|undefined

  NewDepartmentName = ""
  NewDepartmentLogo = ""

  constructor(private services:DepartmentService, private route: ActivatedRoute, private router: Router, private toastr:ToastrService){
    this.route.queryParams.subscribe(params=>{
      this.DepartmentId = params['DepartmentId'] ? params['DepartmentId'] : 0
      if(this.DepartmentId != 0){
        this.services.GetDepartment(this.DepartmentId).subscribe(e=>{
          this.DepartmentInfo = e
        })
      }
    })
  }

  handleFiles(event:any){
    const file: File = event.target.files[0]
    if (file) {
      this.convertToBase64(file);
    }
  }

  convertToBase64(file: File) {
    const reader = new FileReader();
    reader.readAsDataURL(file);
    reader.onload = () => {
      // The file's Base64 representation
      this.NewDepartmentLogo = reader.result as string;
    };
  }

  Submit(){
    if(!this.NewDepartmentName || !this.NewDepartmentLogo){
      this.toastr.error("Please fill all fields")
      return
    }
    const NewDepartment: AddDepartmentDto = {
      departmentName: this.NewDepartmentName,
      logo: this.NewDepartmentLogo,
      parentDepartmentId:this.DepartmentId
    }
    this.services.AddDepartment(NewDepartment).subscribe(e=>{
      if(e.status != 204){
        this.toastr.error("Something wrong please contact admin")
        return
      }
      this.router.navigate(['/','Department'],{queryParams:{DepartmentId:this.DepartmentId}})
    })
  }
  
}
