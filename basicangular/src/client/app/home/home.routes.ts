import { Route } from '@angular/router';

import { SongsRoutes } from './songs/index';
import { SongFormRoutes } from './song-form/index';


import { HomeComponent } from './index';

export const HomeRoutes: Route[] = [
  	{
    	path: 'home',
    	component: HomeComponent,
    	children: [
        ...SongFormRoutes,
        ...SongsRoutes
    	]
  	}
];
