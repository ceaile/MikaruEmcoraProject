import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})

export class StyleService {
  private defaultBackgroundImage: string = "url('assets/img/bgComun.jpg')";
  private colorComun = "#c7bcfab3"; //lila
  private defaultBackgroundColor: string = this.colorComun;
  private defaultHeaderBgColor: string = this.colorComun;
  private defaultFooterBgColor: string = this.colorComun;

  setBackgroundImage(url: string) {
    document.body.style.backgroundImage = `url('${url}')`;
  }

  resetBackgroundImage() {
    document.body.style.backgroundImage = this.defaultBackgroundImage;
  }
  setBackgroundColor(color: string) {
    document.body.style.backgroundColor = color;
  }
  resetBackgroundColor() {
    document.body.style.backgroundColor = this.defaultBackgroundColor;
  }

  setHeaderColor(color: string) {
    const headerElement = document.querySelector('header');
    console.log(headerElement); // Verifica si el elemento es null
    if (headerElement) {
      headerElement.setAttribute('style', `background-color: ${color}`);
    }
  }

  setFooterColor(color: string) {
    const footerElement = document.querySelector('footer');
    console.log(footerElement); // Verifica si el elemento es null
    if (footerElement) {
      footerElement.setAttribute('style', `background-color: ${color}`);
    }
  }

  hidePortraitElement() {
    const portraitElement = document.querySelector('.selector-portrait');
    console.log("portrait should diappear");
    if (portraitElement) {
      portraitElement.setAttribute('style', `display: none`);
    }
  }

  resetHeaderColor() {
    document.querySelector('header')?.setAttribute('style', `background-color: ${this.colorComun}`);
  }

  resetFooterColor() {
    document.querySelector('footer')?.setAttribute('style', `background-color: ${this.colorComun}`);
  }


  //footer portrait hide and show


  showPortraitElement() {
    const portraitElement = document.querySelector('.selector-portrait');
    console.log("portrait should reappear");
    if (portraitElement) {
      portraitElement.setAttribute('style', `display: block`);
    }
  }


}
