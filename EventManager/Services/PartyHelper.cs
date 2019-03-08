using EventManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventManager.Services
{
    public class PartyHelper
    {
        public PartyHelper() { }
        public List<Parties> _filteredPartie = new List<Parties>();
        int listSize;
        //filtrar por universidade
        public async Task<List<Parties>> FilterPartieByUniversityAsync(List<Parties> Parties, string university)
        {
            listSize = Parties.Count;
            try
            {
                for (int count = 0; count < listSize; count++)
                {
                    if (Parties[count].university == university.ToUpper())
                    {
                        _filteredPartie.Add(Parties[count]);
                    }
                }
            }
            catch
            {
                //return "Error filtering parties";
            }

            return _filteredPartie;
        }
        //filtrar por curso
        public async Task<List<Parties>> FilterPartieByCourseAsync(List<Parties> Parties, string course)
        {
            listSize = Parties.Count;
            try
            {
                for (int count = 0; count < listSize; count++)
                {
                    if (Parties[count].course.ToUpper() == course.ToUpper())
                    {
                        _filteredPartie.Add(Parties[count]);
                    }
                }
            }
            catch
            {
                //return "Error filtering parties";
            }

            return _filteredPartie;
        }















    }

}