namespace TPH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(),
                        Amount = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        LastDigits = c.String(),
                        RefernceNumber = c.String(),
                        GatewayName = c.String(),
                        DigitalReciept = c.String(),
                        TransactionNumber = c.String(),
                        Status = c.String(),
                        POSBankName = c.String(),
                        TrackingNumber = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Payments");
        }
    }
}
