namespace CapaDato.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstDataBase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        RoleId = c.Int(nullable: false),
                        nombre = c.String(maxLength: 30),
                        Usuario_transaccion = c.String(),
                        Fecha_Transaccionn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.RoleId)
                .Index(t => t.nombre, unique: true, name: "Is_nombre");
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Nombre = c.String(),
                        apellido = c.String(),
                        Cedula = c.String(maxLength: 35),
                        Usuario_nombre = c.String(maxLength: 45),
                        Contrasena = c.String(),
                        Fecha_Nacimiento = c.DateTime(nullable: false),
                        Usuario_transaccion = c.String(),
                        Fecha_Transaccionn = c.DateTime(nullable: false),
                        RoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Roles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.Cedula, unique: true, name: "Is_Cedula")
                .Index(t => t.Usuario_nombre, unique: true, name: "Is_Usuario_nombre")
                .Index(t => t.RoleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Usuarios", "RoleId", "dbo.Roles");
            DropIndex("dbo.Usuarios", new[] { "RoleId" });
            DropIndex("dbo.Usuarios", "Is_Usuario_nombre");
            DropIndex("dbo.Usuarios", "Is_Cedula");
            DropIndex("dbo.Roles", "Is_nombre");
            DropTable("dbo.Usuarios");
            DropTable("dbo.Roles");
        }
    }
}
