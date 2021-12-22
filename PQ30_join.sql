-- 請練習撰寫底下指令，使用 Northwind 資料庫


-- Step1 確定打開的是 Northwind 資料庫 

use Northwind;

-- Step2 列出 Products 產品資料表中欄位 ProductID, ProductName, SupplierID

select ProductID, ProductName, SupplierID from Products;



-- Step3 承上題
--     請帶出該產品的供應商名稱(CompanyName)、聯絡電話(Phone)、聯絡人(ContactName)
--     相同供應商的資料請列在一起

select ProductID, ProductName,CompanyName,Phone,ContactName 
     from Products 
	 left join Suppliers on Products.SupplierID = Suppliers.SupplierID;



-- Step4 承上題，請加入條件："庫存量低於再訂購量" 的產品資料

select distinct p.ProductID, ProductName,CompanyName,Phone,ContactName 
     from Products as p
	 left join [Order Details] as o on p.ProductID = o.ProductID
	 left join Suppliers on p.SupplierID = Suppliers.SupplierID
	 where p.UnitsInStock < o.Quantity
	 order by ProductID;



-- Step5 訂單的價格是否與產品的單價是否一致？

select distinct * from [Order Details]as o
   left join Products on (o.UnitPrice-(o.UnitPrice*o.Discount))=Products.UnitPrice
   order by o.ProductID;
   --有些訂單的價格與產品的單價不一致

-- Step6. 那張訂單賺最多錢(離product.UnitPrice 折扣最小的)？

select top 1 o.OrderID from Orders as o
    left join 
	(select OrderID,sum((od.UnitPrice*(1-Discount)-p.UnitPrice)*Quantity) as price from [Order Details] as od
	 left join Products as p on p.ProductID=od.ProductID
	 group by OrderID)
	 as od on o.OrderID=od.OrderID
	 order by od.price;



-- Step7. 找出訂單編號為10274所購買的產品清單，請找出產品名稱、產品價格

select od.OrderID,p.ProductName,p.UnitPrice from [Order Details] as od
left join Products as p on p.ProductID=od.ProductID
where od.OrderID = '10274';



