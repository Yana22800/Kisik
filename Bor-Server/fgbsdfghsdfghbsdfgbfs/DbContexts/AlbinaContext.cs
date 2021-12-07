using Bor.DataAccess.Core.Interfaces;
using Bor.DataAccess.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bor.DataAccess.DbContexts
{
    public class AlbinaContext : DbContext, IContext
    {
        public AlbinaContext(DbContextOptions<AlbinaContext> options) : base(options)
        {
        }

        public DbSet<UserRto> Users { get; set; }
        public DbSet<VirtualExpenseRto> VirtualExpenses { get; set; }
        public DbSet<RejectExpenseRto> RejectExpenses { get; set; }
        public DbSet<AcceptExpenseRto> AcceptExpenses { get; set; }
    }
}
