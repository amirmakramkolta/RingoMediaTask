import { Component } from '@angular/core';
import { DepartmentService } from '../../Services/department.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-add',
  templateUrl: './add.component.html',
  styleUrl: './add.component.css'
})
export class AddComponent {
  DepartmentId = 0;
  constructor(private services:DepartmentService, private route: ActivatedRoute){
    this.route.queryParams.subscribe(params=>{
      this.DepartmentId = params['DepartmentId'] ? params['DepartmentId'] : 0
    })
  }

  
}
