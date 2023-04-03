namespace ProductDetailProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fkadded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CategoryTable", "ProductId", c => c.Int());
            CreateIndex("dbo.CategoryTable", "ProductId");
            AddForeignKey("dbo.CategoryTable", "ProductId", "dbo.ProductTable", "ProductId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CategoryTable", "ProductId", "dbo.ProductTable");
            DropIndex("dbo.CategoryTable", new[] { "ProductId" });
            DropColumn("dbo.CategoryTable", "ProductId");
        }
    }
}
