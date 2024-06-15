/*
 * Created by SharpDevelop.
 * User: Joel
 * Date: 13/06/2024
 * Time: 11:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace bandeiras
{
	class Program
	{
		public static void Main(string[] args)
		{
			char opt = '0';
			
			while(opt != 'x'){
				Console.Clear();
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine("					     Menu de bandeiras:");
				
				Console.WriteLine();
				Console.WriteLine("						1 - NÍGERIA");
				Console.WriteLine();
				Console.WriteLine("						2- COLOMBIA");
				Console.WriteLine();
				Console.WriteLine("						3 - POLÔNIA");
				Console.WriteLine();
				Console.WriteLine("						4 - SUÉCIA");
				Console.WriteLine();
				Console.Write("						X PARA SAIR ");
				Console.WriteLine();
				Console.WriteLine();
				Console.Write("					Escolha uma opção de bandeira: ");
				opt = Console.ReadKey().KeyChar;
				
				switch(opt){
					case '1':
						Nigeira();
						break;
					
					case '2':
						Colombia();
						break;
						
					case '3':
						Polonia();
						break;
						
					case '4':
						Suecia();
						break;
				}
			}
		}
		
		static void Nigeira(){
			Console.Clear();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
			Console.ForegroundColor = ConsoleColor.Black;
			Console.Write("█████████████████████████████████████");
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("Bandeira da Nígeria");
			Console.WriteLine();
			Console.WriteLine();
			
			for(int i = 0; i < 12; i++){
				Console.ForegroundColor = ConsoleColor.Black;
				Console.Write("██████████████████████████████");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.Write("███████████");
				Console.ForegroundColor = ConsoleColor.White;
				Console.Write("███████████");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("███████████");
				
			}
			
			Console.WriteLine();
			Console.WriteLine();
			Console.ForegroundColor = ConsoleColor.Black;
			Console.Write("████████████████████████████");
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.Write("Pressione qualquer tecla para voltar...");
			Console.ReadKey(true);
		}
		
		static void Colombia(){
			Console.Clear();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
			Console.ForegroundColor = ConsoleColor.Black;
			Console.Write("█████████████████████████████████████");
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("Bandeira da Colombia");
			Console.WriteLine();
			Console.WriteLine();
			
			for(int i = 0; i < 4; i++){
				Console.ForegroundColor = ConsoleColor.Black;
				Console.Write("██████████████████████████████");
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.Write("███████████");
				Console.Write("███████████");
				Console.WriteLine("███████████");
				
			}
			
			for(int i = 0; i < 2; i++){
				Console.ForegroundColor = ConsoleColor.Black;
				Console.Write("██████████████████████████████");
				Console.ForegroundColor = ConsoleColor.Blue;
				Console.Write("███████████");
				Console.Write("███████████");
				Console.WriteLine("███████████");
				
			}
			
			for(int i = 0; i < 2; i++){
				Console.ForegroundColor = ConsoleColor.Black;
				Console.Write("██████████████████████████████");
				Console.ForegroundColor = ConsoleColor.Red;
				Console.Write("███████████");
				Console.Write("███████████");
				Console.WriteLine("███████████");
				
			}
			
			Console.WriteLine();
			Console.WriteLine();
			Console.ForegroundColor = ConsoleColor.Black;
			Console.Write("████████████████████████████");
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.Write("Pressione qualquer tecla para voltar...");
			Console.ReadKey(true);
			
		}
		
		static void Polonia(){
			Console.Clear();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
			Console.ForegroundColor = ConsoleColor.Black;
			Console.Write("█████████████████████████████████████");
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("Bandeira da Polônia");
			Console.WriteLine();
			Console.WriteLine();
			
			
			for(int i = 0; i < 5; i++){
				Console.ForegroundColor = ConsoleColor.Black;
				Console.Write("██████████████████████████████");
				Console.ForegroundColor = ConsoleColor.White;
				Console.Write("███████████");
				Console.Write("███████████");
				Console.WriteLine("███████████");
				
			}
			
			for(int i = 0; i < 5; i++){
				Console.ForegroundColor = ConsoleColor.Black;
				Console.Write("██████████████████████████████");
				Console.ForegroundColor = ConsoleColor.Red;
				Console.Write("███████████");
				Console.Write("███████████");
				Console.WriteLine("███████████");
				
			}
			
			
			Console.WriteLine();
			Console.WriteLine();
			Console.ForegroundColor = ConsoleColor.Black;
			Console.Write("████████████████████████████");
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.Write("Pressione qualquer tecla para voltar...");
			Console.ReadKey(true);
		}
		
		static void Suecia(){
			Console.Clear();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
			Console.ForegroundColor = ConsoleColor.Black;
			Console.Write("█████████████████████████████████████");
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("Bandeira da Suécia");
			Console.WriteLine();
			Console.WriteLine();
			
			
			for(int i = 0; i < 5; i++){
				Console.ForegroundColor = ConsoleColor.Black;
				Console.Write("██████████████████████████████");
				Console.ForegroundColor = ConsoleColor.DarkBlue;
				Console.Write("███████████");
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.Write("█████");
				Console.ForegroundColor = ConsoleColor.DarkBlue;
				Console.WriteLine("██████████████████████");
				
			}
			
			for(int i = 0; i < 2; i++){
				Console.ForegroundColor = ConsoleColor.Black;
				Console.Write("██████████████████████████████");
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.WriteLine("██████████████████████████████████████");
			}
			
			for(int i = 0; i < 5; i++){
				Console.ForegroundColor = ConsoleColor.Black;
				Console.Write("██████████████████████████████");
				Console.ForegroundColor = ConsoleColor.DarkBlue;
				Console.Write("███████████");
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.Write("█████");
				Console.ForegroundColor = ConsoleColor.DarkBlue;
				Console.WriteLine("██████████████████████");
				
			}
			
			
			
			Console.WriteLine();
			Console.WriteLine();
			Console.ForegroundColor = ConsoleColor.Black;
			Console.Write("████████████████████████████");
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.Write("Pressione qualquer tecla para voltar...");
			Console.ReadKey(true);
			
		}
	}
}

