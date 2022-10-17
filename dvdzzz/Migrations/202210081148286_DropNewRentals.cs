namespace dvdzzz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropNewRentals : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.NewRentals");
        }
        
        public override void Down()
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
    }
}
