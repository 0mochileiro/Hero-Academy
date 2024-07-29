import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms'

import { QuestionManagerService } from '@Services/question-manager-service';
import { Question } from '@Models/Responses/QuestionManagerServiceResponse';
import { LoadComponent } from "@Components/CommonComponents/load/load.component";

@Component({
  selector: 'app-question-card',
  standalone: true,
  imports: [CommonModule, FormsModule, LoadComponent],
  templateUrl: './question-card.component.html',
  styleUrl: './question-card.component.css'
})

export class QuestionCardComponent implements OnInit {
  constructor(private service: QuestionManagerService) {
  }

  model: Question | undefined;
  selectedAnswerId: string = '';

  ngOnInit(): void {
    this.getQuestion();
  }

  getQuestion(): void {
    this.service.getRandomQuestion().subscribe((response) => 
      (this.model = response.result)
    );
  }

  checkAnswer(): void {
    let selectedAnswer = this.model?.answers?.find(a => a.id === this.selectedAnswerId);

    this.displayAlert(selectedAnswer?.correct);

    this.resetComponentState();
    
    this.getQuestion();
  }

  displayAlert(rightAnswer: boolean | undefined): void {
    if (rightAnswer) {
      alert("Correct - Generating new question");
    }
    else {
      alert("Wrong - Generating new question");
    }
  }

  resetComponentState(): void {
    this.model = undefined;
    this.selectedAnswerId = '';
  }
}
