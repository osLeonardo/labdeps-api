import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { verifyLogin } from "./login.model";

@Injectable({
    providedIn: 'root'
})
export class LoginService {
  
    baseUrl = "http://localhost:57679/api/v1/userLogin/verifyLogin";
  
    constructor(private http: HttpClient) { }

    PostLoginVerification(login: string, password: string){
        const url = `${this.baseUrl}/${login}/${password}`;  
        return this.http.get<verifyLogin[]>(url)
    }
}