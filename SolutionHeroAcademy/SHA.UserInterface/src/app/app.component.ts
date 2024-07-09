import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { CommonModule } from '@angular/common';

import { HeaderLinesDecorationComponent } from './Components/CommonComponents/header-lines-decoration/header-lines-decoration.component';
import { NavigationMenuComponent } from './Components/CommonComponents/navigation-menu/navigation-menu.component';
import { FooterComponent } from './Components/CommonComponents/footer/footer.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [
    CommonModule, RouterOutlet,
    NavigationMenuComponent, FooterComponent, HeaderLinesDecorationComponent
  ],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})

export class AppComponent {
  title = 'Hero Academy';
}