import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../../../../environments/environment.development'

@Injectable({
  providedIn: 'root'
})
export class DepartmentService {

  constructor(private http:HttpClient) { }
  baseUrl = environment.DepartmentUrl
  GetDepartment(ParentDepartment:number){
    return this.http.get(`${this.baseUrl}/api/Department/GetDepartments`, {params:{ParentDepartment}})
  }
  AddDepartment(){

  }
}
