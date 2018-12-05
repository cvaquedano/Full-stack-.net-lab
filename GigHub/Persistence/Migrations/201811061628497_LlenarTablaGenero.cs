namespace GigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LlenarTablaGenero : DbMigration
    {
        public override void Up()
        {
            Sql("Insert INTO genres(id, Name) Values (1,'Jazz')");
            Sql("Insert INTO genres(id, Name) Values (2,'Blues')");
            Sql("Insert INTO genres(id, Name) Values (3,'Rock')");
            Sql("Insert INTO genres(id, Name) Values (4,'Country')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Genres where Id in (,2,3,4)");
        }
    }
}
