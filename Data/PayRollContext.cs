using Microsoft.EntityFrameworkCore;
using SharedModels;

namespace Nomina_Api.Data
{
    public class PayRollContext: DbContext
    {
        public PayRollContext(DbContextOptions<PayRollContext> options): base(options)
        { 
        }
        public DbSet<PayRoll> payRolls { get; set; }
        public DbSet<Employees> employees { get; set; }
        public DbSet<Incomes> incomes { get; set; }
        public DbSet<Deductions> deductions { get; set; }
    }
}
