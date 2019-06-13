export interface Book {
    id: number;
    title: string;
    price: number;
    yearReleased: number;
    authorName: string;
    genreNames: string[];
}

export interface BookResult {
    books: Book[];
    totalCount: number;
}

export interface Author {
    id: number;
    name: string;
}

export interface Genre {
    id: number;
    name: string;
}

export interface ObjectQuery {
    sortBy?: string;
    isSortDescending?: boolean;
    page?: number;
    pageSize?: number;
}

export interface BookQuery extends ObjectQuery {
    searchKey?: any;
    authorId?: number;
    genreId?: number;
}

export interface ColumnMap {
    key: string;
    name: string;
    sortable: boolean;
}
