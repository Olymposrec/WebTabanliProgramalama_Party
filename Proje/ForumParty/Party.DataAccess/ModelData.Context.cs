﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Party.DataAccess
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ForumPartyEntities1 : DbContext
    {
        public ForumPartyEntities1()
            : base("name=ForumPartyEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AboutUsers> AboutUsers { get; set; }
        public virtual DbSet<Adress> Adress { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Communities> Communities { get; set; }
        public virtual DbSet<CommunityPermissions> CommunityPermissions { get; set; }
        public virtual DbSet<Posts> Posts { get; set; }
        public virtual DbSet<PrivacyStatement> PrivacyStatement { get; set; }
        public virtual DbSet<Questions> Questions { get; set; }
        public virtual DbSet<Surveys> Surveys { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UsersState> UsersState { get; set; }
        public virtual DbSet<UsersCommunity> UsersCommunity { get; set; }
        public virtual DbSet<UserFollowers> UserFollowers { get; set; }
    }
}
