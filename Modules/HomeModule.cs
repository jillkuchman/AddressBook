using Nancy;
using System.Collections.Generic;
using AddressBook.Objects;

namespace AddressBook
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>
      {
        List<Contact> allContacts = Contact.DisplayAll();

        return View["index.cshtml", allContacts];
      };

      Get["/deleteAll"] = _ =>

    }
  }
}
