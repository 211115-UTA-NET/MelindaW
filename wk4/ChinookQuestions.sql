--For each of the following exercises, provide the appropriate query.
--Keep your successful queries in a chinook-queries.sql file.

--Provide a query showing Customers (just their full names, customer ID and country)
--  who are not in the US.

SELECT FirstName + LastName AS CustomerName, CustomerId, Country
FROM Customer
WHERE NOT Country='USA';

--Provide a query only showing the Customers from Brazil.

SELECT FirstName, LastName, Country FROM Customer
WHERE Country='Brazil';

--Provide a query showing the Invoices of customers who are from Brazil.
--  The resultant table should show the customer's full name, Invoice ID,
--  Date of the invoice and billing country.

SELECT FirstName, LastName, InvoiceId, InvoiceDate, BillingCountry
FROM Customer
INNER JOIN Invoice ON Customer.CustomerId=Invoice.CustomerId
WHERE Country='Brazil';

--Provide a query showing only the Employees who are Sales Agents.

SELECT FirstName, LastName, Title
FROM Employee
WHERE Title='Sales Support Agent';

--Provide a query showing a unique list of billing countries from the Invoice table.

SELECT DISTINCT BillingCountry
FROM Invoice;

--Provide a query that shows the invoices associated with each sales agent.
--  The resultant table should include the Sales Agent's full name.

SELECT
    Employee.FirstName,
    Employee.LastName,
    InvoiceId
FROM Employee
INNER JOIN Customer ON Employee.EmployeeId=Customer.SupportRepId
INNER JOIN Invoice ON Customer.CustomerId=Invoice.CustomerId
WHERE Title='Sales Support Agent';

--Provide a query that shows the Invoice Total, Customer name,
--  Country and Sale Agent name for all invoices and customers.

SELECT
    Total,
    Customer.FirstName,
    Customer.LastName,
    Customer.Country,
    Employee.FirstName,
    Employee.LastName
FROM Employee
INNER JOIN Customer ON Employee.EmployeeId=Customer.SupportRepId
INNER JOIN Invoice ON Customer.CustomerId=Invoice.CustomerId
WHERE Title='Sales Support Agent';

--How many Invoices were there in 2009 and 2011? What are the respective total
--  sales for each of those years?

SELECT COUNT(InvoiceDate) AS TotalInvoices, SUM(total) AS TotalSales
FROM Invoice
WHERE YEAR(InvoiceDate)=2009
OR YEAR(InvoiceDate)=2011
GROUP BY YEAR(InvoiceDate);

--Looking at the InvoiceLine table, provide a query that COUNTs the number of
--  line items for Invoice ID 37.

SELECT COUNT(InvoiceId) AS NumberOfInvoiceID37
FROM InvoiceLine
WHERE InvoiceId=37;

--Looking at the InvoiceLine table, provide a query that COUNTs the number of
--  line items for each Invoice. HINT: GROUP BY

SELECT InvoiceId, COUNT(InvoiceLineID) AS NumberOFLineItems
FROM InvoiceLine
GROUP BY InvoiceID;

--Provide a query that includes the track name with each invoice line item.

SELECT
    Track.Name,
    InvoiceLineId,
    InvoiceId,
    InvoiceLine.TrackId,
    InvoiceLine.UnitPrice,
    Quantity
FROM Track
INNER JOIN InvoiceLine ON Track.TrackId=InvoiceLine.TrackId;

--Provide a query that includes the purchased track name
--  AND artist name with each invoice line item.

SELECT Track.Name, Track.Composer, InvoiceLine.InvoiceLineID, InvoiceLine.Quantity
FROM Track
INNER JOIN Artist ON Track.Composer=Artist.NAME
INNER JOIN InvoiceLine ON Track.TrackId=InvoiceLine.TrackId;


--Provide a query that shows the # of invoices per country. HINT: GROUP BY

SELECT COUNT(InvoiceId) AS #OfInvoices, BillingCountry FROM Invoice
GROUP BY BillingCountry;

--Provide a query that shows the total number of tracks in each playlist.
--  The Playlist name should be included on the resultant table.

SELECT Playlist.Name, COUNT(PlaylistTrack.TrackId) AS TotalNumberOfTracks
FROM Playlist
INNER JOIN PlayListTrack ON Playlist.PlaylistId=PlayListTrack.PlaylistId
GROUP BY Playlist.Name;

--Provide a query that shows all the Tracks, but displays no IDs.
--  The resultant table should include the Album name, Media type and Genre.

SELECT TRack.Name AS Track, Album.Title AS AlbumName, MediaType.Name AS MediaType, Genre.Name AS Genre
FROM Album
INNER JOIN Track ON Album.AlbumId=Track.AlbumId
INNER JOIN MediaType ON MediaType.MediaTypeId=Track.MediaTypeId
INNER JOIN Genre ON Genre.GenreId=Track.GenreId;

--Provide a query that shows all Invoices but includes the # of invoice line items.

SELECT
    Invoice.InvoiceId,
    COUNT(Invoice.InvoiceId) AS NumberOfInvoiceLineItems
