using System.Net.Http;
using System;
using System.IO;
using System.Net;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace JokeGenerator
{
	public partial class Home : Form
	{
		public Home()
		{
			 

			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void btn_info_Click(object sender, EventArgs e)
		{


			lbl_joke.Text = "     @devharitwal ❤     ";
			

		}

		private void lbl_head_Click(object sender, EventArgs e)
		{
			lbl_joke.Text = "Jokes to the rescue....";
		}

		private void btn_mode_Click(object sender, EventArgs e)
		{
			

		}

		private async void btn_get_Click(object sender, EventArgs e)
		{

			// on click get the api response 

			//var response = JObject.Parse(await Shared.HelperClass.GetJoke());
			var jokes = new List<string> { "My daughter thinks I don't give her enough privacy.\nAt least that's what she wrote in her diary." , "What did Yoda say when he saw\n himself in 4K? HDMI","Why can't you trust an atom?\n Because they make up everything.", "Before the invention of the wheel… everything was a drag!", "What do you call it when Dwayne Johnson buys a cutting tool? Rock pay-for scissors.", "What do you call a man with a rubber toe? Roberto Or Nikki", "Do you remember that joke I told you about my spine? It was about a weak back!" , "When's the best time to go to the dentist? Tooth-hurtie!" , "What kind of dogs love car racing? Lap dogs!", "What do you call birds who stick together? Vel-crows.", "Today I gave my dead batteries away. They were free of charge." };

			Random rd = new Random();

			int index = rd.Next(jokes.Count);
			lbl_joke.Text =jokes[index];
			







		}

		private void lbl_joke_Click(object sender, EventArgs e)
		{

		}
	}
}