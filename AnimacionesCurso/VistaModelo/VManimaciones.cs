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
    bool _estadoSacudir;
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
    public bool EstadoSacudir
      {
      get { return _estadoSacudir; }
      set { SetValue(ref _estadoSacudir,value); }
      }
    #endregion
    #region PROCESOS
    private void Sacudir()
      {
      EstadoSacudir=true;
      EstadoSacudir=false;
      }
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
    public ICommand Sacudircommand => new Command(Sacudir);

    #endregion
    }
  }
