import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';

import { environment } from '@Environments/environment';
import { ResponseGetRandomQuestion } from '@Models/Responses/QuestionManagerServiceResponse';

@Injectable({
  providedIn: 'root'
})

export class QuestionManagerService {
  constructor(private httpClient: HttpClient) {
  }

  private readonly uri = environment.SERVICE_URI;

  public getRandomQuestion(): Observable<ResponseGetRandomQuestion> {
    let headers = new HttpHeaders({
      'Content-Type': 'application/json',
      'ngrok-skip-browser-warning': 'true'
    });

    return this.httpClient.get<ResponseGetRandomQuestion>(`${this.uri}QuestionManager/GetRandomQuestion`, {headers});
  }
}
