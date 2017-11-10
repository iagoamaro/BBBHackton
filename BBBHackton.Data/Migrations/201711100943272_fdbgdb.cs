namespace BBBHackton.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fdbgdb : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Curso", "Atribuicao", c => c.String(nullable: false));
            AddColumn("dbo.Perfil", "AboutMe", c => c.String(nullable: false));
            AddColumn("dbo.ExpProfissional", "Atribuicao", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ExpProfissional", "Atribuicao");
            DropColumn("dbo.Perfil", "AboutMe");
            DropColumn("dbo.Curso", "Atribuicao");
        }
    }
}
