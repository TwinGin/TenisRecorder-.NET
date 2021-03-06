namespace TenisRecorder2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenamedConversationToFriendModel : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.ConversationModels", newName: "FriendsModels");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.FriendsModels", newName: "ConversationModels");
        }
    }
}
