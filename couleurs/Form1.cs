using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class couleurtexte : Form
    {
        public couleurtexte()
        {
            InitializeComponent();
        }

            string max;
            string min;

        private void Form1_Load(object sender, EventArgs e)
        {
            brcrouge.Tag = Color.Red;
            brcblanc.Tag = Color.White;
            brcNoir.Tag = Color.Black;
            affichage.ForeColor = Color.Black;
            
            
          
        }



        private void texte_TextChanged(object sender, EventArgs e)
        {
            listechoix.Enabled = (texte.Text != "") ? true : false;
            affichage.Visible= (listechoix.Enabled == true) ?  true :  false;
            affichage.Text = texte.Text;
            
            
        }
           


        private void checkboxfond_CheckedChanged(object sender, EventArgs e)
        {
         listefond.Visible = (checkboxfond.Checked==true) ?  true :  false;
          
            if (checkboxfond.Checked == false)
          {
              affichage.BackColor = Color.White;
          }

            
            
        }



        private void checkboxcarac_CheckedChanged(object sender, EventArgs e)
        {
            listecoulcarc.Visible = (checkboxcarac.Checked == true) ? true : false;

            if (checkboxcarac.Checked == false)
            {
                affichage.ForeColor = Color.Black;
            }
        
        }



        private void checkboxcasse_CheckedChanged(object sender, EventArgs e)
        {
           listecasse.Visible = (checkboxcasse.Checked==true)?  true : false;

           if (checkboxcasse.Checked == false)
           {
               affichage.Text = texte.Text;
           }

        }



        private void brfondrouge_CheckedChanged(object sender, EventArgs e)
        {
            
            if (brfondrouge.Checked == true)
            {
                affichage.BackColor = Color.Red;
            }
        }



        private void brfondvert_CheckedChanged(object sender, EventArgs e)
        {
           
            if (brfondvert.Checked == true)
            {
                affichage.BackColor = Color.Green;
            }
        }



        private void brfondbleu_CheckedChanged(object sender, EventArgs e)
        {
            
            if (brfondbleu.Checked == true)
            {
                affichage.BackColor = Color.Blue;
            }
        }



        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            affichage.Enabled = true;
            if (checkboxfond.Checked == true)
            {
                brfondvert_CheckedChanged(sender, e);
                brfondrouge_CheckedChanged(sender, e);
                brfondbleu_CheckedChanged(sender, e);
            }
            texte_TextChanged(sender, e);

            
                if (checkboxcarac.Checked == true)
                {
                    brcc_CheckedChanged(brcrouge, e);
                    brcc_CheckedChanged(brcblanc, e);
                    brcc_CheckedChanged(brcNoir, e);
                }
            

            if (checkboxcasse.Checked == true && brmaj.Checked == true)
            {
                affichage.Text = max;
            }

            else if (checkboxcasse.Checked == true && brmin.Checked == true)
            {
                affichage.Text = min;
            }
        }



        private void brcc_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton r = sender as RadioButton;
            Color c;

            try
            {
                c = (Color)r.Tag;
            }
            catch (NullReferenceException ex)
            {
                c = Color.Black;
            }
                

                if (r.Checked == true)
                {
                    affichage.ForeColor = c;
                }

              
            
        }


        private void casse_CheckedChanged(object sender, EventArgs e)
        {
          
            
            RadioButton r = sender as RadioButton;
            if (r != null)
            {

                if (r.Text == "Minuscule")
                {
                    min = texte.Text;
                    min = min.ToLower();
                    affichage.Text = min;
                }

                else if (r.Text == "Majuscule")
                {
                    max = texte.Text;
                    max = max.ToUpper();
                    affichage.Text = max;
                }
            }

        }

        


    }
}
