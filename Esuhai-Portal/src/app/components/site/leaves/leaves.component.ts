import { Component, OnInit } from '@angular/core';
import { AuthService } from 'src/app/_services/auth.service';
import { LeavesService } from 'src/app/_services/leaves.service';
import { Pagination, PaginatedResult } from 'src/app/_models/pagination';
import { Leave } from 'src/app/_models/leave';
import { formatDate } from '@angular/common';
import { DialogService, MessageService } from 'primeng/api';
import { LeaveDialogComponent } from './leaveDialog/leaveDialog.component';
import { LeaveDialogService } from 'src/app/_services/leaveDialog.service';

@Component({
  selector: 'app-leaves',
  templateUrl: './leaves.component.html',
  styleUrls: ['./leaves.component.css'],
  providers: [MessageService, LeaveDialogService, DialogService],
  entryComponents: [LeaveDialogComponent]
})
export class LeavesComponent implements OnInit {

  constructor(public messageService: MessageService, public authServices: AuthService,
    private leaveServices: LeavesService,
    public dialogService: DialogService) { }

  pagination: Pagination;
  leaves: Leave[];
  leaveParams: any = {};
  departments: any = [];
  employees: any = [];
  answers: string[] = [];

  typeLeaves = [
    { value: '', name: 'Tất cả' },
    { value: 'WaitingTPTB', name: 'Đang chờ TP/TB duyệt' },
    { value: 'WaitingHR', name: 'Đang chờ NS duyệt' },
    { value: 'HRApproved', name: 'NS đã duyệt' },
    { value: 'HRRejected', name: 'NS từ chối' }
  ];

  ngOnInit() {
    this.pagination = { CurrentPage: 1, ItemsPerPage: 20, TotalItems: null, TotalPages: null };

    this.authServices.getObjectsForLeave().subscribe(resp => {
      this.departments = resp.listDepartments;
      this.employees = resp.ListEmployees;

      this.leaveParams.DepartmentId = this.departments[0].id;
      this.leaveParams.FilterBy = this.typeLeaves[1].value;
      this.leaveParams.EmployeeId = 0;
      this.leaveParams.StartDate = formatDate(new Date(), '2018-MM-01', 'en');
      this.leaveParams.EndDate = formatDate(new Date(new Date().setMonth(new Date().getMonth() + 1)), 'yyyy-MM-01', 'en');

      this.loadUsers();
    }, error => {
      console.log(error);
    });
  }

  pageChanged(event: any): void {
    this.pagination.CurrentPage = event.page;
    this.loadUsers();
  }

  typeChanged(): void {
    this.loadUsers();
  }

  loadUsers() {
    this.leaveServices.getLeaves(this.pagination.CurrentPage, this.pagination.ItemsPerPage, this.leaveParams)
      .subscribe((res: PaginatedResult<Leave[]>) => {
        this.leaves = res.result;
        this.pagination = res.pagination;
      }, error => {
        //this.alertify.error(error);
      });
  }
  
  showLeaveDialog() {
    const ref = this.dialogService.open(LeaveDialogComponent, {
      header: 'Đăng lý nghỉ phép',
      width: '800px',
      baseZIndex: 9999,
      data: {
        "action": "addnew"
      }
    });
  }

}