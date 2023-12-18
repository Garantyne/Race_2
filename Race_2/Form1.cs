using Race_2.Entitis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Race_2
{
    public delegate int Run();
    public partial class Form1 : Form
    {
        public int X { get; set; } = 50;
        public int Y { get; set; } = 100;
        public Graphics gr;
        private Car[] cars;
        Run run;

        public Form1()
        {
            InitializeComponent();
            cars = new Car[4]{ new SportCar("Mustang",5),
                    new PasangerCar("Toyota",4),
                    new Buss("Man",2),
                    new Truck("Mersedess",3)
                    };
            
            run += cars[0].Run;
            run += cars[1].Run;
            run += cars[2].Run;
            run += cars[3].Run;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] arrBost = new int[4];
            int i = 0;
            foreach(Run v in run.GetInvocationList())
            {
                arrBost[i] = v();
                i++;
            }
            gr = CreateGraphics();
            Refresh();
            for(int j = 0; j <arrBost.Length; j++)
            {
                gr.DrawRectangle(Pens.Red, X+ arrBost[0], Y, 30, 20);
                gr.DrawRectangle(Pens.Black, X + arrBost[1], Y + 30, 30, 20);
                gr.DrawRectangle(Pens.Yellow, X + arrBost[2], Y + 60, 30, 20);
                gr.DrawRectangle(Pens.Green, X + arrBost[3], Y + 90, 30, 20);
            }
        }
    }
}
