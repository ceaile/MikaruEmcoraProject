import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BrowserModule } from '@angular/platform-browser';
import { ReactiveFormsModule } from '@angular/forms';

import { FooterComponent } from './footer/footer.component';
import { HeaderComponent } from './header/header.component';
import { PortfolioComponent } from './portfolio/portfolio.component';
import { AppRoutingModule } from '../app-routing.module';
import { FormComponent } from './form/form.component';




@NgModule({
  declarations: [
    HeaderComponent,
    FooterComponent,
    PortfolioComponent,
    FormComponent,

  ],
  imports: [
    CommonModule,
    AppRoutingModule,
    ReactiveFormsModule,
    BrowserModule,
  ],
  exports: [
    HeaderComponent, //para que lo puedan usar en el app.component.html
    FooterComponent,
    FormComponent, // para poder usarlo en diferentes pags
  ]
})
export class ComponentsModule { }
