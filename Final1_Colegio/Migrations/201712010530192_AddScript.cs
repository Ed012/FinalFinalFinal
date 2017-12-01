namespace Final1_Colegio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddScript : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        IdCourse = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        IdStudent = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdCourse)
                .ForeignKey("dbo.Students", t => t.IdStudent, cascadeDelete: true)
                .Index(t => t.IdStudent);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        IdStudent = c.Int(nullable: false, identity: true),
                        Full_Name = c.String(),
                        DNI = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdStudent);
            
            CreateTable(
                "dbo.Notes",
                c => new
                    {
                        IdNote = c.Int(nullable: false, identity: true),
                        Note1 = c.Int(nullable: false),
                        Note2 = c.Int(nullable: false),
                        IdStudent = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdNote)
                .ForeignKey("dbo.Students", t => t.IdStudent, cascadeDelete: true)
                .Index(t => t.IdStudent);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Notes", "IdStudent", "dbo.Students");
            DropForeignKey("dbo.Courses", "IdStudent", "dbo.Students");
            DropIndex("dbo.Notes", new[] { "IdStudent" });
            DropIndex("dbo.Courses", new[] { "IdStudent" });
            DropTable("dbo.Notes");
            DropTable("dbo.Students");
            DropTable("dbo.Courses");
        }
    }
}
