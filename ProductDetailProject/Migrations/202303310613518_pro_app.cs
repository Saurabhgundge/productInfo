namespace ProductDetailProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class pro_app : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CategoryTable",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.ProductTable",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        ProductName = c.String(nullable: false),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ProductTable");
            DropTable("dbo.CategoryTable");
        }
    }
}
