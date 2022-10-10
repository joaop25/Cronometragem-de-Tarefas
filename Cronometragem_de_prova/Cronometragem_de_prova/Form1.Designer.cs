
namespace Cronometragem_de_prova
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lista_concorrentes = new System.Windows.Forms.ListBox();
            this.lista_classificacao = new System.Windows.Forms.ListBox();
            this.label_cronometro = new System.Windows.Forms.Label();
            this.cmd_stop = new System.Windows.Forms.Button();
            this.cmd_start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lista_concorrentes
            // 
            this.lista_concorrentes.FormattingEnabled = true;
            this.lista_concorrentes.ItemHeight = 15;
            this.lista_concorrentes.Location = new System.Drawing.Point(12, 12);
            this.lista_concorrentes.Name = "lista_concorrentes";
            this.lista_concorrentes.Size = new System.Drawing.Size(208, 244);
            this.lista_concorrentes.TabIndex = 0;
            this.lista_concorrentes.DoubleClick += new System.EventHandler(this.lista_concorrentes_DoubleClick);
            // 
            // lista_classificacao
            // 
            this.lista_classificacao.FormattingEnabled = true;
            this.lista_classificacao.ItemHeight = 15;
            this.lista_classificacao.Location = new System.Drawing.Point(509, 12);
            this.lista_classificacao.Name = "lista_classificacao";
            this.lista_classificacao.Size = new System.Drawing.Size(208, 244);
            this.lista_classificacao.TabIndex = 0;
            // 
            // label_cronometro
            // 
            this.label_cronometro.AutoSize = true;
            this.label_cronometro.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_cronometro.Location = new System.Drawing.Point(283, 154);
            this.label_cronometro.Name = "label_cronometro";
            this.label_cronometro.Size = new System.Drawing.Size(150, 37);
            this.label_cronometro.TabIndex = 1;
            this.label_cronometro.Text = "00:00:00.0";
            this.label_cronometro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmd_stop
            // 
            this.cmd_stop.Location = new System.Drawing.Point(262, 224);
            this.cmd_stop.Name = "cmd_stop";
            this.cmd_stop.Size = new System.Drawing.Size(85, 32);
            this.cmd_stop.TabIndex = 2;
            this.cmd_stop.Text = "Stop";
            this.cmd_stop.UseVisualStyleBackColor = true;
            this.cmd_stop.Click += new System.EventHandler(this.cmd_stop_Click);
            // 
            // cmd_start
            // 
            this.cmd_start.Location = new System.Drawing.Point(370, 224);
            this.cmd_start.Name = "cmd_start";
            this.cmd_start.Size = new System.Drawing.Size(85, 32);
            this.cmd_start.TabIndex = 2;
            this.cmd_start.Text = "Start";
            this.cmd_start.UseVisualStyleBackColor = true;
            this.cmd_start.Click += new System.EventHandler(this.cmd_start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 284);
            this.Controls.Add(this.cmd_start);
            this.Controls.Add(this.cmd_stop);
            this.Controls.Add(this.label_cronometro);
            this.Controls.Add(this.lista_classificacao);
            this.Controls.Add(this.lista_concorrentes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lista_concorrentes;
        private System.Windows.Forms.ListBox lista_classificacao;
        private System.Windows.Forms.Label label_cronometro;
        private System.Windows.Forms.Button cmd_stop;
        private System.Windows.Forms.Button cmd_start;
    }
}

