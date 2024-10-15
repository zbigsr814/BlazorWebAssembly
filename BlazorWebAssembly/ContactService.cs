using BlazorWebAssembly.Models;

namespace BlazorWebAssembly
{
	public class ContactService : IContactService
	{
		public List<Contact> contacts = new List<Contact>();

		public List<Contact> GetContacts()
		{
			return contacts;
		}

		public void AddContact(Contact contact)
		{
			contacts.Add(contact);
		}
	}
}
