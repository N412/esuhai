import { Component, OnInit } from '@angular/core';
import { AuthService } from './_services/auth.service';
import { User } from './_models/user';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

export class AppComponent implements OnInit {
  title = 'Esuhai-Templates';
  model: any = {};
  isLogged?: boolean;
  //user: User;

  constructor(public authService: AuthService) { }

  ngOnInit() {
    this.authService.getCurrentUser().subscribe(next => {
      this.authService.currentUser = next;
      this.isLogged = true;
    }, error => {
      this.isLogged = false;
      console.log(error);
    });

  }

}