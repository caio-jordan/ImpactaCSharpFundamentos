Create proc CorAtualizar
	@id int,
	@nome nvarchar (200)
as
Update Cor
set Nome = @nome
where Id = @id