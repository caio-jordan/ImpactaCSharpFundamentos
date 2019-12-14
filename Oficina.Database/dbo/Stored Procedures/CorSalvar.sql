Create proc CorSalvar
	@nome nvarchar (200)
as
Insert Cor
(Nome)
output inserted.Id
values
(@nome)