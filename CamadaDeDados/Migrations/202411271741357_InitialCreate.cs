namespace CamadaDeDados.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Funcionarios",
                c => new
                    {
                        FuncionarioId = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Genero = c.String(),
                        Cidade = c.String(),
                        Salario = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DataNascimento = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.FuncionarioId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Funcionarios");
        }
    }
}
