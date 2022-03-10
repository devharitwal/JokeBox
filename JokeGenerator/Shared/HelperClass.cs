using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JokeGenerator.Shared
{
	public static class HelperClass
	{

		private static  readonly string baseurl = "https://reqres.in/api/users/";
		public static async Task<String> GetJoke()
		{

			Random rd= new Random();

			int id = rd.Next(10);

			using (HttpClient httpClient = new HttpClient())
			{
				using (HttpResponseMessage res= await httpClient.GetAsync(baseurl + id))
				{
					using ( HttpContent content = res.Content)

					{
						string data = await content.ReadAsStringAsync();	
						if(data != null)
						{
							return data; 
						}
					}
				}

			}


			return string.Empty;

		}
				 

	}
}
