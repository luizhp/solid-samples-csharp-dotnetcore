using System;

namespace SOLID05DependencyInversionPrinciple
{

  public interface IWindow
  {
    void open();
    void close();
  }

  class CarWindow : IWindow
  {
    public void open()
    {
      Console.WriteLine("Open window");
    }

    public void close()
    {
      Console.WriteLine("Close window");
    }
  }

  public class WindowSwitch
  {
    private IWindow _window;
    private bool _isOn = false;

    public WindowSwitch(IWindow window)
    {
      _window = window;
    }

    public void onPress()
    {
      if (this._isOn)
      {
        this._window.close();
        this._isOn = false;
      }
      else
      {
        this._window.open();
        this._isOn = true;
      }
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      IWindow windowFerrari = new CarWindow();
      IWindow windowLambo = new CarWindow();

      var windowFerrariSwitch = new WindowSwitch(windowFerrari);
      windowFerrariSwitch.onPress();
      windowFerrariSwitch.onPress();
      windowFerrariSwitch.onPress();

      var windowLamboSwitch = new WindowSwitch(windowLambo);
      windowLamboSwitch.onPress();
      windowLamboSwitch.onPress();
    }
  }
}
