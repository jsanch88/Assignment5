using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EFExample
{
public class FakeStorePurchaseOrder : DbContext
{
public DbSet<Id> Ids {get; set; }
public DbSet<Name> Names {get; set; }
public DbSet<Price> Prices {get; set; }
public DbSet<Quantity> Quantities {get; set; }
public DbSet<Total> Totals {get; set; }
public DbSet<SubTotal> SubTotals {get; set; }
public DbSet<GrandTotal> GrandTotals {get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder opt)
      => opt.UseSqlite(@"Data Source=FakeStorePurchase.sqlite");
}
  public class Id
  {
    public string ItemId { get; set; }
  }

  public class Name
  {
    public string ItemName { get; set; }
  }
  public class Price
  {
      public double ItemPrice {get; set; }
  }
    public class Quantity
  {
      public int ItemQuantity { get; set; }
  }
    public class Total
  {
      public double ItemTotal {get; set; }
  }

    public class SubTotal
  {
      public double ItemSubTotal {get; set; }
  }
    public class GrandTotal
  {
      public double ItemGrandTotal {get; set; }
  }

}