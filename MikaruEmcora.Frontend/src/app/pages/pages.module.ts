import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ReactiveFormsModule } from '@angular/forms';

import { AdminComponent } from './admin/admin.component'; // en rojo "duplicate identifier
import { ContactMeComponent } from './contact-me/contact-me.component';
import { NotFoundComponent } from './not-found/not-found.component';
import { AboutMeComponent } from './about-me/about-me.component';
import { HomeComponent } from './home/home.component';

import { ComponentsModule } from '../components/components.module';

import { RouterModule } from '@angular/router';
import { MediaService } from '../services/media/media.service';




@NgModule({
  declarations: [
    AboutMeComponent,
    ContactMeComponent,
    NotFoundComponent,
    AdminComponent,
    HomeComponent,
  ],
  imports: [
    CommonModule,
    ComponentsModule, //para acceder a los forms para las pags que tengan
    ReactiveFormsModule,
    RouterModule
  ],
  exports: [
    //ContactMeComponent, //no necesario dado que ya esta declarado y app module importa pagesmodule
    //AboutMeComponent,
  ],
  providers: [
    MediaService, //si solo lo quisiera usar aqui en lugar de poner root 
  ]
})
export class PagesModule { }
