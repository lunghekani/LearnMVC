namespace LearnMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCustomers : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Customers ( Name, IsSubscribedToNewsletter, MembershipTypeId) VALUES ('Lunghekani Langa', 'False', 1)");
            Sql("INSERT INTO Customers ( Name, IsSubscribedToNewsletter, MembershipTypeId) VALUES ('Jermaine Cole', 'True', 2)");
            Sql("INSERT INTO Customers ( Name, IsSubscribedToNewsletter, MembershipTypeId) VALUES ('Kanye West', 'False', 3)");
            Sql("INSERT INTO Customers ( Name, IsSubscribedToNewsletter, MembershipTypeId) VALUES ('Robyn Fenty', 'True', 4)");
            Sql("INSERT INTO Customers ( Name, IsSubscribedToNewsletter, MembershipTypeId) VALUES ('Christopher Edwin Breaux', 'True', 4)");
        }
        
        public override void Down()
        {
        }
    }
}
