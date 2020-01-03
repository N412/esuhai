import { Component, OnInit } from '@angular/core';
import { User } from 'src/app/_models/user';
import { AuthService } from 'src/app/_services/auth.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {

  public user: User;

  constructor(public authServices: AuthService) { }

  ngOnInit() {
    if (this.authServices.currentUser) {
      this.user = this.authServices.currentUser;
    }
    else {
      this.authServices.getCurrentUser().subscribe(next => {
        this.authServices.currentUser = next;
        this.user = next;
      }, error => {
        console.log(error);
      });
    }
  }

}
