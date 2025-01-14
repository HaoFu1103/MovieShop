﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ApplicationCore.Models;

namespace ApplicationCore.ServiceInterfaces
{
    public interface IGenreService
    {
        Task<IEnumerable<GenreModel>> GetAllGenres();
        Task<GenreDetailsResponseModel> GetGenreDetails(int id);
    }
}
