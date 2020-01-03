import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LeavesComponent } from './components/site/leaves/leaves.component';

const routes: Routes = [
  { path: 'leaves', component: LeavesComponent },
  { path: '', redirectTo: '/', pathMatch: 'full' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
