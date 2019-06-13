import { BookResult, BookQuery } from './models/models';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class BookService {

  constructor(private http: HttpClient) { }

  getBooks(bookQuery: BookQuery) {
    console.log(this.setQueryParams(bookQuery));
    return this.http.get('http://localhost:5000/api/books?' + this.setQueryParams(bookQuery))
      .pipe(
        map(res => res as BookResult)
      );
  }

  private setQueryParams(bookQuery: BookQuery): string {
    const queryParams: string[] = [];

    for (const key in bookQuery) {
      if (bookQuery[key] !== null && bookQuery[key] !== undefined && bookQuery[key] !== '' && bookQuery[key] !== 0) {
        queryParams.push(`${key}=${bookQuery[key]}`);
      }
    }

    return queryParams.join('&');
  }
}
