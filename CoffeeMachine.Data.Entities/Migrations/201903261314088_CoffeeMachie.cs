namespace CoffeeMachine.Data.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CoffeeMachie : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Drinks");
            AddColumn("dbo.Badges", "IdDrink", c => c.Int(nullable: false));
            AddColumn("dbo.Badges", "OwerMug", c => c.Boolean(nullable: false));
            AddColumn("dbo.Drinks", "IdSugar", c => c.Int(nullable: false));
            AlterColumn("dbo.Drinks", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Drinks", "IdType", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Drinks", "Id");
            CreateIndex("dbo.Badges", "IdDrink");
            CreateIndex("dbo.Drinks", "IdType");
            CreateIndex("dbo.Drinks", "IdSugar");
            AddForeignKey("dbo.Drinks", "IdSugar", "dbo.Sugars", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Drinks", "IdType", "dbo.DrinkTypes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Badges", "IdDrink", "dbo.Drinks", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Badges", "IdDrink", "dbo.Drinks");
            DropForeignKey("dbo.Drinks", "IdType", "dbo.DrinkTypes");
            DropForeignKey("dbo.Drinks", "IdSugar", "dbo.Sugars");
            DropIndex("dbo.Drinks", new[] { "IdSugar" });
            DropIndex("dbo.Drinks", new[] { "IdType" });
            DropIndex("dbo.Badges", new[] { "IdDrink" });
            DropPrimaryKey("dbo.Drinks");
            AlterColumn("dbo.Drinks", "IdType", c => c.String());
            AlterColumn("dbo.Drinks", "Id", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.Drinks", "IdSugar");
            DropColumn("dbo.Badges", "OwerMug");
            DropColumn("dbo.Badges", "IdDrink");
            AddPrimaryKey("dbo.Drinks", "Id");
        }
    }
}
