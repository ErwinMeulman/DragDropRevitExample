using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Windows.Forms;
using System.IO;

namespace DragDropRevitExample
{
  public partial class Form1 : Form
  {
    DirectoryInfo _StartDir = null;
    const string _Extension = "*.rfa";

    public Form1()
    {
      InitializeComponent();

      Setup();

      FillMyListViewWithFamilies();
    }

    void Setup()
    {
      _listViewTestFamilies.Dock = DockStyle.Fill;
      _StartDir = new DirectoryInfo( Path.GetDirectoryName( GetType().Assembly.Location ) );
    }

    ListViewItem GetListViewItemAt( MouseEventArgs e )
    {
      ListViewItem item = _listViewTestFamilies.GetItemAt( e.X, e.Y );
      return item;
    }

    void FillMyListViewWithFamilies()
    {
      List<FileInfo> _ListFamilyFiles = new List<FileInfo>();

      _listViewTestFamilies.Items.Clear();

      if( _StartDir != null )
        _ListFamilyFiles.AddRange( _StartDir.GetFiles( 
          _Extension, SearchOption.AllDirectories ) );

      foreach( FileInfo fitem in _ListFamilyFiles )
      {
        ListViewItem it = new ListViewItem( fitem.Name );
        it.Tag = fitem;
        _listViewTestFamilies.Items.Add( it );
      }
    }

    int indexOfItemUnderMouseToDrag = 0;

    void _listViewTestFamilies_MouseDown( 
      object sender, 
      MouseEventArgs e )
    {
      ListViewItem item = GetListViewItemAt( e );
      if( item != null )
      {
        indexOfItemUnderMouseToDrag = item.Index;
      }
    }

    void _listViewTestFamilies_MouseMove( 
      object sender, 
      MouseEventArgs e )
    {
      if( ( e.Button & MouseButtons.Left ) == MouseButtons.Left )
      {
        // Proceed with the drag-and-drop, 
        // passing in the list item.
        
        FileInfo finf 
          = (FileInfo) _listViewTestFamilies.Items[
            indexOfItemUnderMouseToDrag].Tag;

        if( finf.Exists )
        {
          DataObject myDataObject = new DataObject();

          // You have to set up the FileDropList, 
          // otherwise nothing will happen ;-)

          StringCollection coll 
            = new StringCollection();

          coll.Add( finf.FullName );

          myDataObject.SetFileDropList( coll );

          DragDropEffects dropEffect 
            = _listViewTestFamilies.DoDragDrop( 
              myDataObject, DragDropEffects.Copy );
        }
      }
    }
  }
}
