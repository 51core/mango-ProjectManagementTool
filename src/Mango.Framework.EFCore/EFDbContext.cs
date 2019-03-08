using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Mango.Entity;
namespace Mango.Framework.EFCore
{
    public class EFDbContext : DbContext
    {
        public EFDbContext()
        {

        }

        public EFDbContext(DbContextOptions<EFDbContext> options): base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Core.Configuration.GetItem("ConnectionStrings"));
            }
        }
        #region Entity DbSet<>
        /// <summary>
        /// 客服账号表
        /// </summary>
        public virtual DbSet<m_ManagerAccount> m_ManagerAccount { get; set; }
        /// <summary>
        /// 菜单表
        /// </summary>
        public virtual DbSet<m_ManagerMenu> m_ManagerMenu { get; set; }
        /// <summary>
        /// 权限表
        /// </summary>
        public virtual DbSet<m_ManagerPower> m_ManagerPower { get; set; }
        /// <summary>
        /// 角色表
        /// </summary>
        public virtual DbSet<m_ManagerRole> m_ManagerRole { get; set; }
        #endregion
    }
}
