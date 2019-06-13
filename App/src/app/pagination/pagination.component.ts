import { Component, OnInit, Input, Output, EventEmitter, AfterContentInit, OnChanges } from '@angular/core';

@Component({
  selector: 'app-pagination',
  templateUrl: './pagination.component.html',
  styleUrls: ['./pagination.component.scss']
})
export class PaginationComponent implements OnChanges {
  // tslint:disable-next-line:no-input-rename
  @Input('totalItems') totalItems: number;
  // tslint:disable-next-line:no-input-rename
  @Input('pageSize') pageSize: number;
  // tslint:disable-next-line:no-output-rename
  @Output('pageChange') pageChange = new EventEmitter();

  currentPage = 1;
  pages: any[] = [];

  ngOnChanges() {
    this.renderPages();
  }

  public renderPages() {
    this.pages = [];

    if (this.maxPage < 5) {
      this.iteratePages(1, this.maxPage);
    } else if (this.currentPage <= 3) {
      this.iteratePages(1, 5);
    } else if (this.currentPage + 4 >= this.maxPage) {
      this.iteratePages(this.maxPage - 4, this.maxPage);
    } else {
      this.iteratePages(this.currentPage - 2, this.currentPage + 2);
    }
  }

  private iteratePages(page: number, limit: number) {
    for (page; page <= limit; page++) {
      this.pages.push(page);
    }
  }

  get maxPage(): number {
    return Math.ceil(this.totalItems / this.pageSize);
  }

  onPageChange(page: number) {
    this.currentPage = page;
    this.emitPageChange();
  }

  goToFirst() {
    this.currentPage = 1;
    this.emitPageChange();
  }

  goToPrev() {
    if (this.currentPage > 1) {
      this.currentPage--;
      this.emitPageChange();
    }
  }

  goToNext() {
    if (this.currentPage < this.maxPage) {
      this.currentPage++;
      this.emitPageChange();
    }
  }

  goToLast() {
    this.currentPage = this.maxPage;
    this.renderPages();
    this.emitPageChange();
  }

  incrementDisabled(): boolean {
    return this.currentPage >= this.maxPage;
  }

  decrementDisabled(): boolean {
    return this.currentPage <= 1;
  }

  emitPageChange() {
    this.pageChange.emit({
      currentPage: this.currentPage,
      pageSize: this.pageSize
    });
  }
}
