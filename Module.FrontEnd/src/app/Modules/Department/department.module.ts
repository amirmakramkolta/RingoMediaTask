import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { DepartmentRoutingModule } from './department-routing.module';
import { GetComponent } from './Pages/get/get.component';
import { AddComponent } from './Pages/add/add.component';


@NgModule({
  declarations: [
    GetComponent,
    AddComponent
  ],
  imports: [
    CommonModule,
    DepartmentRoutingModule
  ]
})
export class DepartmentModule { }
