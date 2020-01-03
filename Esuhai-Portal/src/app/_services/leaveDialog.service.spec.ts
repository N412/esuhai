/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { LeaveDialogService } from './leaveDialog.service';

describe('Service: LeaveDialog', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [LeaveDialogService]
    });
  });

  it('should ...', inject([LeaveDialogService], (service: LeaveDialogService) => {
    expect(service).toBeTruthy();
  }));
});
