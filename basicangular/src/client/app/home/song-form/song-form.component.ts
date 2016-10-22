import {Component} from '@angular/core';
import {Song} from '../songs/song';
import {SongsService} from '../songs/servico/songservice';

@Component({
	moduleId: module.id,
	selector: 'songform',
	templateUrl: 'song-form.component.html',
  	providers: [SongsService]
})
export class SongFormComponent {


  constructor(private songService: SongsService) {
   }
	
}