FROM Invoice
FULL OUTER JOIN InvoiceLine ON Invoice.InvoiceId=InvoiceLine.InvoiceId
GROUP BY Invoice.InvoiceId;

--Provide a query that shows total sales made by each sales agent.

SELECT
    Employee.FirstName + ' ' + Employee.LastName AS SalesAgent,
    SUM(Total) AS Sales
FROM Employee
INNER JOIN Customer ON Employee.EmployeeId=Customer.SupportRepId
INNER JOIN Invoice ON Customer.CustomerId=Invoice.CustomerId
WHERE Title='Sales Support Agent'
GROUP BY Employee.FirstName + ' ' + Employee.LastName;

--Which sales agent made the most in sales in 2009?

SELECT TOP 1
    Employee.FirstName + ' ' + Employee.LastName AS SalesAgent,
    SUM(Total) AS Sales
FROM Employee
INNER JOIN Customer ON Employee.EmployeeId=Customer.SupportRepId
INNER JOIN Invoice ON Customer.CustomerId=Invoice.CustomerId
WHERE Title='Sales Support Agent'
AND YEAR(InvoiceDate)=2009
GROUP BY Employee.FirstName + ' ' + Employee.LastName
ORDER BY SUM(Total) DESC;

--Which sales agent made the most in sales in 2010?

SELECT TOP 1
    Employee.FirstName + ' ' + Employee.LastName AS SalesAgent,
    SUM(Total) AS Sales
FROM Employee
INNER JOIN Customer ON Employee.EmployeeId=Customer.SupportRepId
INNER JOIN Invoice ON Customer.CustomerId=Invoice.CustomerId
WHERE Title='Sales Support Agent'
AND YEAR(InvoiceDate)=2010
GROUP BY Employee.FirstName + ' ' + Employee.LastName
ORDER BY SUM(Total) DESC;

--Which sales agent made the most in sales over all?

SELECT TOP 1
    Employee.FirstName + ' ' + Employee.LastName AS SalesAgent,
    SUM(Total) AS Sales
FROM Employee
INNER JOIN Customer ON Employee.EmployeeId=Customer.SupportRepId
INNER JOIN Invoice ON Customer.CustomerId=Invoice.CustomerId
WHERE Title='Sales Support Agent'
GROUP BY Employee.FirstName + ' ' + Employee.LastName
ORDER BY SUM(Total) DESC;

--Provide a query that shows the # of customers assigned to each sales agent.

SELECT
    Employee.FirstName + ' ' + Employee.LastName AS SalesAgent,
    COUNT(CustomerId) AS NumberOFCustomers
FROM Employee
INNER JOIN Customer ON Employee.EmployeeId=Customer.SupportRepId
WHERE Title='Sales Support Agent'
GROUP BY Employee.FirstName + ' ' + Employee.LastName;

--Provide a query that shows the total sales per country. Which country's customers spent the most?

SELECT
    BillingCountry,
    SUM(Total) AS Sales
FROM Invoice
GROUP BY BillingCountry
ORDER BY SUM(Total) DESC;

--Provide a query that shows the most purchased track of 2013.

SELECT 
    Count(Track.TrackId),
    Track.Name
FROM Invoice
JOIN InvoiceLine ON Invoice.InvoiceId=InvoiceLine.InvoiceId
JOIN Track ON InvoiceLine.TrackId=Track.TrackId
WHERE YEAR(InvoiceDate)=2013
GROUP BY Track.Name
ORDER BY Count(Track.TrackId) DESC;

--Provide a query that shows the top 5 most purchased tracks over all.

SELECT TOP 5
    Count(InvoiceLine.TrackId),
    Track.Name
FROM Invoice
JOIN InvoiceLine ON Invoice.InvoiceId=InvoiceLine.InvoiceId
JOIN Track ON InvoiceLine.TrackId=Track.TrackId
GROUP BY Track.Name
ORDER BY Count(Track.TrackId) DESC;

--Provide a query that shows the top 3 best selling artists.

SELECT TOP 3
    Artist.Name AS ArtistName,
    COUNT(Album.ArtistId)
FROM Artist
INNER JOIN Album ON Artist.ArtistId=Album.ArtistId
INNER JOIN Track ON Album.AlbumId=Track.AlbumId
INNER JOIN InvoiceLine ON Track.TrackId=InvoiceLine.TrackId
GROUP BY Artist.Name
ORDER BY COUNT(Album.ArtistId) DESC;

--Provide a query that shows the most purchased Media Type.

SELECT TOP 1
    MediaType.Name AS MediaType,
    COUNT(Track.MediaTypeId)
FROM MediaType
INNER JOIN Track ON Track.MediaTypeId=MediaType.MediaTypeId
INNER JOIn InvoiceLine ON InvoiceLine.TrackId=Track.TrackId
GROUP BY MediaType.Name
ORDER BY COUNT(Track.MediaTypeId) DESC;

--Provide a query that shows the number tracks purchased in all invoices that contain more than one genre.

SELECT
    COUNT(Track.TrackId)
FROM Track
INNER JOIN InvoiceLine ON InvoiceLine.TrackId=Track.TrackId
HAVING COUNT(GenreId) > 1;