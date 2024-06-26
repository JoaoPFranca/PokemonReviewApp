﻿using PokemonReviewApp.Models;
using System.Diagnostics;

namespace PokemonReviewApp.Interfaces
{
    public interface ICountryRepository
    {
        ICollection<Country> GetCountries();
        Country GetCountry(int id);
        Country GetCountryByOwner(int ownerId);
        ICollection<Owner> GetOwnersByCountry(int countryId);
        bool CountryExists(int id);

        bool CreateCountry(Country country);
        bool UpdateCountry(Country country);

        bool DeleteCountry(Country country);
        bool Save();
    }
}
