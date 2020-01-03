import { Component, OnInit } from '@angular/core';
import { LeaveDialogService } from 'src/app/_services/leaveDialog.service';
import { DynamicDialogRef, DynamicDialogConfig } from 'primeng/api';
import { AuthService } from 'src/app/_services/auth.service';
import { Leave } from 'src/app/_models/leave';

@Component({
  selector: 'app-leaveDialog',
  templateUrl: './leaveDialog.component.html',
  styleUrls: ['./leaveDialog.component.css'],
  inputs: []
  //providers: [DynamicDialogRef, DynamicDialogConfig]
})

export class LeaveDialogComponent implements OnInit {

  title: string;
  message: string;
  options: string[];
  answer: string = "";

  leave: any;
  value: Date;

  employees: any[];

  leaveForm: Leave;

  nhanviennghiphep: any;

  constructor(private leaveDialogService: LeaveDialogService,
    public ref: DynamicDialogRef,
    public config: DynamicDialogConfig,
    private authServices: AuthService) {
      this.leaveForm.nhanVienNghiPhepId = this.authServices.currentUser.id;
    }

  // respond(answer: string) {
  //   this.answer = answer;

  //   this.bsModalRef.hide();
  // }

  ngOnInit() {
    this.authServices.getObjectsForLeave().subscribe(resp => {
      this.employees = resp.listEmployees;

      if (this.config.data.action == 'addnew') {
        this.nhanviennghiphep = resp.listEmployees.filter(x => x.id == this.authServices.currentUser.id)[0];
      }

    }, error => {
      console.log(error);
    });

    // console.log(this.config.data);
    // console.log(this.ref);
    // console.log(this.authService.currentUser);

  }

  sendForm() {
    this.leaveForm.nhanVienNghiPhepId = this.nhanviennghiphep.id;
    console.log(this.leaveForm);
  }
}
