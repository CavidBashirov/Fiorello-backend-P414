﻿using Fiorello_backend.Models;

namespace Fiorello_backend.Services.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllAsync();
    }
}
