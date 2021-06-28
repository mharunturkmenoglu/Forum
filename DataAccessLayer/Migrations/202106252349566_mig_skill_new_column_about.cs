namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_skill_new_column_about : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Skills", "SkillAbout", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Skills", "SkillAbout");
        }
    }
}
