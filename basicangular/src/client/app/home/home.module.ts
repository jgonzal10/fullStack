import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { DropdownModule } from 'ng2-bootstrap/ng2-bootstrap';
import { ModalModule } from 'ng2-bootstrap/ng2-bootstrap';

import { SongsModule } from './songs/songs.module';
import { SongFormModule } from './song-form/song-form.module';

import { HomeComponent } from './home.component';

import {TopNavComponent} from '../shared/index';
import {SidebarComponent} from '../shared/index';


@NgModule({
    imports: [
        CommonModule,
    	RouterModule,
    	DropdownModule,
        ModalModule,
        SongsModule,
        SongFormModule,


    ],
    declarations: [HomeComponent, TopNavComponent, SidebarComponent],
    exports: [HomeComponent, TopNavComponent, SidebarComponent]
})

export class HomeModule { }
