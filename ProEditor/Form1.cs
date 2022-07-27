using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ProEditor
{
  public partial class frm_edit_prog : Form
  {
    bool flg_err_msg = false;
    public frm_edit_prog()
    {
      InitializeComponent();
      saveFileDialog1.Filter = "Text files(*.NC)|*.nc|All files(*.*)|*.*";
      txt_G.LostFocus += is_check_fld;
      txt_H.LostFocus += is_check_fld;
      txt_H1.LostFocus += is_check_fld;
      txt_H2.LostFocus += is_check_fld;
      txt_XY.LostFocus += is_check_fld;
      txt_S.LostFocus += is_check_fld;
      txt_F.LostFocus += is_check_fld;
      txt_Z1.LostFocus += is_check_fld;
      txt_Z2.LostFocus += is_check_fld;
      txt_Step.LostFocus += is_check_fld;
      txt_Start.LostFocus += is_check_fld;
      txt_End.LostFocus += is_check_fld;
    }

    //сохранить файл
    private void but_save_Click(object sender, EventArgs e)
    {
      if (txt_box_prog.Text == "")
      {
        MessageBox.Show("Нет данных для сохранения!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }     
      if (saveFileDialog1.ShowDialog() == DialogResult.Cancel) return;

      string file_name = saveFileDialog1.FileName;
      System.IO.File.WriteAllText(file_name, txt_box_prog.Text);
    }

    //закрыть по Esc
    private void frm_edit_prog_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Escape) Close();
    }

    //сгенерировать программу
    private void but_edit_Click(object sender, EventArgs e)
    {
      string txt_prog = "", txt_prog_buf = "", fg1 ="";
      int poz=0, num = 0, h2=0, i=0, j=0, h1=0, hg=0, g=0, g1=0, step=0;
      int s = Int32.Parse(txt_S.Text); //значение оборотов шпинделя на форме должно реальное, потом его надо умножить на 2 - особенность стойки Esfero 3D

      String[] xy_list= txt_XY.Text.Split(new String[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
      h1 = Int32.Parse(txt_H1.Text);
      h2 = Int32.Parse(txt_H2.Text);
      g = Int32.Parse(txt_G.Text);
      step = Int32.Parse(txt_Step.Text);

      //шапка программы
      string txt_start_buf = txt_Start.Text;
      string txt_start = txt_start_buf.Replace("[D]", txt_D.Text);
      txt_start = txt_start.Replace("[S]", Convert.ToString(s * 2));
      txt_start = txt_start.Replace("[Z1]", txt_Z1.Text);
      string[] stringSeparators = new string[] { "\r\n" };
      string[] subs = txt_start.Split(stringSeparators, StringSplitOptions.None);
      string sNum="";
      txt_start = "";
      foreach (var sub in subs){
        if (i > 1) sNum = "N" + Convert.ToString(step * (i - 1)) + " ";
        txt_start += sNum + sub + "\r\n";
        i++;
      }
      num = step * (i-1);
      char[] charsToTrim = { '.', ' '};
      hg = g / h1 + 1;
      for (i=0; i< xy_list.Length; i++){
        txt_prog_buf = xy_list[i].Trim(charsToTrim);
        if (txt_prog_buf.StartsWith("N")){
          poz = txt_prog_buf.IndexOf(" ", 0);
          txt_prog_buf = txt_prog_buf.Substring(poz + 1);
        }

        txt_prog += "N" + Convert.ToString(num) + " " + txt_prog_buf + "\r\n";
        for (j=1; j<= hg; j++){
          if (j == 1) fg1 = " F" + txt_F.Text; else fg1 = "";
          g1 = h1 * j;
          if (g - g1 < 0) g1 = g;
          txt_prog += "N" + Convert.ToString(num + step) + " G01 Z-" + Convert.ToString(g1) + fg1 + "\r\n";
          if (g1 == g) break;
          if (j < hg){
            txt_prog += "N" + Convert.ToString(num + step*2) + " G00 Z" + txt_H.Text + "\r\n";
            txt_prog += "N" + Convert.ToString(num + step*3) + " Z-" + Convert.ToString(h1 * j - h2) + "\r\n";
          }
          num += step*3;
        }
        if(i < xy_list.Length-1)
          txt_prog += "N" + Convert.ToString(num - step) + " G00 Z" + txt_H.Text + "\r\n";
      }

      //конец программы
      string txt_end_buf = txt_End.Text;
      string txt_end = txt_end_buf.Replace("[Z2]", txt_Z2.Text);
      subs = txt_end.Split(stringSeparators, StringSplitOptions.None);
      i = 2;
      txt_end = "";
      sNum = "";
      foreach (var sub in subs){
        sNum = "N" + Convert.ToString(num + (step * i)) + " ";
        txt_end += sNum + sub + "\r\n";
        i++;
      }
      //итоговая сборка
      txt_box_prog.Text = txt_start + txt_prog + txt_end;
    }

    //проверки после изменения значений
    private void is_check_fld(object sender, EventArgs e)
    {
      int val1 = 0, val2 = 0;
      
      TextBox txt_fld = (TextBox)sender;
      //проверка на пустые поля
      if (txt_fld.Text == ""){
        MessageBox.Show("Поле не должно быть пустым!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        txt_fld.Undo();
        txt_fld.Focus();
        return;
      }

      //проверка свойств чисел
      if(txt_fld.Name != "txt_XY" && txt_fld.Name != "txt_Start" && txt_fld.Name != "txt_End"){
        //проверка является ли значение в поле числом
        bool result = int.TryParse(txt_fld.Text, out val1);
        if (result == false)
        {
          MessageBox.Show("Значение " + txt_fld.Text + " не является числом!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          txt_fld.Undo();
          txt_fld.Focus();
          return;
        }
        //проверка на ноль и отрицательное значение
        val1 = Int32.Parse(txt_fld.Text);
        if (val1 <= 0){
          MessageBox.Show("Значение " + txt_fld.Text + " не может быть меньше или равным нулю!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          txt_fld.Undo();
          txt_fld.Focus();
          return;
        }
      }

      //проверка оборотов шпинделя
      if (txt_fld.Name == "txt_S"){
        if (val1 < 3000){
          MessageBox.Show("Обороты шпинделя не могут быть меньше 3000!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          txt_fld.Undo();
          txt_fld.Focus();
          return;
        }
        if (val1 > 12000){
          MessageBox.Show("Обороты шпинделя не могут быть больше 12000!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          txt_fld.Undo();
          txt_fld.Focus();
          return;
        }
      }

      //проверка глубины и недохода
      if (txt_fld.Name == "txt_H1" || txt_fld.Name == "txt_H2"){
        if(flg_err_msg==true){
          flg_err_msg = false;
          return;
        }
        val1 = Int32.Parse(txt_H1.Text);
        val2 = Int32.Parse(txt_H2.Text);
        if (val1 <= val2){
          flg_err_msg = true;
          MessageBox.Show("Значение Н1 не может быть меньше либо равно Н2!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          txt_fld.Undo();
          txt_fld.Focus();
          return;
        }
      }
    }

    private void but_close_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void frm_edit_prog_Load(object sender, EventArgs e)
    {
      ToolTip toolTip1 = new ToolTip();
      toolTip1.AutoPopDelay = 5000;
      toolTip1.InitialDelay = 1000;
      toolTip1.ReshowDelay = 500;
      toolTip1.ShowAlways = true;

      toolTip1.SetToolTip(this.but_edit, "Сгенерировать программу");
      toolTip1.SetToolTip(this.but_save, "Сохранить программу");
      toolTip1.SetToolTip(this.but_close, "Закрыть форму");
      toolTip1.SetToolTip(this.label1, "Начальная высота, с которой начинается сверление");
      toolTip1.SetToolTip(this.label2, "Глубина сверления на шаге");
      toolTip1.SetToolTip(this.label3, "Недоход сверления на шаге");
      toolTip1.SetToolTip(this.label4, "Общая глубина сверления");
      toolTip1.SetToolTip(this.label5, "Координаты сверления в формате:\r\n X0 Y0\r\nили:\r\n N0 X0 Y0");
      toolTip1.SetToolTip(this.label6, "Диаметр отверстия сверления");
      toolTip1.SetToolTip(this.label7, "Высота отвода инструмента в конце цикла сверления");
      toolTip1.SetToolTip(this.label8, "Высота подвода инструмента в начале цикла сверления");
      toolTip1.SetToolTip(this.label9, "Величина подачи сверления");
      toolTip1.SetToolTip(this.label10, "Величина оборотов шпинделя");
      toolTip1.SetToolTip(this.label11, "Начальный блок программы\r\nПараметры задавать в формате [Param]\r\nЗначение параметров смотри в подписи полей");
      toolTip1.SetToolTip(this.label12, "Конечный блок программы\r\nПараметры задавать в формате [Param]\r\nЗначение параметров смотри в подписи полей");
      toolTip1.SetToolTip(this.label13, "Величина шага кадров программы");
      toolTip1.SetToolTip(this.label14, "Итоговый текст программы");
    }
  }
}
