namespace Cruelco_v2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Jokes",
                c => new
                    {
                        JokeId = c.Int(nullable: false, identity: true),
                        Opener = c.String(),
                        Punchline = c.String(),
                    })
                .PrimaryKey(t => t.JokeId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Jokes");
        }
    }
}
