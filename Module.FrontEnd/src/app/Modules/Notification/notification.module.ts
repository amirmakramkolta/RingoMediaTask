import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { NotificationRoutingModule } from './notification-routing.module';
import { AddComponent } from './Pages/add/add.component';
import { GetComponent } from './Pages/get/get.component';
import { FormsModule } from '@angular/forms';


@NgModule({
  declarations: [
    AddComponent,
    GetComponent
  ],
  imports: [
    CommonModule,
    NotificationRoutingModule,
    FormsModule
  ]
})
export class NotificationModule { }
