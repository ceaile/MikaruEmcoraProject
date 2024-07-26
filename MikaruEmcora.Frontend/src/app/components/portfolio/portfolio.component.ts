import { Component, OnInit } from '@angular/core';
import { MediaService } from '../../services/media/media.service';

//aqui podria ir un json de media objs
@Component({
  selector: 'app-portfolio',
  templateUrl: './portfolio.component.html',
  styleUrl: './portfolio.component.css',
  providers: [
    MediaService
  ]
})
export class PortfolioComponent implements OnInit{
  //podria haber estilos css incrustados
  constructor(private mediaService: MediaService) {
  }


  media: any;

  ngOnInit(): void {
    this.mediaService.getMedia()
      .subscribe((response: any) => {
        this.media = response.media
      })

  }
}
