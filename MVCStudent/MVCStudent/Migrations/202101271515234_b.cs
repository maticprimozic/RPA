namespace MVCStudent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class b : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        StudentName = c.String(nullable: false),
                        Age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StudentId);
            
            AlterColumn("dbo.Mentors", "Priimek", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Mentors", "Priimek", c => c.String());
            DropTable("dbo.Students");
        }
    }
}
