import { GenreService } from './genre.service';
import { AuthorService } from './author.service';
import { BookService } from './book.service';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';

import { AppComponent } from './app.component';
import { PaginationComponent } from './pagination/pagination.component';

@NgModule({
  declarations: [
    AppComponent,
    PaginationComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [
    AuthorService,
    BookService,
    GenreService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
