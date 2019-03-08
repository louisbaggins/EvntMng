using EventManager.Interface;
using EventManager.Models;
using RestEase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventManager.Services
{
    public class PartyService
    {
        IParty api = RestClient.For<IParty>("https://api.myjson.com");
        List<Parties> partySerializer;

        public async Task<List<Parties>> GetPartiesAsync()
        {
            partySerializer = await api.GetPartyBlocksByCityAsync();

            return partySerializer;
        }
    }
}
