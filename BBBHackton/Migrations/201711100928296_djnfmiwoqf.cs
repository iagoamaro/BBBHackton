namespace BBBHackton.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class djnfmiwoqf : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Perfils", "AboutMe", c => c.String(nullable: false));
            AddColumn("dbo.Cursoes", "Atribuicao", c => c.String(nullable: false));
            AddColumn("dbo.ExpProfissionals", "Atribuicao", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ExpProfissionals", "Atribuicao");
            DropColumn("dbo.Cursoes", "Atribuicao");
            DropColumn("dbo.Perfils", "AboutMe");
        }
    }
}
