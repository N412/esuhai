import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { map } from 'rxjs/operators';
import { Leave } from '../_models/leave';
import { Observable } from 'rxjs';
import { PaginatedResult } from '../_models/pagination';

const requestOptions = {
  withCredentials: true
};

@Injectable({
  providedIn: 'root'
})
export class LeavesService {
  private baseUrl = environment.apiUrl;

  constructor(private http: HttpClient) { }

  getLeaves(page?, itemsPerPage?, leaveParams?): Observable<PaginatedResult<Leave[]>> {
    const paginatedResult: PaginatedResult<Leave[]> = new PaginatedResult<Leave[]>();

    let params = new HttpParams();

    if (page != null && itemsPerPage != null) {
      params = params.append('pageNumber', page);
      params = params.append('pageSize', itemsPerPage);
    }

    if (leaveParams != null) {
      params = params.append('EmployeeId', leaveParams.EmployeeId);
      params = params.append('DepartmentId', leaveParams.DepartmentId);
      params = params.append('FilterBy', leaveParams.FilterBy);
      params = params.append('StartDate', leaveParams.StartDate);
      params = params.append('EndDate', leaveParams.EndDate);
    }

    return this.http.get<Leave[]>(this.baseUrl + '/leave', { withCredentials: true, observe: 'response', params})
      .pipe(
        map(response => {
          paginatedResult.result = response.body;
          if (response.headers.get('Pagination') != null) {
            paginatedResult.pagination = JSON.parse(response.headers.get('Pagination'));
          }
          return paginatedResult;
        })
      );
  }

}
