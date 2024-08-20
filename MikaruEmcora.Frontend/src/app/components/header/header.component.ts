import { ViewEncapsulation, AfterViewInit, Component } from '@angular/core';
import { StyleService } from '../../services/style/style.service'; //test

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrl: './header.component.css',
  encapsulation: ViewEncapsulation.None //test, no funciona
})
export class HeaderComponent implements AfterViewInit {
  varTitleDelHeader = 'Mikaru Emcora Portfolio';

  //rutas pueden cambiar si mi prima cambia de username xd
  rutaIconoKofi = '/assets/img/kofiLogo.png';
  rutaIconoTwitter = '/assets/img/xLogo.png';
  rutaIconoInstagram = '/assets/img/instaLogo.png';
  rutaIconoTikTok = '/assets/img/tiktokLogo.png';

  //pendiente: alguna forma de editar desde la interfaz el username de rrrss ella misma u ocultarlos si se elimina la cuenta


  constructor(private styleService: StyleService) { }
  ngAfterViewInit(): void {
    console.log("style service de header ts funciona");
    
  }

}
