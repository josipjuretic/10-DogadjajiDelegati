using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vsite.CSharp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            buttonDelete.Click += buttonDelete_Click;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        // TODO: Dodati metodu za obradu događaja (event handler) koji će onemogućiti tipku buttonDelete ako nema upisanog teksta u kontroli textBox, odnosno omogućiti kada je neki tekst upisan.
        private void textBox ()
        {
        buttonDelete.Enabled = TextBox.TextLenght = 0;

    }
        // TODO: Dodati metodu za obradu događaja koji će na pritisak tipke buttonDelete obrisati sadržaj kontrole textBox.

        private void ButtonDelete_Click(object sender, EventArgs e)
    {
        TextBox.Text =  string Empty;
    }


         // TODO: Dodati metodu za obradu događaja koji će na pritisak tipke buttonClose zatvoriti formu.

        private void buttonClose_click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
