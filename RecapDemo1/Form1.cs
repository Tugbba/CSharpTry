using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Button button = new Button();
            //button.Width = 50;
            //button.Height = 50;
            //this.Controls.Add(button);  // butonu ekranda göster demek.
            //Dama yapacağız 8e 8 olacak şekilde 64 buton olacak bunu tek tek yazmak yerine bir array yapacağız.

            GenerateButtons();

        }

        private void GenerateButtons()
        {
            Button[,] buttons = new Button[9, 9];
            int top = 0;
            int left = 0;
            for (int i = 0; i < buttons.GetUpperBound(0); i++)
            {
                for (int j = 0; j < buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Left = left;
                    buttons[i, j].Top = top; //Her bir butonu yukarıdan 50 karakter boşluk olacak şekilde yerleştir demek.
                    left += 50;  //Her bir butonu soldan 50 karakter kaydır. Böylelikle butonlar yan yana dizilcek fakat biz 8 satır 8 sütun olsun istiyoruz.
                    if ((i + j) % 2 == 0)
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White;
                    }
                    this.Controls.Add(buttons[i, j]);
                }
                top += 50;
                left = 0;
            }
        }
    }
}
