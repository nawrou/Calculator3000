using System;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
	public partial class Calculator3000 : Form
	{
		public Calculator3000()
		{
			InitializeComponent();
	    }
		// Ecran de calcul
		private void Form1_Load(object sender, EventArgs e)
		{
		}
		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{
			// historique
		}

		private void button10_Click(object sender, EventArgs e)
		{
			DisplayNumber.Addonstring("0");
			textBox1.Text = DisplayNumber.stringofnumber;
			DisplayNumber.number = true;
		}

		private void button11_Click(object sender, EventArgs e)
		{
			if (DisplayNumber.number == true)
			{
				DisplayNumber.Addonstring(".");
				textBox1.Text = DisplayNumber.stringofnumber;
				DisplayNumber.number = false;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			DisplayNumber.Addonstring("1");
			textBox1.Text = DisplayNumber.stringofnumber;
			DisplayNumber.number = true;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			DisplayNumber.Addonstring("2");
			textBox1.Text = DisplayNumber.stringofnumber;
			DisplayNumber.number = true;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			DisplayNumber.Addonstring("3");
			textBox1.Text = DisplayNumber.stringofnumber;
			DisplayNumber.number = true;
		}

		private void button6_Click(object sender, EventArgs e)
		{
			DisplayNumber.Addonstring("4");
			textBox1.Text = DisplayNumber.stringofnumber;
			DisplayNumber.number = true;
		}

		private void button5_Click(object sender, EventArgs e)
		{
			DisplayNumber.Addonstring("5");
			textBox1.Text = DisplayNumber.stringofnumber;
			DisplayNumber.number = true;
		}

		private void button4_Click(object sender, EventArgs e)
		{
			DisplayNumber.Addonstring("6");
			textBox1.Text = DisplayNumber.stringofnumber;
			DisplayNumber.number = true;
		}

		private void button9_Click(object sender, EventArgs e)
		{
			DisplayNumber.Addonstring("7");
			textBox1.Text = DisplayNumber.stringofnumber;
			DisplayNumber.number = true;
		}

		private void button8_Click(object sender, EventArgs e)
		{
			DisplayNumber.Addonstring("8");
			textBox1.Text = DisplayNumber.stringofnumber;
			DisplayNumber.number = true;
		}

		private void button7_Click(object sender, EventArgs e)
		{
			DisplayNumber.Addonstring("9");
			textBox1.Text = DisplayNumber.stringofnumber;
			DisplayNumber.number = true;
		}

		private void button12_Click(object sender, EventArgs e)
		{
			if (DisplayNumber.number == true)
			{
				DisplayNumber.Addonstring(" + ");
				textBox1.Text = DisplayNumber.stringofnumber;
				DisplayNumber.number = false;
			}
		}

		private void button13_Click(object sender, EventArgs e)
		{
			if (DisplayNumber.number == true)
			{
				DisplayNumber.Addonstring(" - ");
				textBox1.Text = DisplayNumber.stringofnumber;
				DisplayNumber.number = false;
			}
		}

		private void button14_Click(object sender, EventArgs e)
		{
			if (DisplayNumber.number == true)
			{
				DisplayNumber.Addonstring(" x ");
				textBox1.Text = DisplayNumber.stringofnumber;
				DisplayNumber.number = false;
			}
		}

		private void button15_Click(object sender, EventArgs e)
		{
			if (DisplayNumber.number == true)
			{
				DisplayNumber.Addonstring(" / ");
				textBox1.Text = DisplayNumber.stringofnumber;
				DisplayNumber.number = false;
			}
		}

		private void button17_Click(object sender, EventArgs e)
		{
			DisplayNumber.Suppstring();
			textBox1.Text = DisplayNumber.stringofnumber;
			DisplayNumber.number = true;
		}

		private void button18_Click(object sender, EventArgs e)
		{
			textBox1.Text = textBox2.Text + " " + textBox3.Text;
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{
			//login = admin
		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{
			//password = admin
		}
	}
}
