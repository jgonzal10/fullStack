import { Route } from '@angular/router';

import { SongFormComponent } from './index';

export const SongFormRoutes: Route[] = [
	{
		path: 'song/add',
		component: SongFormComponent
	}
];