Create proc Corler
	@id int
as
Select Id, Nome from Cor where Id = @id