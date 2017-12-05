namespace TPC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CardTransferPayment",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        CustomerName = c.String(),
                        Amount = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        LastDigits = c.String(),
                        RefernceNumber = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OnlinePayment",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        CustomerName = c.String(),
                        Amount = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        GatewayName = c.String(),
                        DigitalReciept = c.String(),
                        TransactionNumber = c.String(),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.POSPayment",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        CustomerName = c.String(),
                        Amount = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        POSBankName = c.String(),
                        TrackingNumber = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.POSPayment");
            DropTable("dbo.OnlinePayment");
            DropTable("dbo.CardTransferPayment");
        }
    }
}
