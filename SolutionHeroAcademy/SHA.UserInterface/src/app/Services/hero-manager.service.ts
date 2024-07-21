import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

import { environment } from '../../environments/environment';
import { ResponseGetRandomHero } from '../Models/Responses/HeroManagerServiceResponse';

@Injectable({
  providedIn: 'root'
})


export class HeroManagerService {
  private readonly uri = environment.SERVICE_URI;

  constructor(private httpClient: HttpClient) {
  }

  public getRandomHero(): Observable<ResponseGetRandomHero> {
    let headers = new HttpHeaders({
      'Content-Type': 'application/json',
      'ngrok-skip-browser-warning': 'true'
    });

    return this.httpClient.get<ResponseGetRandomHero>(`${this.uri}HeroManager/GetRandomHero`, { headers });
  }
}
