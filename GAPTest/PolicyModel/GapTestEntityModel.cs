namespace PolicyModel
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class GapTestEntityModel : DbContext
    {
        public GapTestEntityModel()
            : base("name=GapTestEntityModel")
        {
        }

        public virtual DbSet<Client_has_Policy> Client_has_Policy { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Policy> Policies { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client_has_Policy>()
                .Property(e => e.cover_object)
                .IsUnicode(false);

            modelBuilder.Entity<Client_has_Policy>()
                .Property(e => e.coverage_monthly_price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Client>()
                .Property(e => e.full_name)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.Client_has_Policy)
                .WithRequired(e => e.Client)
                .HasForeignKey(e => e.client_id_client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Policy>()
                .Property(e => e.policy_name)
                .IsUnicode(false);

            modelBuilder.Entity<Policy>()
                .HasMany(e => e.Client_has_Policy)
                .WithRequired(e => e.Policy)
                .HasForeignKey(e => e.policy_id_policy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.user_password)
                .IsUnicode(false);
        }
    }
}
