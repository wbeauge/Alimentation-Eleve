namespace Alimentation_Eleve
{
    partial class Form_Lance_en_premier
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_login = new System.Windows.Forms.Label();
            this.lb_mdp = new System.Windows.Forms.Label();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.tb_mdp = new System.Windows.Forms.TextBox();
            this.btn_connexion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_login
            // 
            this.lb_login.AutoSize = true;
            this.lb_login.Location = new System.Drawing.Point(12, 22);
            this.lb_login.Name = "lb_login";
            this.lb_login.Size = new System.Drawing.Size(42, 13);
            this.lb_login.TabIndex = 0;
            this.lb_login.Text = "Login : ";
            // 
            // lb_mdp
            // 
            this.lb_mdp.AutoSize = true;
            this.lb_mdp.Location = new System.Drawing.Point(12, 75);
            this.lb_mdp.Name = "lb_mdp";
            this.lb_mdp.Size = new System.Drawing.Size(77, 13);
            this.lb_mdp.TabIndex = 1;
            this.lb_mdp.Text = "Mot de passe :";
            // 
            // tb_login
            // 
            this.tb_login.Location = new System.Drawing.Point(127, 19);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(120, 20);
            this.tb_login.TabIndex = 2;
            // 
            // tb_mdp
            // 
            this.tb_mdp.Location = new System.Drawing.Point(127, 72);
            this.tb_mdp.Name = "tb_mdp";
            this.tb_mdp.Size = new System.Drawing.Size(120, 20);
            this.tb_mdp.TabIndex = 3;
            // 
            // btn_connexion
            // 
            this.btn_connexion.Location = new System.Drawing.Point(100, 131);
            this.btn_connexion.Name = "btn_connexion";
            this.btn_connexion.Size = new System.Drawing.Size(81, 28);
            this.btn_connexion.TabIndex = 4;
            this.btn_connexion.Text = "Connexion";
            this.btn_connexion.UseVisualStyleBackColor = true;
            // 
            // Form_Lance_en_premier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 171);
            this.Controls.Add(this.btn_connexion);
            this.Controls.Add(this.tb_mdp);
            this.Controls.Add(this.tb_login);
            this.Controls.Add(this.lb_mdp);
            this.Controls.Add(this.lb_login);
            this.Name = "Form_Lance_en_premier";
            this.Text = "Form_Lance_en_premier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_login;
        private System.Windows.Forms.Label lb_mdp;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.TextBox tb_mdp;
        private System.Windows.Forms.Button btn_connexion;
    }
}