/*
 * Created by SharpDevelop.
 * User: fjstavares
 * Date: 07/10/2024
 * Time: 11:12
 */
 
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Santander_InternetBanking_ExtratoBancario
{
	public partial class MainForm : Form
		
	{
		private static readonly  HttpClient cliente = new HttpClient();
		public MainForm()
		{
			InitializeComponent();
		}
		
	
	}
}
