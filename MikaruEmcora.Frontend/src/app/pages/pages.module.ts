import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AboutMeComponent } from './about-me/about-me.component';
import { ContactMeComponent } from './contact-me/contact-me.component';
import { NotFoundComponent } from './not-found/not-found.component';
import { ComponentsModule } from '../components/components.module';
import { MediaService } from '../services/media/media.service';
import { LoginComponent } from './login/login.component';



@NgModule({
  declarations: [
    AboutMeComponent,
    ContactMeComponent,
    NotFoundComponent,
    LoginComponent,
  ],
  imports: [
    CommonModule,
    ComponentsModule,
  ],
  exports: [
    ContactMeComponent, //para que lo puedan usar en el app.component.html
    AboutMeComponent,
  ],
  providers: [
    MediaService, //si solo lo quisiera usar aqui en lugar de poner root 
  ]
})
export class PagesModule { }
