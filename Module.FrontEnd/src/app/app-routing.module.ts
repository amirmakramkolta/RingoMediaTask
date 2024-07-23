import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MainComponent } from './Pages/main/main.component';

const routes: Routes = [
  {path:'',component:MainComponent},
  {path:'Department', loadChildren: ()=> import("./Modules/Department/department.module").then(m=>m.DepartmentModule)},
  {path:'Notification', loadChildren:()=> import("./Modules/Notification/notification.module").then(m=>m.NotificationModule)}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
