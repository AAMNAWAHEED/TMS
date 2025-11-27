IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'dbo.Users') AND type in (N'U'))
BEGIN
	create table dbo.[Users]
	(
		Id int primary key identity(1,1),
		Username nvarchar(50) unique not null,
		--PasswordHash nvarchar(max) unique not null, 
		--sql creates index for unique columns, and index cant create on nvarchar(max)
		PasswordHash nvarchar(450) unique not null, 
		CreatedAt datetime not null default getdate(),
		UpdatedAt datetime null
	)
END