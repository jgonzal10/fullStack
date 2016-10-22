import { Injectable } from '@angular/core';
import { Http, Response, Headers, RequestOptions  } from '@angular/http';
import { Observable } from 'rxjs/Rx';
import 'rxjs/add/operator/map';

import { Song } from '../song';

@Injectable()
export class SongsService {
    url = 'http://201.24.26.23/musicrestful/api/music/musicList';
    song: any = null;


    constructor(public http: Http) { }

    load(): Observable<Song[]> {
    return this.http.get(this.url)
      .map(res => <Song[]>res.json());
  }

    save (): Observable<Song[]> {
    	console.log('save service');
        let headers  = new Headers({ 'Content-Type': 'application/json' });
        let options = new RequestOptions({ headers: headers });
        return this.http.post('localhost:53344/api/music/songMaintenance?acao=I&songId=&songName=Song2&songAutor=Je&songYear=2014', '', options).map((res:Response) => res.json()).catch((error:any) => Observable.throw(error.json().error || 'Server error')); 
    } 

   
}