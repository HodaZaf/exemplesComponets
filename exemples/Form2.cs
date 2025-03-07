using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Drawing.Text;

namespace exemples
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //Crearem instances dels objectes que necessitem
        private Font printFont; //Per gestionar el tipus de tipografia que utilitzarem
        private void button1_Click(object sender, EventArgs e)
        {
            //per evitar errors, introduirem els codi en try catch   
            try {
                //una vegada que comprobem que no dona error
                try
                {
                    printFont = new Font("Arial",12); //Introduim un tipus de font
                    printDocument1.PrintPage += new PrintPageEventHandler(this.imprimirMissatge);

                }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }catch(Exception ex) { //Sortida de error
                MessageBox.Show(ex.Message);
            }
        }

        private void imprimirMissatge(object sender, PrintPageEventArgs ev) //creem una funcio  que controla el document
        {
            float lines = 0; //cuantes lines per pagina
            lines = ev.MarginBounds.Height / printFont.Height; // calculem quantes lines necessitem per pagina

            //Calcular la posicio i els marges on s'imprimira
            float yPos = 0;
            float leftMargin = ev.MarginBounds.Left;
            float topMatgin = ev.MarginBounds.Top;


            String linea = textBox1.Text;//String per gurdar el text

            int count = 0; //contador
            while (count<lines && linea!=null) //Comprobar que no escribim mes lines que les lines per pagina, i comproba que no tenim un text null
            {
                yPos = topMatgin + (count * printFont.GetHeight(ev.Graphics)); //calcular quina distancia imprimeix
                ev.Graphics.DrawString(linea, printFont, Brushes.Black, leftMargin, yPos, new StringFormat()); //imprimeix la linea
                linea = null;
                count++; //conta
            }

            //en cas de que hi ha més lines
            ev.HasMorePages = linea != null;
        }
    }
}
