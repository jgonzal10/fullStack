CREATE TABLE [dbo].[song](
	[songId] [int] NULL,
	[songName] [varchar](50) NULL,
	[songAutor] [varchar](50) NULL,
	[songYear] [varchar](50) NULL
) ON [PRIMARY]

GO

---lIST SONGS
ALTER PROCEDURE [dbo].[spListMusic]
AS
BEGIN
	SELECT * FROM song
END


----INSERT/ UPDATE/ DELETE

ALTER PROCEDURE [dbo].[spSongMaintenance]
@acao as char(1),
@songId int = null,
@songName as varchar(50), 
@songAutor as varchar(50)=null,
@songYear as int=null
AS
BEGIN
if @acao = 'I'
    BEGIN
            INSERT INTO song (songId,songName, songAutor, songYear) VALUES (@songId,@songName, @songAutor,@songYear)
    END
if @acao = 'U'
	begin
		update song set songName=@songName, songAutor=@songAutor, songYear=@songYear
	where songId=@songId
	end
if @acao = 'D'
	begin
		delete from song where songId=@songId
	end

END