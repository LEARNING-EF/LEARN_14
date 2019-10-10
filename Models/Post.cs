namespace Models
{
	public class Post : BaseEntity
	{
		#region Configuration
		internal class Configuration :
			System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Post>
		{
			public Configuration() : base()
			{
				HasRequired(current => current.WritterUser)
					.WithMany(user => user.WrittenPosts)
					.HasForeignKey(current => current.WritterUserId)
					.WillCascadeOnDelete(false);

				HasOptional(current => current.VerifierUser)
					.WithMany(user => user.VerifiedPosts)
					.HasForeignKey(current => current.VerifierUserId)
					.WillCascadeOnDelete(false);
			}
		}
		#endregion /Configuration

		public Post() : base()
		{
		}

		// **********
		// **********
		// **********
		public virtual User WritterUser { get; set; }
		// **********

		// **********
		public System.Guid WritterUserId { get; set; }
		// **********
		// **********
		// **********

		// **********
		// **********
		// **********
		public virtual User VerifierUser { get; set; }
		// **********

		// **********
		public System.Guid? VerifierUserId { get; set; }
		// **********
		// **********
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 50)]
		public string Name { get; set; }
		// **********
	}
}
