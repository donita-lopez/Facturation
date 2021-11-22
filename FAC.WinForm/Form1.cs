using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FAC.WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Client c1 = new Client(1, "donita", "moi", "khfqel@gmail");
            Product p1 = new Product(1, "jhsdjd", "jqipjifffen", 15) { Quantité = 11 };
            Product p2 = new Product(2, "bjghke", "khjfhzj", 5) { Quantité = 9 };
            Product p3 = new Product(3, "bjkklke", "khjjhfhzj", 45) { Quantité = 98 };


            FactureSimple fs = new FactureSimple(1, c1);
            fs.TauxTva = 11;
            fs.TauxRemise = 24;

            fs.AddProduct(p1, p2, p3);
            Console.WriteLine(fs);
            Console.WriteLine("Montant de Remise");
            Console.WriteLine(fs.MontantRemise());


            Console.WriteLine("Montant TVA");
            Console.WriteLine(fs.MontantTva());

            Console.WriteLine("Montant Total");
            Console.WriteLine(fs.MontantPayer());
            this.reportViewer1.RefreshReport();

        }
    }
}
