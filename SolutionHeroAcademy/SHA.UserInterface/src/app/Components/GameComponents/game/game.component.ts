import { Component } from '@angular/core';

import { HeroCardComponent } from '@Components/GameComponents/hero-card/hero-card.component';
import { QuestionCardComponent } from '@Components/GameComponents/question-card/question-card.component';

@Component({
  selector: 'app-game',
  standalone: true,
  imports: [HeroCardComponent, QuestionCardComponent],
  templateUrl: './game.component.html',
  styleUrl: './game.component.css'
})

export class GameComponent {

}
