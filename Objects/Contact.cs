using System.Collections.Generic;

namespace AddressBook.Objects
{
  public class Contact
  {
   private string _firstN;
   private string _lastN;
   private long   _phone;
   private string _address;
   private static List<Contact> _instance = new List<Contact> {};
   private int _id;

   public Contact(string firstN, string lastN, long  phone, string address)
   {
     _firstN = firstN;
     _lastN = lastN;
     _phone = phone;
     _address = address;
     _instance.Add(this);
     _id = _instance.Count;
    }
