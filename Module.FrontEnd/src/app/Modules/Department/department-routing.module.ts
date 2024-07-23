import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { GetComponent } from './Pages/get/get.component';
import { AddComponent } from './Pages/add/add.component';

const routes: Routes = [
  {path:'', component:GetComponent},
  {path:'add', component:AddComponent}
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class DepartmentRoutingModule { }
