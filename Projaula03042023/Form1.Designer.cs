namespace Projaula03042023
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblValorA = new System.Windows.Forms.Label();
            this.txtValorA = new System.Windows.Forms.TextBox();
            this.txtValorB = new System.Windows.Forms.TextBox();
            this.lblValorB = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblValorC = new System.Windows.Forms.Label();
            this.txtValorC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblValorA
            // 
            this.lblValorA.AutoSize = true;
            this.lblValorA.Location = new System.Drawing.Point(31, 20);
            this.lblValorA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValorA.Name = "lblValorA";
            this.lblValorA.Size = new System.Drawing.Size(44, 13);
            this.lblValorA.TabIndex = 0;
            this.lblValorA.Text = "Valor A:";
            // 
            // txtValorA
            // 
            this.txtValorA.Location = new System.Drawing.Point(34, 35);
            this.txtValorA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtValorA.Name = "txtValorA";
            this.txtValorA.Size = new System.Drawing.Size(194, 20);
            this.txtValorA.TabIndex = 1;
            // 
            // txtValorB
            // 
            this.txtValorB.Location = new System.Drawing.Point(34, 92);
            this.txtValorB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtValorB.Name = "txtValorB";
            this.txtValorB.Size = new System.Drawing.Size(194, 20);
            this.txtValorB.TabIndex = 3;
            // 
            // lblValorB
            // 
            this.lblValorB.AutoSize = true;
            this.lblValorB.Location = new System.Drawing.Point(31, 77);
            this.lblValorB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValorB.Name = "lblValorB";
            this.lblValorB.Size = new System.Drawing.Size(44, 13);
            this.lblValorB.TabIndex = 2;
            this.lblValorB.Text = "Valor B:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(172, 204);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(56, 19);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblValorC
            // 
            this.lblValorC.AutoSize = true;
            this.lblValorC.Location = new System.Drawing.Point(34, 132);
            this.lblValorC.Name = "lblValorC";
            this.lblValorC.Size = new System.Drawing.Size(44, 13);
            this.lblValorC.TabIndex = 5;
            this.lblValorC.Text = "Valor C:";
            // 
            // txtValorC
            // 
            this.txtValorC.Location = new System.Drawing.Point(37, 149);
            this.txtValorC.Name = "txtValorC";
            this.txtValorC.Size = new System.Drawing.Size(191, 20);
            this.txtValorC.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 337);
            this.Controls.Add(this.txtValorC);
            this.Controls.Add(this.lblValorC);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtValorB);
            this.Controls.Add(this.lblValorB);
            this.Controls.Add(this.txtValorA);
            this.Controls.Add(this.lblValorA);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Calculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValorA;
        private System.Windows.Forms.TextBox txtValorA;
        private System.Windows.Forms.TextBox txtValorB;
        private System.Windows.Forms.Label lblValorB;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblValorC;
        private System.Windows.Forms.TextBox txtValorC;
    }
}

