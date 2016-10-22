import {Component} from '@angular/core';
import {Song} from './song';
import {SongsService} from './servico/songservice';


@Component({
	moduleId: module.id,
	selector: 'songs',
	templateUrl: 'songs.component.html',
  	providers: [SongsService]
})	
export class SongsComponent {
	 songs: Song[];
	 selectedUsuario: Song;

  constructor(private songService: SongsService) {

  songService.load().subscribe(songs => this.songs = songs )


  }
   novo(): void {
    console.log('new song');
  }
}
