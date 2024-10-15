using BlazorWebAssembly.Models;

namespace BlazorWebAssembly
{
	public interface IContactService
	{
		List<Contact> GetContacts();
		void AddContact(Contact contact);
	}
}
