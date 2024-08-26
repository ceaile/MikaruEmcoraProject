import { Component, OnInit, AfterViewInit, OnDestroy } from '@angular/core';
import { StyleService } from '../../services/style/style.service';

@Component({
  selector: 'app-about-me',
  templateUrl: './about-me.component.html',
  styleUrls: ['./about-me.component.css']
})
export class AboutMeComponent implements OnInit, AfterViewInit, OnDestroy {
  colorAbout = "#d8eef1b3"; //celeste

  constructor(private styleService: StyleService) { }

  ngOnInit(): void {
    this.styleService.setBackgroundImage('assets/img/bgAboutMika.jpg');
    this.styleService.setBackgroundColor(this.colorAbout);


  }

  ngAfterViewInit(): void { //not working, volverlo a poner en oninit
    this.styleService.setHeaderColor(this.colorAbout);
    this.styleService.setFooterColor(this.colorAbout);
    this.styleService.hidePortraitElement();
  }

  ngOnDestroy(): void {
    this.styleService.resetBackgroundImage();
    this.styleService.resetBackgroundColor();
    this.styleService.resetHeaderColor();
    this.styleService.resetFooterColor();

    this.styleService.showPortraitElement();
  }
}

