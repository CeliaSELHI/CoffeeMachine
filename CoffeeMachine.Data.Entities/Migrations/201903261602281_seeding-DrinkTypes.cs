namespace CoffeeMachine.Data.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedingDrinkTypes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Badges", "IsOwerMug", c => c.Boolean(nullable: false));
            DropColumn("dbo.Badges", "OwerMug");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Badges", "OwerMug", c => c.Boolean(nullable: false));
            DropColumn("dbo.Badges", "IsOwerMug");
        }
    }
}
