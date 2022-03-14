using Blueprint.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Blueprint.Infraestructure
{
    public class BlueprintContext : DbContext
    {        
        public BlueprintContext(DbContextOptions<BlueprintContext> options) : base(options)
        {
        }

        public DbSet<Group> Group => Set<Group>();
        public DbSet<Permission> Permission => Set<Permission>();
        public DbSet<Role> Role => Set<Role>();
        public DbSet<User> User => Set<User>();
        public DbSet<GroupToPermission> GroupToPermission => Set<GroupToPermission>();
        public DbSet<RoleToPermission> RoleToPermission => Set<RoleToPermission>();
        public DbSet<UserToPermission> UserToPermission => Set<UserToPermission>();
        public DbSet<GroupToRole> GroupToRole => Set<GroupToRole>();
        public DbSet<UserToGroup> UserToGroup => Set<UserToGroup>();
        public DbSet<UserToRole> UserToRole => Set<UserToRole>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}