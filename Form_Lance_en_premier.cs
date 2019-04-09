using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Alimentation_Eleve
{
    public partial class Form_Lance_en_premier : Form
    {
        Enseignant unEnseignant;

        public Form_Lance_en_premier()
        {
            InitializeComponent();
            btn_connexion.Click += new EventHandler(btn_connexion_Click);
        }

        void btn_connexion_Click(object sender, EventArgs e)
        {
            if (tb_login.Text != "" && tb_mdp.Text != "")
            {
                TableEnseignant selectEn = new TableEnseignant();
                Enseignant unEnseignant2;

                unEnseignant2 = selectEn.GetByLogin(tb_login.Text, tb_mdp.Text);

                if(unEnseignant2.
            }
        }
    }
}
