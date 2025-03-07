namespace exemples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Iniciem com un formulari modular el component, i una vegada que tanqui, retornarà un resultat
            //Primer comprobem que el boto que ha clickat l'usuari es el de OK
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                //Despres assignem el color al componet que volem, en aquest cas, en la nostra etiqueta
                label1.ForeColor = colorDialog1.Color;

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Tambe podem assignar un color al componet, d'aquesta manera, quan s'inice el componet, ja tindrà un color seleccionat que no sigui el negre
            colorDialog1.Color = Color.Red;

            //Alhora, tambe podem assignar el color a altres componets
            label1.ForeColor = colorDialog1.Color;
        }
    }
}
