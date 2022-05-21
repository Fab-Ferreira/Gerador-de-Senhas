/*
 * Created by SharpDevelop.
 * User: fabri
 * Date: 20/05/2022
 * Time: 19:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace senhas
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.CheckBox checkMaius;
		private System.Windows.Forms.CheckBox checkEspec;
		private System.Windows.Forms.CheckBox checkNumber;
		private System.Windows.Forms.CheckBox checkMinus;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown quant;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label password;
		private System.Windows.Forms.Button create;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.checkMaius = new System.Windows.Forms.CheckBox();
			this.checkEspec = new System.Windows.Forms.CheckBox();
			this.checkNumber = new System.Windows.Forms.CheckBox();
			this.checkMinus = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.quant = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.password = new System.Windows.Forms.Label();
			this.create = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.quant)).BeginInit();
			this.SuspendLayout();
			// 
			// checkMaius
			// 
			this.checkMaius.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.checkMaius.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this.checkMaius.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkMaius.ForeColor = System.Drawing.Color.White;
			this.checkMaius.Location = new System.Drawing.Point(12, 110);
			this.checkMaius.Name = "checkMaius";
			this.checkMaius.Size = new System.Drawing.Size(288, 43);
			this.checkMaius.TabIndex = 0;
			this.checkMaius.Text = "Letras maiúsculas";
			this.checkMaius.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.checkMaius.UseVisualStyleBackColor = true;
			// 
			// checkEspec
			// 
			this.checkEspec.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.checkEspec.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this.checkEspec.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkEspec.ForeColor = System.Drawing.Color.White;
			this.checkEspec.Location = new System.Drawing.Point(12, 257);
			this.checkEspec.Name = "checkEspec";
			this.checkEspec.Size = new System.Drawing.Size(318, 43);
			this.checkEspec.TabIndex = 1;
			this.checkEspec.Text = "Caracteres especiais";
			this.checkEspec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.checkEspec.UseVisualStyleBackColor = true;
			// 
			// checkNumber
			// 
			this.checkNumber.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.checkNumber.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this.checkNumber.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkNumber.ForeColor = System.Drawing.Color.White;
			this.checkNumber.Location = new System.Drawing.Point(12, 208);
			this.checkNumber.Name = "checkNumber";
			this.checkNumber.Size = new System.Drawing.Size(161, 43);
			this.checkNumber.TabIndex = 2;
			this.checkNumber.Text = "Números";
			this.checkNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.checkNumber.UseVisualStyleBackColor = true;
			// 
			// checkMinus
			// 
			this.checkMinus.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.checkMinus.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
			this.checkMinus.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkMinus.ForeColor = System.Drawing.Color.White;
			this.checkMinus.Location = new System.Drawing.Point(12, 159);
			this.checkMinus.Name = "checkMinus";
			this.checkMinus.Size = new System.Drawing.Size(292, 43);
			this.checkMinus.TabIndex = 3;
			this.checkMinus.Text = "Letras minúsculas";
			this.checkMinus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.checkMinus.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(78, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(387, 33);
			this.label1.TabIndex = 4;
			this.label1.Text = "GERADOR DE SENHAS";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// quant
			// 
			this.quant.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.quant.Location = new System.Drawing.Point(377, 64);
			this.quant.Maximum = new decimal(new int[] {
			15,
			0,
			0,
			0});
			this.quant.Minimum = new decimal(new int[] {
			5,
			0,
			0,
			0});
			this.quant.Name = "quant";
			this.quant.ReadOnly = true;
			this.quant.Size = new System.Drawing.Size(131, 34);
			this.quant.TabIndex = 5;
			this.quant.Value = new decimal(new int[] {
			5,
			0,
			0,
			0});
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(12, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(341, 33);
			this.label2.TabIndex = 6;
			this.label2.Text = "Quantidade de caracteres:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(12, 318);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(216, 33);
			this.label3.TabIndex = 7;
			this.label3.Text = "Senha gerada:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// password
			// 
			this.password.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.password.ForeColor = System.Drawing.Color.White;
			this.password.Location = new System.Drawing.Point(216, 318);
			this.password.Name = "password";
			this.password.Size = new System.Drawing.Size(238, 33);
			this.password.TabIndex = 8;
			this.password.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// create
			// 
			this.create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
			this.create.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.create.ForeColor = System.Drawing.Color.White;
			this.create.Location = new System.Drawing.Point(377, 188);
			this.create.Name = "create";
			this.create.Size = new System.Drawing.Size(131, 80);
			this.create.TabIndex = 9;
			this.create.Text = "Gerar";
			this.create.UseVisualStyleBackColor = false;
			this.create.Click += new System.EventHandler(this.CreateClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
			this.ClientSize = new System.Drawing.Size(535, 374);
			this.Controls.Add(this.create);
			this.Controls.Add(this.password);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.quant);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.checkMinus);
			this.Controls.Add(this.checkNumber);
			this.Controls.Add(this.checkEspec);
			this.Controls.Add(this.checkMaius);
			this.Name = "MainForm";
			this.Text = "senhas";
			((System.ComponentModel.ISupportInitialize)(this.quant)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
