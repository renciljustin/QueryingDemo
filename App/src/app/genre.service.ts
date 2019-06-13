import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/operators';
import { Genre } from './models/models';

@Injectable({
  providedIn: 'root'
})
export class GenreService {

  constructor(private http: HttpClient) { }

  getGenres() {
    return this.http.get('http://localhost:5000/api/genres/')
      .pipe(
        map(res => res as Genre[])
      );
  }
}
