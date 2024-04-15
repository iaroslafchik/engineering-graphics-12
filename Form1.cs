using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graphics_lab_1_2
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      OpenFileDialog selectFile = new OpenFileDialog();

      selectFile.CheckPathExists = true;
      selectFile.Filter = "Text Files(*.txt)|*.txt";

      selectFile.ShowDialog();
      richTextBox1.LoadFile(selectFile.OpenFile(), RichTextBoxStreamType.PlainText);
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }
  }
}
