namespace Models
{
	public class User : BaseEntity
	{
		#region Configuration
		internal class Configuration :
			System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<User>
		{
			public Configuration() : base()
			{
			}
		}
		#endregion /Configuration

		public User() : base()
		{
		}

		// **********
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 50)]
		public string Name { get; set; }
		// **********

		// **********
		public virtual System.Collections.Generic.IList<Post> WrittenPosts { get; set; }
		// **********

		// **********
		public virtual System.Collections.Generic.IList<Post> VerifiedPosts { get; set; }
		// **********
	}
}
