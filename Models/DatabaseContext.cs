namespace Models
{
	public class DatabaseContext : System.Data.Entity.DbContext
	{
		static DatabaseContext()
		{
			System.Data.Entity.Database
				.SetInitializer(new DatabaseContextInitializer());
		}

		public DatabaseContext() : base()
		{
		}

		// **********
		public System.Data.Entity.DbSet<Post> Posts { get; set; }
		// **********

		// **********
		public System.Data.Entity.DbSet<User> Users { get; set; }
		// **********

		protected override void OnModelCreating
			(System.Data.Entity.DbModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Configurations.Add(new Post.Configuration());
			modelBuilder.Configurations.Add(new User.Configuration());
		}
	}
}
