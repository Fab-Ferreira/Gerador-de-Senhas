using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

//Código feito por Fabrício Prudente Ferreira (Fab-Ferreira)
namespace senhas
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		//Variáveis
		char[] alfaMai = {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};
		char[] alfaMin = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
		char[] num = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9'}, espec = {'*', '!', '@', '#', '$', '&', '%', ';', ':', '.', ',', '-', '_', '?', '/'};
		
		int randomLetra, randomNumber, randomEspec, randomCheck;
		string senhaResul;
		
		void CreateClick(object sender, EventArgs e)
		{
			decimal quantidade = quant.Value;
			
			//Random
			Random rand = new Random();
			
			//Sempre limpar a variável após clicar no botão
			senhaResul = "";
			
			//Se nenhuma CheckBox estiver marcada
			if(checkMaius.Checked == false && checkMinus.Checked == false && checkEspec.Checked == false && checkNumber.Checked == false)
			{
				MessageBox.Show("Assinale alguma das opções para que seja possível gerar sua senha.");
			}
			else
			{				
				for(int i = 1; i <= quant.Value; i++)
				{
					//Valor aleatório de randomCheck entre 0 e 3
					randomCheck = rand.Next(0, 4);
					
					randomLetra = rand.Next(0, 26); //Valor aleatório de randomLetra entre 0 e 25
					randomNumber = rand.Next(0, 10); //Valor aleatório de randomNumber entre 0 e 9
					randomEspec = rand.Next(0, 15); //Valor aleatório de randomEspec entre 0 e 14
					
					switch(randomCheck)
					{
						case 0: //Se randomCheck for igual à 0
							if(checkEspec.Checked)
							{
								senhaResul += espec[randomEspec];
							}
							else
							{
								i--;
							}
							break;
						
						case 1: //Se randomCheck for igual à 1
							if(checkNumber.Checked)
							{
								senhaResul += num[randomNumber];
							}
							else
							{
								i--;
							}
							break;
							
						case 2: //Se randomCheck for igual à 2
							if(checkMaius.Checked)
							{
								senhaResul += alfaMai[randomLetra];
							}
							else
							{
								i--;
							}
							break;
						
						case 3: //Se randomCheck for igual à 3
							if(checkMinus.Checked)
							{
								senhaResul += alfaMin[randomLetra];
							}
							else
							{
								i--;
							}
							break;
					}
				}
				password.Text = senhaResul; //Label "password" vai receber o texto formado em "senhaResul"
			}
		}
	}
}
