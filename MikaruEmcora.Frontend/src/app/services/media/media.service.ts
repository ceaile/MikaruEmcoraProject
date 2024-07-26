import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root' //usable en toda la app
})
export class MediaService {

  constructor(private http: HttpClient) {
  }

  getMedia() { //simulacion de acceso a bbdd
    return this.http.get('/assets/media.json');

  }
}
