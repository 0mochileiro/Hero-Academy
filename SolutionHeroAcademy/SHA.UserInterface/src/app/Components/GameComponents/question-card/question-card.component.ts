import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms'

import { QuestionModel } from '../../../Models/QuestionsModel';

@Component({
  selector: 'app-question-card',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './question-card.component.html',
  styleUrl: './question-card.component.css'
})

export class QuestionCardComponent implements OnInit {

  model: QuestionModel | undefined;
  selectedAnswerId: string = '';

  ngOnInit(): void {
    this.model = new QuestionModel();

    console.log(this.model);
  }

  sendAnswer(): void {
    this.verifyAnswer(this.selectedAnswerId);

    this.loadNextQuestion();

  }

  verifyAnswer(selectedAnswerId: string): void {
    let selectedAnswer = this.model?.answers.find(a => a.id === selectedAnswerId);

    console.log(selectedAnswer);
  }

  loadNextQuestion() {
    this.selectedAnswerId = '';
  }
}
