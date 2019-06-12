USE PaginationApp
GO

SELECT B.Title, B.Price, B.YearReleased, A.Name as Author
FROM Books AS B
LEFT JOIN Authors AS A
ON A.Id = B.AuthorId
-- LEFT JOIN BookGenres AS BG
-- ON BG.BookId = B.Id
-- LEFT JOIN Genres AS G
-- ON G.Id = BG.GenreId
GO