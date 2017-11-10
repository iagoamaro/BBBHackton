namespace BBBHackton.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addfields : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "FirstName", c => c.String(nullable: false));
            AddColumn("dbo.AspNetUsers", "LastName", c => c.String(nullable: false));
            AddColumn("dbo.AspNetUsers", "Idade", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "LinkSocialPerfil", c => c.String(nullable: false));
            AddColumn("dbo.AspNetUsers", "Genero", c => c.String(nullable: false));
            AddColumn("dbo.AspNetUsers", "Locale", c => c.String(nullable: false));
            AddColumn("dbo.AspNetUsers", "Foto", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Foto");
            DropColumn("dbo.AspNetUsers", "Locale");
            DropColumn("dbo.AspNetUsers", "Genero");
            DropColumn("dbo.AspNetUsers", "LinkSocialPerfil");
            DropColumn("dbo.AspNetUsers", "Idade");
            DropColumn("dbo.AspNetUsers", "LastName");
            DropColumn("dbo.AspNetUsers", "FirstName");
        }
    }
}
