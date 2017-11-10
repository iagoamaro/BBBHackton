namespace BBBHackton.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class saffwefdsd : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetUsers", "FirstName");
            DropColumn("dbo.AspNetUsers", "LastName");
            DropColumn("dbo.AspNetUsers", "DataNasc");
            DropColumn("dbo.AspNetUsers", "LinkSocialPerfil");
            DropColumn("dbo.AspNetUsers", "Genero");
            DropColumn("dbo.AspNetUsers", "Locale");
            DropColumn("dbo.AspNetUsers", "Foto");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "Foto", c => c.String(nullable: false));
            AddColumn("dbo.AspNetUsers", "Locale", c => c.String(nullable: false));
            AddColumn("dbo.AspNetUsers", "Genero", c => c.String(nullable: false));
            AddColumn("dbo.AspNetUsers", "LinkSocialPerfil", c => c.String(nullable: false));
            AddColumn("dbo.AspNetUsers", "DataNasc", c => c.DateTime(nullable: false));
            AddColumn("dbo.AspNetUsers", "LastName", c => c.String(nullable: false));
            AddColumn("dbo.AspNetUsers", "FirstName", c => c.String(nullable: false));
        }
    }
}
