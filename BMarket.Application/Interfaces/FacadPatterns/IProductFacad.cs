using BMarket.Application.Services.Products.Commands.AddNewCategory;
using BMarket.Application.Services.Products.Commands.AddNewProduct;
using BMarket.Application.Services.Products.Queries.GetAllCategories;
using BMarket.Application.Services.Products.Queries.GetCategories;
using BMarket.Application.Services.Products.Queries.GetProductDetailForAdmin;
using BMarket.Application.Services.Products.Queries.GetProductDetailForSite;
using BMarket.Application.Services.Products.Queries.GetProductForAdmin;
using BMarket.Application.Services.Products.Queries.GetProductForSite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMarket.Application.Interfaces.FacadPatterns
{
    public interface IProductFacad
    {
        AddNewCategoryService AddNewCategoryService { get; }
        IGetCategoriesService  GetCategoriesService { get; }
        AddNewProductService AddNewProductService { get; }
        IGetAllCategoriesService GetAllCategoriesService { get; }
        IGetProductForAdminService GetProductForAdminService { get; }
        IGetProductDetailForAdminService GetProductDetailForAdminService { get; }
        IGetProductForSiteService GetProductForSiteService { get; }
        IGetProductDetailForSiteService GetProductDetailForSiteService { get; }
    }
}
