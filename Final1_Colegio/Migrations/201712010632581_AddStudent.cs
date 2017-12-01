namespace Final1_Colegio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStudent : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Promedy", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "Promedy");
        }
    }
}
