import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { BsModalService, BsModalRef } from 'ngx-bootstrap';
import { LeaveDialogComponent } from '../components/site/leaves/leaveDialog/leaveDialog.component';

@Injectable()

export class LeaveDialogService {

  bsModalRef: BsModalRef;

  constructor(private bsModalService: BsModalService) { }

  show(title: string, message: string, options: string[]): Observable<string>  {
    const initialState = {
      title: title,
      message: message,
      options: options,
      answer: "",
    };
    this.bsModalRef = this.bsModalService.show(LeaveDialogComponent, { initialState });

    return new Observable<string>(this.getConfirmSubscriber());
  }

  confirm(title: string, message: string, options: string[]): Observable<string> {
    const initialState = {
      title: title,
      message: message,
      options: options,
      answer: "",
    };
    this.bsModalRef = this.bsModalService.show(LeaveDialogComponent, { initialState });

    return new Observable<string>(this.getConfirmSubscriber());
  }

  private getConfirmSubscriber() {
    return (observer) => {
      const subscription = this.bsModalService.onHidden.subscribe((reason: string) => {
        observer.next(this.bsModalRef.content.answer);
        observer.complete();
      });

      return {
        unsubscribe() {
          subscription.unsubscribe();
        }
      };
    }
  }

}
