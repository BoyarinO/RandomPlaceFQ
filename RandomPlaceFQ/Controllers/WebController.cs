using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RandomPlaceFQ.Models;
using System.Web.Script.Serialization;

namespace RandomPlaceFQ.Controllers
{
    public class WebController : ApiController
    {
        Venue venue = new Venue();
        // GET: api/Web
        public Venue GetRandom()
        {
            
            if (Venue.venues.Count>0)
            {
               //root = RootObject.objects[0];
                Random r = new Random();
                int count = Venue.venues.Count;
               // return root.response.groups[0].items[r.Next(count)].venue;
                return Venue.venues[r.Next(count)];
            }
            else return null;
            
        }

        // GET: api/Web/5
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/Web
        public void Post(RootObject response)
        {
            Venue.venues.Clear();
            if (response.response.groups[0].items !=null)
            {
                foreach (var item in response.response.groups[0].items)
                {
                    if (item.venue.rating > 7)
                    {
                        Venue.venues.Add(item.venue);
                    }
                }

            }
        }

        // PUT: api/Web/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Web/5
        public void Delete(int id)
        {
        }
    }
}
