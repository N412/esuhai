import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HeaderComponent } from './components/layout/header/header.component';
import { SidebarComponent } from './components/layout/sidebar/sidebar.component';
import { FooterComponent } from './components/layout/footer/footer.component';
import { AsideComponent } from './components/layout/aside/aside.component';
import { LeavesComponent } from './components/site/leaves/leaves.component';
import { AuthService } from './_services/auth.service';
import { HttpClientModule } from '@angular/common/http';
import { PaginationModule } from 'ngx-bootstrap/pagination';
import { FormsModule } from '@angular/forms';
import { NgSelectModule } from '@ng-select/ng-select';
import {TranslateModule} from '@ngx-translate/core';
import { LeaveDialogComponent } from './components/site/leaves/leaveDialog/leaveDialog.component';
import { LeaveDialogService } from './_services/leaveDialog.service';
import { ModalModule } from 'ngx-bootstrap';
import { DynamicDialogModule } from 'primeng/dynamicdialog';
import { DynamicDialogRef } from 'primeng/components/dynamicdialog/dynamicdialog-ref';
import { DialogService } from 'primeng/api';
import {CalendarModule} from 'primeng/calendar';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    SidebarComponent,
    FooterComponent,
    AsideComponent,
    LeavesComponent,
    LeaveDialogComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    HttpClientModule,
    AppRoutingModule,
    PaginationModule.forRoot(),
    NgSelectModule,
    FormsModule,
    TranslateModule.forRoot(),
    ModalModule.forRoot(),
    DynamicDialogModule,
    CalendarModule
  ],
  providers:[
    AuthService,
    LeaveDialogService,
    DynamicDialogRef,
    LeaveDialogService,
    DialogService
  ],
  bootstrap: [AppComponent],
  entryComponents:[
    LeaveDialogComponent
  ]
})
export class AppModule {
  constructor(private dialogService: DialogService){}
}
