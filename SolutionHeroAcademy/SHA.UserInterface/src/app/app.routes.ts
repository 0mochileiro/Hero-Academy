import { Routes } from '@angular/router';

import { HomeComponent } from '@Components/CommonComponents/home/home.component';
import { GameComponent} from '@Components/GameComponents/game/game.component';

export const routes: Routes = [
    { path: '', redirectTo: 'home', pathMatch: 'full' }, // Note: Handle empty urls.
    { path: 'home', component: HomeComponent, title: 'Hero Academy - Home' }, // Note: Default route.
    { path: 'game', component: GameComponent, title: 'Hero Academy - Play' }, // Note: Game
]
