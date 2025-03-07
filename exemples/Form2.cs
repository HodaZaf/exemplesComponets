using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exemples
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printDocument1 = new PrintDocument(); //Iniciem el nostre component
            PrinterSettings printerSettings = new PrinterSettings(); //Fem una instancia d'una classe que gestiona la impressio
            printDocument1.PrinterSettings = printerSettings; //Els relacionem
            printDocument1.PrintPage += imprimir; //Relacionem el event print page amb el nostre personalizat
            printDocument1.Print(); //imprimeix
        }
        //creem el nostre metode de print personalizat amb els següents metodes
        private void imprimir(object sender, PrintPageEventArgs args)
        {
            Font printFont = new Font("Arial",12); //Creem una font que utilitzarem per la impresio

            //iniquem que volem imprimir un text
            //Introduim el text que volem imprimir, la font, el tipus de pizell que utilitzara i hem de especicar en quins llocs tenim permeos imprmir
            args.Graphics.DrawString("Has introduit el següent text: " + textBox1.Text, printFont, Brushes.Black, new RectangleF(10,10,2480,3508));
            args.Graphics.DrawString(textBox1.Text, printFont, Brushes.Black, new RectangleF(10, 20, 2480, 3508));
            //El rectangle conte quantre parametres, el primer indica el marge horizonatal, el segon indica el marge vertical, el tercer quanta distancia pot ocupar en sentit horizontalment i finalment el últim indica quanta distancia pot ocupar verticalment

        }
    }

}
