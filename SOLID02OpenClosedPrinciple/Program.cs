using System;

namespace SOLID02OpenClosedPrinciple
{

  public class CreditCard
  {
    private string _code;
    private DateTime _expiration;
    protected Double _monthlyCost;

    public CreditCard(string code, DateTime expiration, Double monthlyCost)
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

    public virtual Double GetMonthlyDiscount()
    {
      return this._monthlyCost * 0.02;
    }

  }

  public class GoldCreditCard : CreditCard
  {

    public GoldCreditCard(string code, DateTime expiration, Double monthlyCost) : base(code, expiration, monthlyCost)
    {
    }

    public override Double GetMonthlyDiscount()
    {
      return this._monthlyCost * 0.05;
    }
  }

  class SilverCreditCard : CreditCard
  {

    public SilverCreditCard(string code, DateTime expiration, Double monthlyCost) : base(code, expiration, monthlyCost)
    {
    }
    public override Double GetMonthlyDiscount()
    {
      return this._monthlyCost * 0.03;
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      CreditCard cc = new CreditCard("123", new DateTime(), 10);
      Console.WriteLine($"Credit Card - Monthly Discount: {cc.GetMonthlyDiscount()}");

      CreditCard ccGold = new GoldCreditCard("123", new DateTime(), 10);
      Console.WriteLine($"Gold Credit Card - Monthly Discount: {ccGold.GetMonthlyDiscount()}");

      CreditCard ccSilver = new SilverCreditCard("123", new DateTime(), 10);
      Console.WriteLine($"Silver Credit Card - Monthly Discount: {ccSilver.GetMonthlyDiscount()}");
    }
  }
}
