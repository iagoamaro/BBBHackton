namespace BBBHackton.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class jbnjun : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Perfils", "DataNascimento", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Perfils", "DataNascimento", c => c.DateTime(nullable: false));
        }
    }
}
