import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { NotificationRoutingModule } from './notification-routing.module';
import { AddComponent } from './Pages/add/add.component';
import { GetComponent } from './Pages/get/get.component';


@NgModule({
  declarations: [
    AddComponent,
    GetComponent
  ],
  imports: [
    CommonModule,
    NotificationRoutingModule
  ]
})
export class NotificationModule { }
