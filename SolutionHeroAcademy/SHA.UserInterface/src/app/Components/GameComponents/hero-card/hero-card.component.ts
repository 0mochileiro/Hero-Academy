import { Component, OnInit } from '@angular/core';
import { CommonModule, NgOptimizedImage } from '@angular/common'

import { HeroManagerService } from '../../../Services/hero-manager.service';
import { Hero, ResponseGetRandomHero } from '../../../Models/Responses/HeroManagerServiceResponse';
import { LoadComponent } from '../../CommonComponents/load/load.component';

@Component({
  selector: 'app-hero-card',
  standalone: true,
  imports: [NgOptimizedImage, CommonModule, LoadComponent],
  templateUrl: './hero-card.component.html',
  styleUrl: './hero-card.component.css'
})

export class HeroCardComponent implements OnInit {
  constructor(private service: HeroManagerService) {
  }
  
  model: Hero | undefined;

  ngOnInit(): void {
    this.getHero();
  }

  getHero(): void {
    this.service.getRandomHero().subscribe((response) =>
      (this.model = response.result)
    );
  }
}
