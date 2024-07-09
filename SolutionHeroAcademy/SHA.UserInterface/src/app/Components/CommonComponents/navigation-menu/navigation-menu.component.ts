import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';

import { NavigationMenuModel } from '../../../Models/NavigationMenuModel';

@Component({
  selector: 'app-navigation-menu',
  standalone: true,
  imports: [CommonModule, RouterModule],
  templateUrl: './navigation-menu.component.html',
  styleUrl: './navigation-menu.component.css'
})

export class NavigationMenuComponent implements OnInit {

  navigationSettings: NavigationMenuModel = new NavigationMenuModel();
  groupedSettings = this.navigationSettings.getGroupedSettings();

  navigationPhrases = [
    "We all make choices in life, but in the end our choices make us",
    "If you accept defeat, that's all you'll get"
  ];

  titleAnimated = false;
  titleNavigationAnimated = false;

  ngOnInit(): void {
    this.animateTitle();
  }

  animateTitle(): void {
    if (this.titleAnimated) {
      return;
    }

    this.titleAnimated = true;

    setTimeout(() => {
      this.titleAnimated = false;
    }, 1000);
  }

  animateNavigationTitle(): void {
    if (this.titleNavigationAnimated) {
      return;
    }

    this.titleNavigationAnimated = true;

    setTimeout(() => {
      this.titleNavigationAnimated = false;
    }, 1000);
  }
}
