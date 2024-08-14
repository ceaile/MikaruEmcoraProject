import { Component } from '@angular/core';

@Component({
  selector: 'app-footer',
  templateUrl: './footer.component.html',
  styleUrl: './footer.component.css'
})
export class FooterComponent {
  rutaPortrait = "/assets/img/retratoMikaru.png";
  //añadir en el futuro forma de hacer que pueda cambiar su retrato a voluntad desde su pag admin

}
