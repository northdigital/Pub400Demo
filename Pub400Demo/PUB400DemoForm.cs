using System;
using System.Windows.Forms;

namespace Pub400Demo
{
  public partial class PUB400DemoForm : Form
  {
    public PUB400DemoForm()
    {
      InitializeComponent();
    }

    private void Form1_Shown(object sender, EventArgs e)
    {
      try
      {
        Cursor = Cursors.WaitCursor;
        customerTableAdapter.Fill(pUB400Dataset.CUSTOMER);
        itemTableAdapter.Fill(pUB400Dataset.ITEM);
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
      finally
      {
        Cursor = Cursors.Default;
      }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      try
      {
        Cursor = Cursors.WaitCursor;
        customerTableAdapter.Update(pUB400Dataset.CUSTOMER);
        itemTableAdapter.Update(pUB400Dataset.ITEM);        
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
      finally
      {
        Cursor = Cursors.Default;
      }
    }

    private void repCustomerDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
    {
      try
      {
        gvCustomer.DeleteSelectedRows();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
      finally
      {
        Cursor = Cursors.Default;
      }
    }

    private void repItemDelete_Click(object sender, EventArgs e)
    {
      try
      {
        gvItem.DeleteSelectedRows();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
      finally
      {
        Cursor = Cursors.Default;
      }
    }
  }
}
