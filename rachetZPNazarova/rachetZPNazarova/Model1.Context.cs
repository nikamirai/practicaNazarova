﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace rachetZPNazarova
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ZPPrakticaEntities : DbContext
    {
        private static ZPPrakticaEntities _context;
        public ZPPrakticaEntities()
            : base("name=ZPPrakticaEntities")
        {
        }
        public static ZPPrakticaEntities GetContext()
        {
            if (_context == null)
                _context = new ZPPrakticaEntities();
            return _context;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<PointStaff> PointStaff { get; set; }
        public virtual DbSet<Staff> Staff { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TypePoint> TypePoint { get; set; }
        public virtual DbSet<UserSystem> UserSystem { get; set; }
    }
}
