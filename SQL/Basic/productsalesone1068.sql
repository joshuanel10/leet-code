select product_name, year, price
from Sales
inner join product on Sales.product_id = product.product_id
