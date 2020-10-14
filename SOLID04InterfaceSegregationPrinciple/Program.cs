using System;

namespace SOLID04InterfaceSegregationPrinciple
{
  public interface Printer
  {
    void printDocument(Document document);
  }

  public interface Stapler
  {
    void stapleDocument(Document document, int tray);
  }

  public interface Copier
  {
    void copyDocument(Document document);
  }

  public class SimplePrinter : Printer
  {
    public void printDocument(Document document)
    {
      Console.WriteLine($"SimplePrinter: {document.GetContent()}");
    }
  }

  public class SuperPrinter : Printer, Stapler, Copier
  {
    public void copyDocument(Document document)
    {
      Console.WriteLine($"SuperPrinter@copyDocument: {document.GetContent()}");
    }

    public void printDocument(Document document)
    {
      Console.WriteLine($"SuperPrinter@printDocument: {document.GetContent()}");
    }

    public void stapleDocument(Document document, int tray)
    {
      Console.WriteLine($"SuperPrinter@stapleDocument: {document.GetContent()}");
    }
  }

  public class Document
  {
    private string _text;

    public Document(string text)
    {
      _text = text;
    }

    public string GetContent()
    {
      return _text;
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Print draft document at simple printer");
      var draftDocument = new Document("some draft");
      new SimplePrinter().printDocument(draftDocument);
      
      Console.WriteLine("Print important document at super printer");
      var importantDocument = new Document("account report");
      new SuperPrinter().printDocument(importantDocument);
      new SuperPrinter().copyDocument(importantDocument);
      new SuperPrinter().stapleDocument(importantDocument, 1);
    }
  }
}
