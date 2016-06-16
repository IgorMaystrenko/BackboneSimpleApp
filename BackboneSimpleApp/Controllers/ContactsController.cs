using BackboneSimpleApp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Description;

namespace BackboneSimpleApp.Controllers
{
    public class ContactsController : ApiController
    {

        private List<Contact> contacts = new List<Contact>
        {
            new Contact { Id = 1001, Name = "Contact #1", Phone = "+1111111111111" },
            new Contact { Id = 1002, Name = "Contact #2", Phone = "+1111111111111" },
            new Contact { Id = 1003, Name = "Contact #3", Phone = "+1111111111111" },
            new Contact { Id = 1004, Name = "Contact #4", Phone = "+1111111111111" },
            new Contact { Id = 1005, Name = "Contact #5", Phone = "+1111111111111" }
        };

        // GET api/Contacts
        [AcceptVerbs("GET")]
        public IEnumerable<Contact>  GetContacts()
        {
            return contacts;
        }

        //// PUT api/Contacts/5
        [AcceptVerbs("PUT")]
        public IHttpActionResult PutContact(int id, Contact contact)
        {
            if (id <= 0)
            {
                // New element. Add random id and save it.
                contact.Id = contacts.Max(c => c.Id) + 1;
                contacts.Add(contact);

                return Ok(contact.Id);
            }

            // This element must be in collection.
            var oldContact = contacts.FirstOrDefault(c => c.Id == id);

            if (oldContact == null)
            {
                // There is no such element with this id
                return BadRequest("There is no such element with this id.");
            }

            oldContact.Name = contact.Name;
            oldContact.Phone = contact.Phone;

            return Ok();
        }

        // DELETE api/Contacts/5
        [ResponseType(typeof(Contact))]
        [AcceptVerbs("DELETE")]
        public IHttpActionResult DeleteContact(int id)
        {
            if (id <= 0)
            {
                return BadRequest("Wrong Id");
            }

            var contactToRemove = contacts.FirstOrDefault(c => c.Id == id);

            if (contactToRemove == null)
            {
                // There is no such element
                return BadRequest(string.Format("There is no element with this id = {0}", id));
            }

            contacts.Remove(contactToRemove);

            return Ok();
        }


    }
}