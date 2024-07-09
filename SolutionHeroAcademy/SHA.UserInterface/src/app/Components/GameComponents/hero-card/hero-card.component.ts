import { Component, OnInit } from '@angular/core';
import { CommonModule, NgOptimizedImage } from '@angular/common'

@Component({
  selector: 'app-hero-card',
  standalone: true,
  imports: [NgOptimizedImage, CommonModule],
  templateUrl: './hero-card.component.html',
  styleUrl: './hero-card.component.css'
})

export class HeroCardComponent {
  name = 'Shoei D\' GreenWood';
  health = 43;
  currentHealth = 1;
  power = 12;
  skill = 'Whenever Shoei attacks, he can choose to deal 12 points of damage to one enemy, or deal 6 points of damage to up to two different enemies.'
  history = 'Shoei was born in the mountains, where he learned the art of earthbending from ancient masters. Always smiling, her red hair shone in the sunlight. He traveled the world, helping villages and defeating tyrants. With the strength of the land and the wisdom of the monks, Arak became a legend, defending justice and peace in every corner he visited. Shoei was born in the mountains, where he learned the art of earthbending from ancient masters. Always smiling, her red hair shone in the sunlight. He traveled the world, helping villages and defeating tyrants. With the strength of the land and the wisdom of the monks, Arak became a legend, defending justice and peace in every corner he visited. Shoei was born in the mountains, where he learned the art of earthbending from ancient masters. Always smiling, her red hair shone in the sunlight. He traveled the world, helping villages and defeating tyrants. With the strength of the land and the wisdom of the monks, Arak became a legend, defending justice and peace in every corner he visited.';

  healthAnimeted = false;

  AnimiteHealth(): void {
    if (this.healthAnimeted) {
      return;
    }

    this.healthAnimeted = true;

    setTimeout(() => {
      this.healthAnimeted = false;
    }, 1000);
  }

  AddHealth(): void {
    if (this.currentHealth < this.health) {
      ++this.currentHealth;

      this.AnimiteHealth();
    }
  }

  DecreaseHealth(): void {
    if (this.currentHealth > 0) {
      --this.currentHealth;

      this.AnimiteHealth();
    }
  }
}
