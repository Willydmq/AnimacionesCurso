using System;

using AnimacionesCurso.Vistas;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AnimacionesCurso
  {
  public partial class App : Application
    {
    public App()
      {
      InitializeComponent();

      MainPage=new animaciones();
      }

    protected override void OnStart()
      {
      }

    protected override void OnSleep()
      {
      }

    protected override void OnResume()
      {
      }
    }
  }
