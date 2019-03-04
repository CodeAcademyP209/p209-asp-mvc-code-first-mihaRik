namespace RentACar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Year = c.DateTime(nullable: false),
                        EnginePower = c.Single(nullable: false),
                        HorsePower = c.Int(nullable: false),
                        EngineType = c.String(nullable: false, maxLength: 100),
                        Mileage = c.Int(),
                        Brand = c.String(nullable: false, maxLength: 100),
                        Model = c.String(nullable: false, maxLength: 100),
                        Image = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cars");
        }
    }
}
