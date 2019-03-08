using EventManager.Models;
using RestEase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventManager.Interface
{
    public interface IParty
    {
        //[Get("/{id}")]
        //Task<List<Parties>> GetPartyBlocksByCityAsync(string id);

        [Get(@"https://api.myjson.com/bins/pt6a2")]
        Task<List<Parties>> GetPartyBlocksByCityAsync();
    }
}
