using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Worldle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        string wanted_word;
        string first_letter;
        string second_letter;
        string third_letter;
        string fourth_letter;
        string fifth_letter;

        StreamReader sr = new StreamReader("words.txt");
        List<string> words = new List<string>();
        private void Form1_Load(object sender, EventArgs e)
        {
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                words.Add(line);
            }

            groupBox1.Enabled = false;
            max_lenght();
        }

        private void max_lenght()
        {
            richTextBox1.MaxLength = 1;
            richTextBox2.MaxLength = 1;
            richTextBox3.MaxLength = 1;
            richTextBox4.MaxLength = 1;
            richTextBox5.MaxLength = 1;

            richTextBox6.MaxLength = 1;
            richTextBox7.MaxLength = 1;
            richTextBox8.MaxLength = 1;
            richTextBox9.MaxLength = 1;
            richTextBox10.MaxLength = 1;

            richTextBox11.MaxLength = 1;
            richTextBox12.MaxLength = 1;
            richTextBox13.MaxLength = 1;
            richTextBox14.MaxLength = 1;
            richTextBox15.MaxLength = 1;

            richTextBox16.MaxLength = 1;
            richTextBox17.MaxLength = 1;
            richTextBox18.MaxLength = 1;
            richTextBox19.MaxLength = 1;
            richTextBox20.MaxLength = 1;

            richTextBox21.MaxLength = 1;
            richTextBox22.MaxLength = 1;
            richTextBox23.MaxLength = 1;
            richTextBox24.MaxLength = 1;
            richTextBox25.MaxLength = 1;

            richTextBox26.MaxLength = 1;
            richTextBox27.MaxLength = 1;
            richTextBox28.MaxLength = 1;
            richTextBox29.MaxLength = 1;
            richTextBox30.MaxLength = 1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            wanted_word = words[rnd.Next(1, 501)];
            label2.Text = wanted_word;
            label2.Visible = false;
            char[] splitter_wanted = wanted_word.ToCharArray();
            first_letter =Convert.ToString(splitter_wanted[0]);
            second_letter = Convert.ToString(splitter_wanted[1]);
            third_letter = Convert.ToString(splitter_wanted[2]);
            fourth_letter = Convert.ToString(splitter_wanted[3]);
            fifth_letter = Convert.ToString(splitter_wanted[4]);
            button1.Visible=false;
            button2.Visible = true;
            bacground_refresh();
            enable_letters();
            refresh_words();
            readonly_reset();
        }

        private void readonly_reset()
        {
            richTextBox1.ReadOnly = false;
            richTextBox2.ReadOnly = false;
            richTextBox3.ReadOnly = false;
            richTextBox4.ReadOnly = false;
            richTextBox5.ReadOnly = false;
            richTextBox6.ReadOnly = false;
            richTextBox7.ReadOnly = false;
            richTextBox8.ReadOnly = false;
            richTextBox9.ReadOnly = false;
            richTextBox10.ReadOnly = false;
            richTextBox11.ReadOnly = false;
            richTextBox12.ReadOnly = false;
            richTextBox13.ReadOnly = false;
            richTextBox14.ReadOnly = false;
            richTextBox15.ReadOnly = false;
            richTextBox16.ReadOnly = false;
            richTextBox17.ReadOnly = false;
            richTextBox18.ReadOnly = false;
            richTextBox19.ReadOnly = false;
            richTextBox20.ReadOnly = false;
            richTextBox21.ReadOnly = false;
            richTextBox22.ReadOnly = false;
            richTextBox23.ReadOnly = false;
            richTextBox24.ReadOnly = false;
            richTextBox25.ReadOnly = false;
            richTextBox26.ReadOnly = false;
            richTextBox27.ReadOnly = false;
            richTextBox28.ReadOnly = false;
            richTextBox29.ReadOnly = false;
            richTextBox30.ReadOnly = false;
        }

        private void enable_letters()
        {
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            groupBox3.Enabled = false;
            groupBox4.Enabled = false;
            groupBox5.Enabled = false;
            groupBox6.Enabled = false;
            groupBox7.Enabled = false;
        }

        private void refresh_words()
        {

          

            richTextBox1.Clear();
            richTextBox2.Clear();
            richTextBox3.Clear();
            richTextBox4.Clear();
            richTextBox5.Clear();

            richTextBox6.Clear();
            richTextBox7.Clear();
            richTextBox8.Clear();
            richTextBox9.Clear();
            richTextBox10.Clear();

            richTextBox11.Clear();
            richTextBox12.Clear();
            richTextBox13.Clear();
            richTextBox14.Clear();
            richTextBox15.Clear();

            richTextBox16.Clear();
            richTextBox17.Clear();
            richTextBox18.Clear();
            richTextBox19.Clear();
            richTextBox20.Clear();

            richTextBox21.Clear();
            richTextBox22.Clear();
            richTextBox23.Clear();
            richTextBox24.Clear();
            richTextBox25.Clear();

            richTextBox26.Clear();
            richTextBox27.Clear();
            richTextBox28.Clear();
            richTextBox29.Clear();
            richTextBox30.Clear();
        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
         
        }

        public string first_letter_finding(string text)
        {
            string result = "";
            if (text == first_letter)
            {
                result= "g";
                
            }
            else if (text == second_letter || text == third_letter || text== fourth_letter || text == fifth_letter)
            {
                result = "y";
            }
            return result;
        }

        public string second_letter_finding(string text)
        {
            string result = "";
            if (text == second_letter)
            {
                result = "g";

            }
            else if (text == first_letter ||text == third_letter || text == fourth_letter || text == fifth_letter)
            {
                result = "y";
            }
            return result;
        }

        public string third_letter_finding(string text)
        {
            string result = "";
            if (text == third_letter)
            {
                result = "g";

            }
            else if (text == second_letter ||text == first_letter || text == fourth_letter || text == fifth_letter)
            {
                result = "y";
            }
            return result;
        }
        public string fourth_letter_finding(string text)
        {
            string result = "";
            if (text == fourth_letter)
            {
                result = "g";

            }
            else if (text == second_letter || text == third_letter || text == first_letter ||text == fifth_letter)
            {
                result = "y";
            }
            return result;
        }
        public string fifth_letter_finding(string text)
        {
            string result = "";
            if (text == fifth_letter)
            {
                result = "g";

            }
            else if (text == second_letter || text == third_letter || text == fourth_letter ||text == first_letter)
            {
                result = "y";
            }
            return result;
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            line_one_check();
            
            if (groupBox2.Enabled==true&&groupBox3.Enabled==false&& groupBox4.Enabled == false&& groupBox5.Enabled == false&& groupBox6.Enabled == false&& groupBox7.Enabled == false)
            {
                if (richTextBox1.BackColor==Color.Green&& richTextBox2.BackColor == Color.Green&& richTextBox3.BackColor == Color.Green&& richTextBox4.BackColor == Color.Green&& richTextBox5.BackColor == Color.Green)
                {
                    
                    MessageBox.Show("You managed to figure it out!");
                    button2.Visible = false;
                    button1.Visible = true;
                }
                else
                {
                    richTextBox1.ReadOnly = true;
                    richTextBox2.ReadOnly = true;
                    richTextBox3.ReadOnly = true;
                    richTextBox4.ReadOnly = true;
                    richTextBox5.ReadOnly = true;
                    groupBox3.Enabled = true;
                }
                
                
            }
           else if (groupBox2.Enabled == true && groupBox3.Enabled == true && groupBox4.Enabled == false && groupBox5.Enabled == false && groupBox6.Enabled == false && groupBox7.Enabled == false)
            {
                line_two_check();
                if (richTextBox6.BackColor == Color.Green && richTextBox7.BackColor == Color.Green && richTextBox8.BackColor == Color.Green && richTextBox9.BackColor == Color.Green && richTextBox10.BackColor == Color.Green)
                {
                    MessageBox.Show("You managed to figure it out!");
                    button2.Visible = false;
                    button1.Visible = true;
                }
                else
                {
                    richTextBox6.ReadOnly = true;
                    richTextBox7.ReadOnly = true;
                    richTextBox8.ReadOnly = true;
                    richTextBox9.ReadOnly = true;
                    richTextBox10.ReadOnly = true;
                    groupBox4.Enabled = true;
                }
               
            }

          else  if (groupBox2.Enabled == true && groupBox3.Enabled == true && groupBox4.Enabled == true && groupBox5.Enabled == false && groupBox6.Enabled == false && groupBox7.Enabled == false)
            {
                line_three_check();
                if (richTextBox11.BackColor == Color.Green && richTextBox12.BackColor == Color.Green && richTextBox13.BackColor == Color.Green && richTextBox14.BackColor == Color.Green && richTextBox15.BackColor == Color.Green)
                {
                    MessageBox.Show("You managed to figure it out!");
                    button2.Visible = false;
                    button1.Visible = true;
                }
                else
                {
                    richTextBox11.ReadOnly = true;
                    richTextBox12.ReadOnly = true;
                    richTextBox13.ReadOnly = true;
                    richTextBox14.ReadOnly = true;
                    richTextBox15.ReadOnly = true;
                    groupBox5.Enabled = true;
                }
            }

            else if (groupBox2.Enabled == true && groupBox3.Enabled == true && groupBox4.Enabled == true && groupBox5.Enabled == true && groupBox6.Enabled == false && groupBox7.Enabled == false)
            {
                line_four_check();
                if (richTextBox16.BackColor == Color.Green && richTextBox17.BackColor == Color.Green && richTextBox18.BackColor == Color.Green && richTextBox19.BackColor == Color.Green && richTextBox20.BackColor == Color.Green)
                {
                    MessageBox.Show("You managed to figure it out!");
                    button2.Visible = false;
                    button1.Visible = true;
                }
                else
                {
                    richTextBox16.ReadOnly = true;
                    richTextBox17.ReadOnly = true;
                    richTextBox18.ReadOnly = true;
                    richTextBox19.ReadOnly = true;
                    richTextBox20.ReadOnly = true;
                    groupBox6.Enabled = true;
                }
            }

           else if (groupBox2.Enabled == true && groupBox3.Enabled == true && groupBox4.Enabled == true && groupBox5.Enabled == true && groupBox6.Enabled == true && groupBox7.Enabled == false)
            {
                line_five_check();
                if (richTextBox21.BackColor == Color.Green && richTextBox22.BackColor == Color.Green && richTextBox23.BackColor == Color.Green && richTextBox24.BackColor == Color.Green && richTextBox25.BackColor == Color.Green)
                {
                    MessageBox.Show("You managed to figure it out!");
                    button2.Visible = false;
                    button1.Visible = true;
                }
                else
                {
                    richTextBox21.ReadOnly = true;
                    richTextBox22.ReadOnly = true;
                    richTextBox23.ReadOnly = true;
                    richTextBox24.ReadOnly = true;
                    richTextBox25.ReadOnly = true;
                    groupBox7.Enabled = true;
                }
            }

           else if (groupBox2.Enabled == true && groupBox3.Enabled == true && groupBox4.Enabled == true && groupBox5.Enabled == true && groupBox6.Enabled == true && groupBox7.Enabled == true)
            {
                line_six_check();
                if (richTextBox26.BackColor == Color.Green && richTextBox27.BackColor == Color.Green && richTextBox28.BackColor == Color.Green && richTextBox29.BackColor == Color.Green && richTextBox30.BackColor == Color.Green)
                {
                    MessageBox.Show("You managed to figure it out!");
                    button2.Visible = false;
                    button1.Visible = true;
                }
                else
                {
                    MessageBox.Show("You lose! Try again!");
                    button2.Visible = false;
                    button1.Visible = true;
                }
                richTextBox26.ReadOnly = true;
                richTextBox27.ReadOnly = true;
                richTextBox28.ReadOnly = true;
                richTextBox29.ReadOnly = true;
                richTextBox30.ReadOnly = true;
            }
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void bacground_refresh() {
            richTextBox1.BackColor = Color.White;
            richTextBox2.BackColor = Color.White;
            richTextBox3.BackColor = Color.White;
            richTextBox4.BackColor = Color.White;
            richTextBox5.BackColor = Color.White;

            richTextBox6.BackColor = Color.White;
            richTextBox7.BackColor = Color.White;
            richTextBox8.BackColor = Color.White;
            richTextBox9.BackColor = Color.White;
            richTextBox10.BackColor = Color.White;

            richTextBox11.BackColor = Color.White;
            richTextBox12.BackColor = Color.White;
            richTextBox13.BackColor = Color.White;
            richTextBox14.BackColor = Color.White;
            richTextBox15.BackColor = Color.White;

            richTextBox16.BackColor = Color.White;
            richTextBox17.BackColor = Color.White;
            richTextBox18.BackColor = Color.White;
            richTextBox19.BackColor = Color.White;
            richTextBox20.BackColor = Color.White;

            richTextBox21.BackColor = Color.White;
            richTextBox22.BackColor = Color.White;
            richTextBox23.BackColor = Color.White;
            richTextBox24.BackColor = Color.White;
            richTextBox25.BackColor = Color.White;

            richTextBox26.BackColor = Color.White;
            richTextBox27.BackColor = Color.White;
            richTextBox28.BackColor = Color.White;
            richTextBox29.BackColor = Color.White;
            richTextBox30.BackColor = Color.White;

          
        }

        private void line_one_check() {
            //first letter
            string result = first_letter_finding(richTextBox1.Text);
            if (result == "g")
            {
                richTextBox1.BackColor = Color.Green;
            }
            if (result == "y")
            {
                richTextBox1.BackColor = Color.Yellow;

            }
            //second letter
            string result_two = second_letter_finding(richTextBox2.Text);
            if (result_two == "g")
            {
                richTextBox2.BackColor = Color.Green;
            }
            if (result_two == "y")
            {
                richTextBox2.BackColor = Color.Yellow;

            }

            string result_three = third_letter_finding(richTextBox3.Text);
            if (result_three == "g")
            {
                richTextBox3.BackColor = Color.Green;
            }
            if (result_three == "y")
            {
                richTextBox3.BackColor = Color.Yellow;

            }

            string result_four = fourth_letter_finding(richTextBox4.Text);
            if (result_four == "g")
            {
                richTextBox4.BackColor = Color.Green;
            }
            if (result_four == "y")
            {
                richTextBox4.BackColor = Color.Yellow;

            }

            string result_five = fifth_letter_finding(richTextBox5.Text);
            if (result_five == "g")
            {
                richTextBox5.BackColor = Color.Green;
            }
            if (result_five == "y")
            {
                richTextBox5.BackColor = Color.Yellow;

            }

        }
        private void line_two_check()
        {
            //first letter
            string result = first_letter_finding(richTextBox10.Text);
            if (result == "g")
            {
                richTextBox10.BackColor = Color.Green;
            }
            if (result == "y")
            {
                richTextBox10.BackColor = Color.Yellow;

            }
            //second letter
            string result_two = second_letter_finding(richTextBox9.Text);
            if (result_two == "g")
            {
                richTextBox9.BackColor = Color.Green;
            }
            if (result_two == "y")
            {
                richTextBox9.BackColor = Color.Yellow;

            }

            string result_three = third_letter_finding(richTextBox8.Text);
            if (result_three == "g")
            {
                richTextBox8.BackColor = Color.Green;
            }
            if (result_three == "y")
            {
                richTextBox8.BackColor = Color.Yellow;

            }

            string result_four = fourth_letter_finding(richTextBox7.Text);
            if (result_four == "g")
            {
                richTextBox7.BackColor = Color.Green;
            }
            if (result_four == "y")
            {
                richTextBox7.BackColor = Color.Yellow;

            }

            string result_five = fifth_letter_finding(richTextBox6.Text);
            if (result_five == "g")
            {
                richTextBox6.BackColor = Color.Green;
            }
            if (result_five == "y")
            {
                richTextBox6.BackColor = Color.Yellow;

            }

        }

        private void line_three_check()
        {
            //first letter
            string result = first_letter_finding(richTextBox15.Text);
            if (result == "g")
            {
                richTextBox15.BackColor = Color.Green;
            }
            if (result == "y")
            {
                richTextBox15.BackColor = Color.Yellow;

            }
            //second letter
            string result_two = second_letter_finding(richTextBox14.Text);
            if (result_two == "g")
            {
                richTextBox14.BackColor = Color.Green;
            }
            if (result_two == "y")
            {
                richTextBox14.BackColor = Color.Yellow;

            }

            string result_three = third_letter_finding(richTextBox13.Text);
            if (result_three == "g")
            {
                richTextBox13.BackColor = Color.Green;
            }
            if (result_three == "y")
            {
                richTextBox13.BackColor = Color.Yellow;

            }

            string result_four = fourth_letter_finding(richTextBox12.Text);
            if (result_four == "g")
            {
                richTextBox12.BackColor = Color.Green;
            }
            if (result_four == "y")
            {
                richTextBox12.BackColor = Color.Yellow;

            }

            string result_five = fifth_letter_finding(richTextBox11.Text);
            if (result_five == "g")
            {
                richTextBox11.BackColor = Color.Green;
            }
            if (result_five == "y")
            {
                richTextBox11.BackColor = Color.Yellow;

            }

        }

        private void line_four_check()
        {
            //first letter
            string result = first_letter_finding(richTextBox20.Text);
            if (result == "g")
            {
                richTextBox20.BackColor = Color.Green;
            }
            if (result == "y")
            {
                richTextBox20.BackColor = Color.Yellow;

            }
            //second letter
            string result_two = second_letter_finding(richTextBox19.Text);
            if (result_two == "g")
            {
                richTextBox19.BackColor = Color.Green;
            }
            if (result_two == "y")
            {
                richTextBox19.BackColor = Color.Yellow;

            }

            string result_three = third_letter_finding(richTextBox18.Text);
            if (result_three == "g")
            {
                richTextBox18.BackColor = Color.Green;
            }
            if (result_three == "y")
            {
                richTextBox18.BackColor = Color.Yellow;

            }

            string result_four = fourth_letter_finding(richTextBox17.Text);
            if (result_four == "g")
            {
                richTextBox17.BackColor = Color.Green;
            }
            if (result_four == "y")
            {
                richTextBox17.BackColor = Color.Yellow;

            }

            string result_five = fifth_letter_finding(richTextBox16.Text);
            if (result_five == "g")
            {
                richTextBox16.BackColor = Color.Green;
            }
            if (result_five == "y")
            {
                richTextBox16.BackColor = Color.Yellow;

            }

        }

        private void line_five_check()
        {
            //first letter
            string result = first_letter_finding(richTextBox25.Text);
            if (result == "g")
            {
                richTextBox25.BackColor = Color.Green;
            }
            if (result == "y")
            {
                richTextBox25.BackColor = Color.Yellow;

            }
            //second letter
            string result_two = second_letter_finding(richTextBox24.Text);
            if (result_two == "g")
            {
                richTextBox24.BackColor = Color.Green;
            }
            if (result_two == "y")
            {
                richTextBox24.BackColor = Color.Yellow;

            }

            string result_three = third_letter_finding(richTextBox23.Text);
            if (result_three == "g")
            {
                richTextBox23.BackColor = Color.Green;
            }
            if (result_three == "y")
            {
                richTextBox23.BackColor = Color.Yellow;

            }

            string result_four = fourth_letter_finding(richTextBox22.Text);
            if (result_four == "g")
            {
                richTextBox22.BackColor = Color.Green;
            }
            if (result_four == "y")
            {
                richTextBox22.BackColor = Color.Yellow;

            }

            string result_five = fifth_letter_finding(richTextBox21.Text);
            if (result_five == "g")
            {
                richTextBox21.BackColor = Color.Green;
            }
            if (result_five == "y")
            {
                richTextBox21.BackColor = Color.Yellow;

            }

        }
        private void line_six_check()
        {
            //first letter
            string result = first_letter_finding(richTextBox30.Text);
            if (result == "g")
            {
                richTextBox30.BackColor = Color.Green;
            }
            if (result == "y")
            {
                richTextBox30.BackColor = Color.Yellow;

            }
            //second letter
            string result_two = second_letter_finding(richTextBox29.Text);
            if (result_two == "g")
            {
                richTextBox29.BackColor = Color.Green;
            }
            if (result_two == "y")
            {
                richTextBox29.BackColor = Color.Yellow;

            }

            string result_three = third_letter_finding(richTextBox28.Text);
            if (result_three == "g")
            {
                richTextBox28.BackColor = Color.Green;
            }
            if (result_three == "y")
            {
                richTextBox28.BackColor = Color.Yellow;

            }

            string result_four = fourth_letter_finding(richTextBox27.Text);
            if (result_four == "g")
            {
                richTextBox27.BackColor = Color.Green;
            }
            if (result_four == "y")
            {
                richTextBox27.BackColor = Color.Yellow;

            }

            string result_five = fifth_letter_finding(richTextBox26.Text);
            if (result_five == "g")
            {
                richTextBox26.BackColor = Color.Green;
            }
            if (result_five == "y")
            {
                richTextBox26.BackColor = Color.Yellow;

            }

        }

        private void Form1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
