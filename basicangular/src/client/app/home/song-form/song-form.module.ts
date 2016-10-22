import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';

import { SongFormComponent } from './song-form.component';

@NgModule({
    imports: [
        RouterModule
    ],
    declarations: [SongFormComponent],
    exports: [SongFormComponent]
})

export class SongFormModule { }