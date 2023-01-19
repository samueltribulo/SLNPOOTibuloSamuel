namespace WindowsEFDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FK : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Avion", "LineaAerea_IdLinea", "dbo.LineaAerea");
            DropIndex("dbo.Avion", new[] { "LineaAerea_IdLinea" });
            RenameColumn(table: "dbo.Avion", name: "LineaAerea_IdLinea", newName: "LineaAerea_Id");
            AlterColumn("dbo.Avion", "LineaAerea_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Avion", "LineaAerea_Id");
            AddForeignKey("dbo.Avion", "LineaAerea_Id", "dbo.LineaAerea", "IdLinea", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Avion", "LineaAerea_Id", "dbo.LineaAerea");
            DropIndex("dbo.Avion", new[] { "LineaAerea_Id" });
            AlterColumn("dbo.Avion", "LineaAerea_Id", c => c.Int());
            RenameColumn(table: "dbo.Avion", name: "LineaAerea_Id", newName: "LineaAerea_IdLinea");
            CreateIndex("dbo.Avion", "LineaAerea_IdLinea");
            AddForeignKey("dbo.Avion", "LineaAerea_IdLinea", "dbo.LineaAerea", "IdLinea");
        }
    }
}
