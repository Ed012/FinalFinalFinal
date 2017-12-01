namespace Final1_Colegio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNotePromedy : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Notes", "Promedy", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Notes", "Promedy");
        }
    }
}
