using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using Microsoft.Office.Interop.Excel;

namespace Lab3
{
  public partial class MainWindow : Form
  {
    public MainWindow()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void Calc_Click(object sender, EventArgs e)
    {
      экспортToolStripMenuItem.Enabled = true;
      сохранитьToolStripMenuItem.Enabled = true;
      List<string> list = new List<string>();
      List<string> listRes = new List<string>();
      bool check;
      double tmp = 0;
      double step = 0, left = 0, right = 0, a = 0;
      check = Double.TryParse(Step.Text, out tmp);
      if (!check || Convert.ToDouble(Step.Text) <= 0)
      {
        MessageBox.Show("Неверное значение для шага. " + '\n' +
          "(Шаг не может быть отрицательным)");
        return;
      }
      check = Double.TryParse(LeftBorder.Text, out tmp);
      if (!check || Convert.ToDouble(LeftBorder.Text) > Convert.ToDouble(RightBorder.Text))
      {
        MessageBox.Show("Ошибка. Проверьте границы.");
        return;
      }
      check = Double.TryParse(RightBorder.Text, out tmp);
      if (!check || Convert.ToDouble(LeftBorder.Text) > Convert.ToDouble(RightBorder.Text))
      {
        MessageBox.Show("Ошибка. Проверьте границы.");
        return;
      }
      check = Double.TryParse(AParam.Text, out tmp);
      if (!check || (Convert.ToDouble(AParam.Text) < Convert.ToDouble(RightBorder.Text)) || (Convert.ToDouble(AParam.Text) < -Convert.ToDouble(LeftBorder.Text)))
      {
        MessageBox.Show("Неверный параметр a.");
        return;
      }
      left = Convert.ToDouble(LeftBorder.Text);
      right = Convert.ToDouble(RightBorder.Text);
      step = Convert.ToDouble(Step.Text);
      a = Convert.ToDouble(AParam.Text);
      listRes = Calculate.Calc(step, left, right, a, listRes); //Calculate.Calc(i, step, left, right, a, list)
      int k = 0;
      for (double i = left; i < right; i = i + step)
      {
        tmp = Convert.ToDouble(listRes[k]);
        Graph.Series[0].Points.AddXY(i, tmp);
        Graph.Series[1].Points.AddXY(i, -tmp);
        list.Add(Math.Round((i), 3).ToString());
        list.Add("±" + tmp.ToString());
        k++;
      }
      int temp = 0;
      for (int i = temp; i < 100; i += 2)
      {
        if (temp >= list.Count)
        {
          break;
        }
        DisplayPoints.Rows.Add(list[i], list[i + 1]);
        temp += 2;
      }
    }

    private void Clear_Click(object sender, EventArgs e)
    {
      экспортToolStripMenuItem.Enabled = false;
      сохранитьToolStripMenuItem.Enabled = false;
      AParam.Text = "";
      LeftBorder.Text = "";
      RightBorder.Text = "";
      Step.Text = "";
      Graph.Series[0].Points.Clear();
      Graph.Series[1].Points.Clear();
      DisplayPoints.Rows.Clear();
    }

    private void экспортToolStripMenuItem_Click(object sender, EventArgs e)
    {
      {
        Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
        Workbook ExcelWorkBook;
        Worksheet ExcelWorkSheet;
        //Книга.
        ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
        //Таблица.
        ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);

        for (int i = 0; i < DisplayPoints.Rows.Count; i++)
        {
          for (int j = 0; j < DisplayPoints.ColumnCount; j++)
          {
            ExcelApp.Cells[i + 1, j + 1] = DisplayPoints.Rows[i].Cells[j].Value;
          }
        }

        Graph.SaveImage("chart.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
        ExcelWorkSheet.Shapes.AddPicture(Path.Combine(Environment.CurrentDirectory, "chart.bmp"), Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, 200, 25, Graph.Width / 2, Graph.Height / 2);

        //Вызываем нашу созданную эксельку.
        ExcelApp.Visible = true;
        ExcelApp.UserControl = true;
      }
    }

    private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
    {
      var saveDialog = new SaveFileDialog
      {
        Title = "Сохранить как...",
        OverwritePrompt = true, //отображать ли предупреждение, если пользователь указывает имя уже существующего файла
        CheckPathExists = true, //отображать ли предупреждение, если пользователь указывает несуществующий путь
        Filter = "Файлы txt (*.txt)|*.txt", //список форматов файла, отображаемый в поле "Тип файла"
        ShowHelp = true  //отображается ли кнопка "Справка" в диалоговом окне
      };
      if (saveDialog.ShowDialog() == DialogResult.OK)
      {
        try
        {
          string tmp = AParam.Text + " " + LeftBorder.Text + " " + RightBorder.Text + " " + Step.Text;
          using (BinaryWriter writer = new BinaryWriter(File.Open(@saveDialog.FileName, FileMode.OpenOrCreate)))
          {
            writer.Write(tmp);
            MessageBox.Show("Файл сохранен успешно", "Успех", MessageBoxButtons.OK);
          }
        }
        catch
        {
          MessageBox.Show("Невозможно сохранить файл", "Ошибка",
              MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
    }

    private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
    {
      var openDialog = new OpenFileDialog
      {
        Title = "Открыть",
        CheckFileExists = true,
        CheckPathExists = true,
        Filter = "Файлы txt (*.txt)|*.txt",
        ShowHelp = true
      };
      if (openDialog.ShowDialog() == DialogResult.OK)
      {
        try
        {
          using (BinaryReader reader = new BinaryReader(File.Open(@openDialog.FileName, FileMode.Open)))
          {
            string tmp = reader.ReadString();
            string[] list = tmp.Split();
            AParam.Text = list[0];
            LeftBorder.Text = list[1];
            RightBorder.Text = list[2];
            Step.Text = list[3];
          }
        }
        catch
        {
          MessageBox.Show("Невозможно открыть файл, попробуйте снова", "Ошибка",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
    }

    private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
    {
      About about = new About();
      about.ShowDialog();
    }

    private void выходToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
