import { Component, OnChanges, OnInit, SimpleChanges } from '@angular/core';
import { GetDepartmentDto } from '../../Types';
import { DepartmentService } from '../../Services/department.service';
import { ActivatedRoute } from '@angular/router';
import { BehaviorSubject } from 'rxjs';

@Component({
  selector: 'app-get',
  templateUrl: './get.component.html',
  styleUrl: './get.component.css'
})
export class GetComponent{
  Departments:GetDepartmentDto[] = []
  DepartmentId = 0
  DepartmentInfo:GetDepartmentDto|undefined
  constructor(private service:DepartmentService, private route: ActivatedRoute){
    this.route.queryParams.subscribe(params=>{
      this.DepartmentId = params['DepartmentId']? params['DepartmentId'] : 0
      this.service.GetDepartments(this.DepartmentId).subscribe(e=>{
        this.Departments = e
      })
      if(this.DepartmentId){
        this.service.GetDepartment(this.DepartmentId).subscribe(e=>{
          this.DepartmentInfo = e
        })
      }
    })
  }

}
