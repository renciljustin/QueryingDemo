import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Author } from './models/models';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class AuthorService {

  constructor(private http: HttpClient) { }

  getAuthors() {
    return this.http.get('http://localhost:5000/api/authors/')
      .pipe(
        map(res => res as Author[])
      );
  }
}
