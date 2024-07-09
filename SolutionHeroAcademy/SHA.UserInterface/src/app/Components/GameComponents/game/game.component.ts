import { Component } from '@angular/core';
import { HeroCardComponent } from '../hero-card/hero-card.component';
import { QuestionCardComponent } from '../question-card/question-card.component';

@Component({
  selector: 'app-game',
  standalone: true,
  imports: [HeroCardComponent, QuestionCardComponent],
  templateUrl: './game.component.html',
  styleUrl: './game.component.css'
})
export class GameComponent {

}
