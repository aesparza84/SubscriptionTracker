namespace SubscriptionTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Subscriptions",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Price = c.Double(nullable: false),
                        Category = c.Int(nullable: false),
                        RenewalType = c.Int(nullable: false),
                        RenewalDate = c.DateTime(nullable: false),
                        NextRenewalDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Subscriptions");
        }
    }
}
