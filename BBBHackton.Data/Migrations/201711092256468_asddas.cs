namespace BBBHackton.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asddas : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Perfil", "DataNascimento", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Perfil", "DataNascimento", c => c.DateTime(nullable: false));
        }
    }
}
