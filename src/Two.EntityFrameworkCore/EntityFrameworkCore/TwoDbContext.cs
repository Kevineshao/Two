using Microsoft.EntityFrameworkCore;
using Two.Model.GoodsModel;
using Two.Model.Orders;
using Two.Model.RBAC;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.IdentityServer.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.TenantManagement;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace Two.EntityFrameworkCore
{
    [ReplaceDbContext(typeof(IIdentityDbContext))]
    [ReplaceDbContext(typeof(ITenantManagementDbContext))]
    [ConnectionStringName("Default")]
    public class TwoDbContext : 
        AbpDbContext<TwoDbContext>,
        IIdentityDbContext,
        ITenantManagementDbContext
    {
        /* Add DbSet properties for your Aggregate Roots / Entities here. */
        
        #region Entities from the modules
        
        /* Notice: We only implemented IIdentityDbContext and ITenantManagementDbContext
         * and replaced them for this DbContext. This allows you to perform JOIN
         * queries for the entities of these modules over the repositories easily. You
         * typically don't need that for other modules. But, if you need, you can
         * implement the DbContext interface of the needed module and use ReplaceDbContext
         * attribute just like IIdentityDbContext and ITenantManagementDbContext.
         *
         * More info: Replacing a DbContext of a module ensures that the related module
         * uses this DbContext on runtime. Otherwise, it will use its own DbContext class.
         */
        
        //Identity
        public DbSet<IdentityUser> Users { get; set; }
        public DbSet<IdentityRole> Roles { get; set; }
        public DbSet<IdentityClaimType> ClaimTypes { get; set; }
        public DbSet<OrganizationUnit> OrganizationUnits { get; set; }
        public DbSet<IdentitySecurityLog> SecurityLogs { get; set; }
        public DbSet<IdentityLinkUser> LinkUsers { get; set; }
        
        // Tenant Management
        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<TenantConnectionString> TenantConnectionStrings { get; set; }

        #endregion
        
        public TwoDbContext(DbContextOptions<TwoDbContext> options)
            : base(options)
        {

        }

        public DbSet<User> GetUsers { get; set; }
        public DbSet<Role> GetRoles { get; set; }
        public DbSet<Menu> GetMenus { get; set; }
        public DbSet<UserRole> GetUserRoles { get; set; }
        public DbSet<RoleMenu> GetRoleMenus { get; set; }


        public DbSet<Goods> GetGoods { get; set; }
        public DbSet<Inventory> GetInventory{ get; set; }
        public DbSet<Kind> GetKinds { get; set; }
        public DbSet<Basic> GetBasics { get; set; }
        public DbSet<Member> GetMembers { get; set; }
        public DbSet<Photo> GetPhotos { get; set; }
        public DbSet<Specs> GetSpecs { get; set; }

        public DbSet<Address> GetAddresses { get; set; }
        public DbSet<Detail> GetDetails { get; set; }
        public DbSet<Logistics> GetLogistics { get; set; }
        public DbSet<Orders> GetOrders { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            /* Include modules to your migration db context */

            builder.ConfigurePermissionManagement();
            builder.ConfigureSettingManagement();
            builder.ConfigureBackgroundJobs();
            builder.ConfigureAuditLogging();
            builder.ConfigureIdentity();
            builder.ConfigureIdentityServer();
            builder.ConfigureFeatureManagement();
            builder.ConfigureTenantManagement();

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(TwoConsts.DbTablePrefix + "YourEntities", TwoConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});


            builder.Entity<User>(b => 
            { b.ToTable("tb_User"); 
                b.ConfigureByConvention();
            });
            builder.Entity<Role>(b =>
            {
                b.ToTable("tb_Role");
                b.ConfigureByConvention();
            });
            builder.Entity<Menu>(b =>
            {
                b.ToTable("tb_Menu");
                b.ConfigureByConvention();
            });
            builder.Entity<UserRole>(b =>
            {
                b.ToTable("tb_UserRole");
                b.ConfigureByConvention();
            });
            builder.Entity<RoleMenu>(b =>
            {
                b.ToTable("tb_RoleMenu");
                b.ConfigureByConvention();
            });


            
            builder.Entity<Goods>(b =>
            {
                b.ToTable("tb_Goods");
                b.ConfigureByConvention();
            });
            builder.Entity<Inventory>(b =>
            {
                b.ToTable("tb_Inventory");
                b.ConfigureByConvention();
            });
            builder.Entity<Kind>(b =>
            {
                b.ToTable("tb_Kind");
                b.ConfigureByConvention();
            });
            builder.Entity<Basic>(b =>
            {
                b.ToTable("tb_Basic");
                b.ConfigureByConvention();
            });
            builder.Entity<Member>(b =>
            {
                b.ToTable("tb_Member");
                b.ConfigureByConvention();
            });
            builder.Entity<Photo>(b =>
            {
                b.ToTable("tb_Photo");
                b.ConfigureByConvention();
            });
            builder.Entity<Specs>(b =>
            {
                b.ToTable("tb_Specs");
                b.ConfigureByConvention();
            });



           
            builder.Entity<Detail>(b =>
            {
                b.ToTable("tb_Detail");
                b.ConfigureByConvention();
            });
            builder.Entity<Logistics>(b =>
            {
                b.ToTable("tb_Logistics");
                b.ConfigureByConvention();
            });
            builder.Entity<Orders>(b =>
            {
                b.ToTable("tb_Orders");
                b.ConfigureByConvention();
            });
            builder.Entity<Address>(b =>
            {
                b.ToTable("tb_Address");
                b.ConfigureByConvention();
            });

        }
    }
}
