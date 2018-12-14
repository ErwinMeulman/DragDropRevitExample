using System;
using System.Windows.Forms;

namespace DragDropRevitExample
{
  static class Program
  {
    /// <summary>
    /// Application main entry point and mainline.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault( false );
      Application.Run( new Form1() );
    }
  }
}
