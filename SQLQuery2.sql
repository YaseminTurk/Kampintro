--Select
Select ContactName As Adi,CompanyName SirketAdi,City Sehir from Customers

Select * From Customers where City='Berlin'

--case insensitive
select * From Products where CategoryID=1 or CategoryID=3

select * From Products where CategoryID=1 and UnitPrice>=10

select * From Products order by UnitPrice asc  --ascending

select * From Products order by UnitPrice desc  --descending

select * From Products where CategoryID=1 order by UnitPrice desc

select Count(*) From Products where CategoryID=2

select CategoryID,Count(*) Toplam From Products where UnitPrice>20 group by CategoryID having count(*)<10 order by CategoryID 


--DTO Data Transformation Object
select Products.ProductID,Products.ProductName,Products.UnitPrice,Categories.CategoryName
From Products inner join Categories 
on Products.CategoryID=Categories.CategoryID

select * 
From Products p inner join [Order Details] od
on p.ProductID=od.ProductID

select * 
From Products p left join [Order Details] od
on p.ProductID=od.ProductID 

Select*
From Customers c left join Orders o
on c.CustomerID=o.CustomerID where o.CustomerID is null

Select*
From Orders o right join Customers c
on c.CustomerID=o.CustomerID where o.CustomerID is null


select * 
From Products p inner join [Order Details] od
on p.ProductID=od.ProductID
inner join Orders o
on o.OrderID=od.OrderID

