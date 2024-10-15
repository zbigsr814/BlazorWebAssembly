using BlazorWebAssembly.Models;

namespace BlazorWebAssembly.Pages
{
	public partial class Index
	{
		private bool DisplayEmail = false;
		private List<Contact> contacts;
		private Dictionary<string, object> MyTextboxAttributes = new Dictionary<string, object>()
		{
			{"disabled", "disabled"},
			{"Placeholder", "Contact name"},
			{"type", "text"}
		};

		protected override async Task OnInitializedAsync()
		{
			await Task.Delay(3000);
			contacts = new List<Contact>()
		{
			new Contact()
			{
				FirstName = "Adam",
				LastName = "Nowak",
				Email = "adam@mail.pl"
			},
			new Contact()
			{
				FirstName = "Jan",
				LastName = "Janek",
				Email = "Jan@mail.pl"
			},
			new Contact()
			{
				FirstName = "Kamil",
				LastName = "Nowak",
				Email = "Kamil@mail.pl"
			}
		};

			base.OnInitializedAsync();
		}
	}
}
