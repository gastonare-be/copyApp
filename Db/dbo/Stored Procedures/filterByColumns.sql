CREATE PROCEDURE [dbo].[filterByColumns](@search nvarchar(50),@total int output)
as

select Nombre from Clientes 
where Nombre like CONCAT('%',@search,'%') 
group by Nombre
select @total=count(*) from Clientes
where Nombre like CONCAT('%',@search,'%') 
group by Nombre