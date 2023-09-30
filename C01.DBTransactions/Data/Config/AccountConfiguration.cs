using C01.DBTransactions.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF018.ChangeTracking.Data.Config
{
    public class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.HasKey(x => x.AccountNumber);
            builder.Property(x => x.AccountNumber).ValueGeneratedNever();

            builder.Property(x => x.AccountNumber)
                .HasColumnType("VARCHAR")
                .HasMaxLength(20).IsRequired();

            builder.Property(x => x.Balance).HasColumnType("decimal(18, 2)").IsRequired();

            builder.ToTable("Books");
        }
    }
}
