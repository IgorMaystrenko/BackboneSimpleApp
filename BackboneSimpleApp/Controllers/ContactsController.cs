using BackboneSimpleApp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Http.Results;

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

        //// GET api/Contacts/5
        //[ResponseType(typeof(Contact))]
        //public IHttpActionResult GetContact(int id)
        //{
            
        //}

        //// PUT api/Contacts/5
        [AcceptVerbs("PUT")]
        public IHttpActionResult PutContact(int id, Contact contact)
        {
            return Ok();
        }

        // POST api/Contacts
        [ResponseType(typeof(Contact))]
        [AcceptVerbs("POST")]
        public IHttpActionResult PostContact(Contact contact)
        {
            return Ok();
        }

        // DELETE api/Contacts/5
        [ResponseType(typeof(Contact))]
        [AcceptVerbs("DELETE")]
        public IHttpActionResult DeleteContact(int id)
        {
            return Ok();
        }


    }
}