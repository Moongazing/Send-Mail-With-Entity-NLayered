using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendMail
{
  public class MsgTypes
  {

    public static void ErrorMessage(string messageText)
    {
      MessageBox.Show(messageText, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    public static void WarningMessage(string messageText)
    {
      MessageBox.Show(messageText, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    public static DialogResult QuestionMessage(string messageText)
    {
      return MessageBox.Show(messageText, "QUESTION", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
    }

    public static void InformationMessage(string messageText)
    {
      MessageBox.Show(messageText, "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
  }
}
