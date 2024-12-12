namespace CamadaDeDados.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AtualizacaoModeloFuncionario : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Funcionarios", "Nome", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Funcionarios", "Genero", c => c.String(nullable: false));
            AlterColumn("dbo.Funcionarios", "Cidade", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Funcionarios", "Cidade", c => c.String());
            AlterColumn("dbo.Funcionarios", "Genero", c => c.String());
            AlterColumn("dbo.Funcionarios", "Nome", c => c.String());
        }
    }
}
