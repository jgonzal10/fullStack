import { Routes } from '@angular/router';

import { LoginRoutes } from './login/index';
import { HomeRoutes } from './home/index';

import { LoginComponent } from './login/index';

export const routes: Routes = [
	...LoginRoutes,
	...HomeRoutes,
	{ path: '**', component: LoginComponent }
];
