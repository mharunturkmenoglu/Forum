namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_skill_added : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Skills",
                c => new
                    {
                        SkillID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        Surname = c.String(maxLength: 50),
                        Skill1 = c.String(maxLength: 50),
                        Skill2 = c.String(maxLength: 50),
                        Skill3 = c.String(maxLength: 50),
                        Skill4 = c.String(maxLength: 50),
                        Skill5 = c.String(maxLength: 50),
                        Skill6 = c.String(maxLength: 50),
                        Skill7 = c.String(maxLength: 50),
                        SkillValue1 = c.Int(nullable: false),
                        SkillValue2 = c.Int(nullable: false),
                        SkillValue3 = c.Int(nullable: false),
                        SkillValue4 = c.Int(nullable: false),
                        SkillValue5 = c.Int(nullable: false),
                        SkillValue6 = c.Int(nullable: false),
                        SkillValue7 = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SkillID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Skills");
        }
    }
}
