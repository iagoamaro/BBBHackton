namespace BBBHackton.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class date : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "DataNasc", c => c.DateTime(nullable: false));
            DropColumn("dbo.AspNetUsers", "Idade");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "Idade", c => c.Int(nullable: false));
            DropColumn("dbo.AspNetUsers", "DataNasc");
        }
    }
}
