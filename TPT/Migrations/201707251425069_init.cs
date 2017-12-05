namespace TPT.Migrations
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
                        Amount = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CustomerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Payments.CardTransferPayment",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        LastDigits = c.String(),
                        RefernceNumber = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Payments", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "Payments.OnlinePayment",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        GatewayName = c.String(),
                        DigitalReciept = c.String(),
                        TransactionNumber = c.String(),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Payments", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "Payments.POSPayment",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        POSBankName = c.String(),
                        TrackingNumber = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Payments", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("Payments.POSPayment", "Id", "dbo.Payments");
            DropForeignKey("Payments.OnlinePayment", "Id", "dbo.Payments");
            DropForeignKey("Payments.CardTransferPayment", "Id", "dbo.Payments");
            DropForeignKey("dbo.Payments", "CustomerId", "dbo.Customers");
            DropIndex("Payments.POSPayment", new[] { "Id" });
            DropIndex("Payments.OnlinePayment", new[] { "Id" });
            DropIndex("Payments.CardTransferPayment", new[] { "Id" });
            DropIndex("dbo.Payments", new[] { "CustomerId" });
            DropTable("Payments.POSPayment");
            DropTable("Payments.OnlinePayment");
            DropTable("Payments.CardTransferPayment");
            DropTable("dbo.Customers");
            DropTable("dbo.Payments");
        }
    }
}
