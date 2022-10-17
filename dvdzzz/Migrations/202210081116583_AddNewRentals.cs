namespace dvdzzz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewRentals : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NewRentals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(),
                        MovieName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NewRentals");
        }
    }
}
