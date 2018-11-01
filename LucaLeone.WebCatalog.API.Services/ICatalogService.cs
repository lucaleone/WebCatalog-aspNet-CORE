﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LucaLeone.WebCatalog.API.DTO;

namespace LucaLeone.WebCatalog.API.Services
{
    public interface ICatalogService
    {
        Task<ProductDto> GetProduct(Guid id);
        Task<IEnumerable<ProductDto>> GetCatalogPageAsync(int page, int maxNumElem);
        Task<IEnumerable<ProductDto>> SearchProductsAsync(SearchDto search);
        Task<ProductDto> AddProductAsync(ProductDto newProduct);
        Task<ProductDto> EditProductAsync(Guid id, ProductDto newProduct);
        Task<ProductDto> DeleteProductAsync(Guid id);
        Task<bool> InitDb();
        Task<bool> EraseDb();
    }
}