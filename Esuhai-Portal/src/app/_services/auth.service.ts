import { Injectable, OnInit } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { map } from 'rxjs/operators';
import { Observable } from 'rxjs';
import { User } from '../_models/user';
import { environment } from 'src/environments/environment';

const requestOptions = {
  withCredentials: true
};

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  private baseUrl = 'http://localhost:37916/api/auth/currentuser';
  private baseUrl1 = 'http://localhost:37916/api/auth/';

  currentUser: User;

  constructor(private http: HttpClient) { }

  getCurrentUser() {
    return this.http.get<User>(this.baseUrl, requestOptions);
  }

  getCurrentUser1() {
    return this.http.get<User>(this.baseUrl, requestOptions).pipe(
      map((response: User) => {
        const user = response;
        this.currentUser = response;

        console.log(this.currentUser);

        // if (user) {
        //   localStorage.setItem('token', user.token);
        //   localStorage.setItem('user', JSON.stringify(user.user));
        //   this.decodedToken = this.jwtHelper.decodeToken(user.token);
        //   this.currentUser = user.user;
        //   this.changeMemberPhoto(this.currentUser.photoUrl);
        // }
      })
    );
  }

  getObjectsForLeave() {

    var apiUrl = environment.apiUrl + environment.pr_AllObjectsForLeave;
    return this.http.get<any>(apiUrl, requestOptions);
    
  }

}
