using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TransactionApp.Models;

namespace TransactionApp.Data
{
    public class TransactionAppContext : DbContext
    {
        public TransactionAppContext (DbContextOptions<TransactionAppContext> options)
            : base(options)
        {
        }

        public DbSet<TransactionApp.Models.TransactionModel> TransactionModel { get; set; } = default!;
    }
}
