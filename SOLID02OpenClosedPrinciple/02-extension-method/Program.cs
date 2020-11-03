using System;

namespace SOLID02OpenClosedPrinciple.ExtensionMethod
{
  public class CreditCard
  {
    private readonly string _code;
    private readonly DateTime _expiration;
    private Double _monthlyCost;

    internal CreditCard(string code, DateTime expiration, Double monthlyCost)
    {
      this._code = code;
      this._expiration = expiration;
      this._monthlyCost = monthlyCost;
    }

    public string GetCode()
    {
      return this._code;
    }

    public DateTime GetExpiration()
    {
      return this._expiration;
    }

    public Double GetMonthlyCost()
    {
      return this._monthlyCost;
    }
  }

  public static class GoldCreditCard
  {
    public static Double GetMonthlyDiscountGold(this CreditCard creditCard)
    {
      return creditCard.GetMonthlyCost() * 0.05;
    }
  }

  public static class SilverCreditCard
  {
    public static Double GetMonthlyDiscountSilver(this CreditCard creditCard)
    {
      return creditCard.GetMonthlyCost() * 0.03;
    }
  }

  internal static class Program
  {
    private static void Main()
    {
      var creditCard = new CreditCard("123", new DateTime(), 10);

      Console.WriteLine($"Gold Credit Card - Monthly Discount: {creditCard.GetMonthlyDiscountGold()}");
      Console.WriteLine($"Silver Credit Card - Monthly Discount: {creditCard.GetMonthlyDiscountSilver()}");
    }
  }
}
