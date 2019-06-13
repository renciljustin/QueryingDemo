import { PaginationComponent } from './pagination/pagination.component';
import { GenreService } from './genre.service';
import { AuthorService } from './author.service';
import { BookResult, Author, BookQuery, Genre, ColumnMap } from './models/models';
import { BookService } from './book.service';
import { Component, OnInit, ViewChild } from '@angular/core';
import {  forkJoin } from 'rxjs';

export const PAGE_SIZE = 5;

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {

  @ViewChild(PaginationComponent) pagination;

  authors: Author[] = [];
  selectedAuthor = 0;

  genres: Genre[] = [];
  selectedGenre = 0;

  bookResult: BookResult = {
    books: [],
    totalCount: 0
  };

  columnsMap: ColumnMap[] = [
    { key: 'Title', name: 'Title', sortable: true },
    { key: 'Price', name: 'Price', sortable: true },
    { key: 'YearReleased', name: 'Year Released', sortable: true },
    { key: 'Author', name: 'Author', sortable: true },
    { key: 'Genres', name: 'Genres', sortable: false }
  ];

  selectedColumn: ColumnMap = {
    key: null,
    name: null,
    sortable: false
  };

  bookQuery: BookQuery = {
    page: 1,
    pageSize: PAGE_SIZE
  };

  constructor(private authorService: AuthorService, private genreService: GenreService, private bookService: BookService) {

  }

  ngOnInit() {
    forkJoin(
      this.authorService.getAuthors(),
      this.genreService.getGenres(),
      this.bookService.getBooks(this.bookQuery),
      (authors, genres, bookResult) => ({authors, genres, bookResult})
    ).subscribe(result => {
      this.authors = result.authors;
      this.genres = result.genres;
      this.bookResult = result.bookResult;
    });
  }

  getBooks(resetPage?: boolean): void {
    this.bookService.getBooks(this.bookQuery)
      .subscribe(bookResult => {
        this.bookResult = bookResult;

        if (resetPage) {
          this.bookQuery.page = 1;
        }
    });
  }

  onQuery() {
    this.bookQuery.page = 1;
    this.bookQuery.authorId = +this.selectedAuthor;
    this.bookQuery.genreId = +this.selectedGenre;
    this.getBooks(true);
  }

  onResetQuery() {
    this.selectedAuthor = 0;
    this.selectedGenre = 0;
    this.bookQuery = {
      page: 1,
      pageSize: PAGE_SIZE
    };
    this.getBooks(true);
  }

  onSort(column: ColumnMap) {
    if (column.sortable) {
      if (column.key === this.selectedColumn.key) {
        this.bookQuery.isSortDescending = !this.bookQuery.isSortDescending;
      } else {
        this.selectedColumn = column;
        this.bookQuery.sortBy = column.key;
        this.bookQuery.isSortDescending = false;
      }
      this.getBooks();
    }
  }

  onPageChange(page: any) {
    this.bookQuery.page = page.currentPage;
    this.bookQuery.pageSize = page.pageSize;
    this.getBooks();
  }
}
