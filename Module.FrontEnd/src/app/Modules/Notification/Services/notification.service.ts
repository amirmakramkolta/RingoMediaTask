import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../../../../environments/environment.development';
import { AddEmailDto, GetEmailDto } from '../Types';

@Injectable({
  providedIn: 'root'
})
export class NotificationService {

  constructor(private http:HttpClient) { }
  baseLink = environment.NotificationUrl
  GetEmails(){
    return this.http.get<GetEmailDto[]>(`${this.baseLink}api/Notification/GetEmails`)
  }
  AddEmail(email:AddEmailDto){
    return this.http.post(`${this.baseLink}api/Notification/AddEmail`,email,{observe:'response'})
  }
}
