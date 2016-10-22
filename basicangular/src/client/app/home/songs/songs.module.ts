import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { SongsComponent } from './songs.component';

@NgModule({
    imports: [CommonModule, RouterModule],
    declarations: [SongsComponent],
    exports: [SongsComponent]
})

export class SongsModule { }