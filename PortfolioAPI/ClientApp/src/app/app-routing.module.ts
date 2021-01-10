import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { CreatePageComponent } from './create-page/create-page.component';
import { OpenPageComponent } from './open-page/open-page.component';

const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'create', component: CreatePageComponent },
  { path: 'open', component: OpenPageComponent }
];

@NgModule({
  declarations: [
    // HomeComponent,
    // CreatePageComponent,
    // OpenPageComponent,
    // NavMenuComponent
  ],
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
