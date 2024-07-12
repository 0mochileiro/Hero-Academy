import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';

import { ResponseGetRandomQuestion } from '../Models/QuestionManagerServiceModel';

@Injectable({
  providedIn: 'root'
})

export class QuestionManagerService {

  private readonly uri = 'http://localhost:5020/api/'

  constructor(private httpClient: HttpClient) {
  }

  public getRandomQuestion(): Observable<ResponseGetRandomQuestion> {
    return this.httpClient.get<ResponseGetRandomQuestion>(`${this.uri}QuestionManager/GetRandomQuestion`); // http://localhost:5020/api/QuestionManager/GetRandomQuestion
  }

}
