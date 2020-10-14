using System;

namespace SOLID03LiskovSubstitutionPrinciple
{

  public abstract class PostalAddress
  {
    public string addressee;
    public string country;
    public string postalCode;
    public string city;
    public string street;
    public int house;

    /*
    * @returns Formatted full address
    */
    public abstract string WriteAddress();
  }

  public class ItalyPostalAddress : PostalAddress
  {
    public override string WriteAddress()
    {
      return $"Italy {this.city}";
    }
  }

  public class UKPostalAddress : PostalAddress
  {
    public override string WriteAddress()
    {
      return $"UK {this.city}";
    }
  }

  public class USAPostalAddress : PostalAddress
  {
    public override string WriteAddress()
    {
      return $"USA {this.city}";
    }
  }

  public class AddressWriter
  {
    public string PrintPostalAddress(PostalAddress writer)
    {
      return $"Formatted Address {writer.WriteAddress()}";
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      PostalAddress italyPostalAddress = new ItalyPostalAddress();
      italyPostalAddress.city = "Rome";

      PostalAddress ukPostalAddress = new UKPostalAddress();
      ukPostalAddress.city = "London";

      PostalAddress usaPostalAddress = new USAPostalAddress();
      usaPostalAddress.city = "Washington DC";

      var addressWriter = new AddressWriter();
      Console.WriteLine(addressWriter.PrintPostalAddress(italyPostalAddress));
      Console.WriteLine(addressWriter.PrintPostalAddress(ukPostalAddress));
      Console.WriteLine(addressWriter.PrintPostalAddress(usaPostalAddress));
    }
  }
}
