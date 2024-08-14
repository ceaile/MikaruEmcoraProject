import { AfterContentChecked, AfterContentInit, AfterViewChecked, AfterViewInit, Component, DoCheck, OnChanges, OnDestroy, OnInit, SimpleChanges } from '@angular/core';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrl: './header.component.css'
})
export class HeaderComponent {
  varTitleDelHeader = 'Mikaru Emcora Portfolio';

  //rutas pueden cambiar si mi prima cambia de username xd
  rutaIconoKofi = '/assets/img/kofiLogo.png';
  rutaIconoTwitter = '/assets/img/xLogo.png';
  rutaIconoInstagram = '/assets/img/instaLogo.png';
  rutaIconoTikTok = '/assets/img/tiktokLogo.png';

  //pendiente: alguna forma de editar desde la interfaz el username de rrrss ella misma u ocultarlos si se elimina la cuenta



  constructor() { }

  onDataCheck(e: any) { //para probar a enviar desde componente hijo a padre con event emitter
    console.log(e);
  }
}
