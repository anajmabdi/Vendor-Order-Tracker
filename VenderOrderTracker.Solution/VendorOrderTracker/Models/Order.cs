using System;
namespace VendorOrder.Models
{
  public class Order
  {
    public string Title {get;set;}
    public string Description {get;set;}
    public int Price {get;set;}
    public DateTime Date {get;set;}

    public Order(string title, string description, int price)
    {
      Title = title;
      Description = description;
      Price = price;
      Date = DateTime.Today;
    }
  }
}