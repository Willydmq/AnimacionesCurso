using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using AnimacionesCurso.VistaModelo;

using Xamarin.Forms;

namespace AnimacionesCurso.VistaModelo
  {
  public class VManimaciones:BaseViewModel
    {
    #region VARIABLES
    bool _estadoRotar;
    #endregion
    #region CONSTRUCTOR
    public VManimaciones(INavigation navigation)
      {
      Navigation=navigation;
      }
    #endregion
    #region OBJETOS
    public bool EstadoRotar
      {
      get { return _estadoRotar; }
      set { SetValue(ref _estadoRotar,value); }
      }
    #endregion
    #region PROCESOS
   private void Rotarinfinito()
      {
      EstadoRotar=true;
      }

    public void Detenerrotar()
      {
      EstadoRotar=false;
      }
    #endregion
    #region COMANDOS
    public ICommand RotarInfinitocommand => new Command(Rotarinfinito);
    public ICommand Detenercommand => new Command(Detenerrotar);
    #endregion
    }
  }
