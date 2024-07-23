import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../../../../environments/environment.development'
import { AddDepartmentDto, GetDepartmentDto } from '../Types';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class DepartmentService {

  constructor(private http:HttpClient) { }
  baseUrl = environment.DepartmentUrl
  GetDepartments(ParentDepartment:number):Observable<GetDepartmentDto[]>{
    return this.http.get<GetDepartmentDto[]>(`${this.baseUrl}api/Department/GetDepartments`, {params:{ParentDepartment}})
  }
  AddDepartment(addedDepartment:AddDepartmentDto){
    return this.http.post(`${this.baseUrl}api/Department/AddDepartment`,addedDepartment,{observe:'response'})
  }
  GetDepartment(Id:number):Observable<GetDepartmentDto>{
    return this.http.get<GetDepartmentDto>(`${this.baseUrl}api/Department/GetDepartment`,{params:{Id}})
  }
}
