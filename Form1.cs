using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void UpBtn_Click(object sender, EventArgs e)
        {
            Mover.MoveUp();       
        }

        private void DownBtn_Click(object sender, EventArgs e)
        {
            Mover.MoveDown();
        }

        private void LeftBtn_Click(object sender, EventArgs e)
        {
            Mover.MoveLeft();
        }

        private void RigthBtn_Click(object sender, EventArgs e)
        {
            Mover.MoveRigth();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List.Items.Clear();
        }

        private void Mover_OnMoveDown(object sender, EventArgs e)
        {
            List.Items.Add("Круг сместился вниз");
        }

        private void Mover_OnMoveleft(object sender, EventArgs e)
        {
            List.Items.Add("Круг сместился влево");
        }

        private void Mover_OnMoveRigth(object sender, EventArgs e)
        {
            List.Items.Add("Круг сместился вправо");
        }

        private void Mover_OnMoveUp(object sender, EventArgs e)
        {
            List.Items.Add("Круг сместился вверх");
        }
    }
}
