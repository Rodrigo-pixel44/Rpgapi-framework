BEGIN TRANSACTION;
ALTER TABLE [TB_PERSONAGENS] ADD [FotoPersonagem] varbinary(max) NULL;

ALTER TABLE [TB_PERSONAGENS] ADD [UsuarioId] int NULL;

CREATE TABLE [TB_USUARIOS] (
    [Id] int NOT NULL IDENTITY,
    [Username] varchar(200) NOT NULL,
    [Passwordhash] varbinary(max) NULL,
    [PasswordSalt] varbinary(max) NULL,
    [Foto] varbinary(max) NULL,
    [Latitue] float NULL,
    [Longitude] float NULL,
    [DataAcesso] datetime2 NULL,
    [Perfil] varchar(200) NULL DEFAULT 'Jogador',
    [Email] varchar(200) NULL,
    CONSTRAINT [PK_TB_USUARIOS] PRIMARY KEY ([Id])
);

UPDATE [TB_PERSONAGENS] SET [FotoPersonagem] = NULL, [UsuarioId] = 1
WHERE [Id] = 1;
SELECT @@ROWCOUNT;


UPDATE [TB_PERSONAGENS] SET [FotoPersonagem] = NULL, [UsuarioId] = 1
WHERE [Id] = 2;
SELECT @@ROWCOUNT;


UPDATE [TB_PERSONAGENS] SET [FotoPersonagem] = NULL, [UsuarioId] = 1
WHERE [Id] = 3;
SELECT @@ROWCOUNT;


UPDATE [TB_PERSONAGENS] SET [FotoPersonagem] = NULL, [UsuarioId] = 1
WHERE [Id] = 4;
SELECT @@ROWCOUNT;


UPDATE [TB_PERSONAGENS] SET [FotoPersonagem] = NULL, [UsuarioId] = 1
WHERE [Id] = 5;
SELECT @@ROWCOUNT;


UPDATE [TB_PERSONAGENS] SET [FotoPersonagem] = NULL, [UsuarioId] = 1
WHERE [Id] = 6;
SELECT @@ROWCOUNT;


UPDATE [TB_PERSONAGENS] SET [FotoPersonagem] = NULL, [UsuarioId] = 1
WHERE [Id] = 7;
SELECT @@ROWCOUNT;


IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'DataAcesso', N'Email', N'Foto', N'Latitue', N'Longitude', N'PasswordSalt', N'Passwordhash', N'Perfil', N'Username') AND [object_id] = OBJECT_ID(N'[TB_USUARIOS]'))
    SET IDENTITY_INSERT [TB_USUARIOS] ON;
INSERT INTO [TB_USUARIOS] ([Id], [DataAcesso], [Email], [Foto], [Latitue], [Longitude], [PasswordSalt], [Passwordhash], [Perfil], [Username])
VALUES (1, NULL, 'seuEmail@gmail.com', NULL, -23.520024100000001E0, -46.586497999999999E0, 0xEE4B450752DAB8DD06144A4604429618B8BE99E8172666D9F3F1BC4C941CF427F19B9070F323D6D6958FCBA40799226F14BC4DDA7EA6B14BEA8F7E59E7F153F065C74311D77C9A21E56B0B070F2BA58E1C750D5B0D69801BF6509CF7379D001EE57E026CFD9E70B5FB295F2ADBD7ED1BB88F48752F807799BC2313DADCE09C87, 0xA33D4BE2166B124F5AF697590D98CFD0090E8808AA3123A4B362465CA7FECBC5277401B47FE36354BDEE1384A2A5AA18189170534D495A7792E7ECDE7041AE33, 'Admin', 'usuarioAdmin');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'DataAcesso', N'Email', N'Foto', N'Latitue', N'Longitude', N'PasswordSalt', N'Passwordhash', N'Perfil', N'Username') AND [object_id] = OBJECT_ID(N'[TB_USUARIOS]'))
    SET IDENTITY_INSERT [TB_USUARIOS] OFF;

CREATE INDEX [IX_TB_PERSONAGENS_UsuarioId] ON [TB_PERSONAGENS] ([UsuarioId]);

ALTER TABLE [TB_PERSONAGENS] ADD CONSTRAINT [FK_TB_PERSONAGENS_TB_USUARIOS_UsuarioId] FOREIGN KEY ([UsuarioId]) REFERENCES [TB_USUARIOS] ([Id]);

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20260506000918_MigracaoUsuario', N'10.0.5');

COMMIT;
GO

