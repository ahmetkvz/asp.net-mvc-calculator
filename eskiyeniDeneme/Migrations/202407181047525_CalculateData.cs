namespace eskiyeniDeneme.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CalculateData : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.calcs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Sayi1 = c.Double(nullable: false),
                        Sayi2 = c.Double(nullable: false),
                        Islem = c.String(),
                        Sonuc = c.Double(nullable: false),
                        Timestamp = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.calcs");
        }
    }
}
