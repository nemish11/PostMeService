namespace PostMeService.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Model : DbContext
    {
        // Your context has been configured to use a 'Model' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'PostMeService.Models.Model' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Model' 
        // connection string in the application configuration file.
        public Model()
            : base("name=PostMeTest")
        {
        }

        /*protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comment>()
                .HasOptional<User>(c => c.user)
                .WithMany()
                .WillCascadeOnDelete(false);
        }*/

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<Post> posts { get; set; }
        public DbSet<Comment> comments { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}