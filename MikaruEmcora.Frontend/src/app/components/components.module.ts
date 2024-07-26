import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FooterComponent } from './footer/footer.component';
import { HeaderComponent } from './header/header.component';
import { PortfolioComponent } from './portfolio/portfolio.component';
import { AppRoutingModule } from '../app-routing.module';




@NgModule({
  declarations: [
    HeaderComponent,
    FooterComponent,
    PortfolioComponent,

  ],
  imports: [
    CommonModule,
    AppRoutingModule,
  ],
  exports: [
    HeaderComponent, //para que lo puedan usar en el app.component.html
    FooterComponent,
  ]
})
export class ComponentsModule { }
