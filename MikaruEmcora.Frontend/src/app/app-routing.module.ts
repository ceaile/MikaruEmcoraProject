import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AboutMeComponent } from './pages/about-me/about-me.component';
import { ContactMeComponent } from './pages/contact-me/contact-me.component';
import { NotFoundComponent } from './pages/not-found/not-found.component';
const routes: Routes = [
  { path: 'aboutMe', component: AboutMeComponent }, //not exists yet
  { path: 'contactMe', component: ContactMeComponent }, //not exists yet
  { path: '', redirectTo: '/products', pathMatch: 'full' },
  { path: '**', component: NotFoundComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
