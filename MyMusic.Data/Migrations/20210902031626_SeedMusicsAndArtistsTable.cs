using Microsoft.EntityFrameworkCore.Migrations;

namespace MyMusic.Data.Migrations
{
    public partial class SeedMusicsAndArtistsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder
                .Sql("INSERT INTO artists (name) Values ('Linkin Park')");
            migrationBuilder
                .Sql("INSERT INTO artists (name) Values ('Iron Maiden')");
            migrationBuilder
                .Sql("INSERT INTO artists (name) Values ('Flogging Molly')");
            migrationBuilder
                .Sql("INSERT INTO artists (name) Values ('Red Hot Chilli Peppers')");
                
            migrationBuilder
                .Sql("INSERT INTO musics (name, artist_id) Values ('In The End', (SELECT id FROM artists WHERE name = 'Linkin Park'))");
            migrationBuilder
                .Sql("INSERT INTO musics (name, artist_id) Values ('Numb', (SELECT id FROM artists WHERE name = 'Linkin Park'))");
            migrationBuilder
                .Sql("INSERT INTO musics (name, artist_id) Values ('Breaking The Habit', (SELECT id FROM artists WHERE name = 'Linkin Park'))");
            migrationBuilder
                .Sql("INSERT INTO musics (name, artist_id) Values ('Fear of the dark', (SELECT id FROM artists WHERE name = 'Iron Maiden'))");
            migrationBuilder
                .Sql("INSERT INTO musics (name, artist_id) Values ('Number of the beast', (SELECT id FROM artists WHERE name = 'Iron Maiden'))");
            migrationBuilder
                .Sql("INSERT INTO musics (name, artist_id) Values ('The Trooper', (SELECT id FROM artists WHERE name = 'Iron Maiden'))");
            migrationBuilder
                .Sql("INSERT INTO musics (name, artist_id) Values ('What''s left of the flag', (SELECT id FROM artists WHERE name = 'Flogging Molly'))");
            migrationBuilder
                .Sql("INSERT INTO musics (name, artist_id) Values ('Drunken Lullabies', (SELECT id FROM artists WHERE name = 'Flogging Molly'))");
            migrationBuilder
                .Sql("INSERT INTO musics (name, artist_id) Values ('If I Ever Leave this World Alive', (SELECT id FROM artists WHERE name = 'Flogging Molly'))");
            migrationBuilder
                .Sql("INSERT INTO musics (name, artist_id) Values ('Californication', (SELECT id FROM artists WHERE name = 'Red Hot Chilli Peppers'))");
            migrationBuilder
                .Sql("INSERT INTO musics (name, artist_id) Values ('Tell Me Baby', (SELECT id FROM artists WHERE name = 'Red Hot Chilli Peppers'))");
            migrationBuilder
                .Sql("INSERT INTO musics (name, artist_id) Values ('Parallel Universe', (SELECT id FROM artists WHERE name = 'Red Hot Chilli Peppers'))");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder
                .Sql("DELETE FROM musics");

            migrationBuilder
                .Sql("DELETE FROM artists");
        }
    }
}
