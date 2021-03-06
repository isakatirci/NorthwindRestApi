/*************************************************************
** Class generated by CodeTrigger, Version 6.1.0.7
** This class was generated on 1.12.2018 19:31:13
** Changes to this file may cause incorrect behaviour and will be lost if the code is regenerated
**************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using System.Threading.Tasks;
using NorthwindRestApi.RestApi.SampleViewModels;
using NorthwindRestApi.Business;
using NorthwindRestApi.Business.Interfaces;
using NorthwindRestApi.Business.Repository;
using NorthwindRestApi.Business.Repository.Interfaces;

namespace NorthwindRestApi.RestApi.SampleApiControllers
{
	public partial class ProductsAboveAveragePriceController : ApiController
	{
		protected IProductsAboveAveragePriceRepository _iProductsAboveAveragePriceRepository;

            // GET: api/ProductsAboveAveragePrice
        public async Task<IHttpActionResult> GetProductsAboveAveragePrice(int page = 0, int pageSize = 5)
        {
            int totalCount = 0;

            IList<ProductsAboveAveragePriceVm> listVm = new List<ProductsAboveAveragePriceVm>();
            var result = Task.Factory.StartNew(() => {

                ICriteria criteria = new Criteria<BOProductsAboveAveragePrice>(ProductsAboveAveragePriceRepository);
                totalCount = criteria.Count();

                IList<BOProductsAboveAveragePrice> listBOs = criteria
                    .Add(new OrderBy("ProductName", OrderBy.OrderDirection.Ascending))
                    .Skip(page * pageSize)
                    .Take(pageSize)
                    .List<BOProductsAboveAveragePrice>();

                foreach (var bo in listBOs)
                    listVm.Add(new ProductsAboveAveragePriceVm(bo));
                return listVm;
            });
            await result;

            return Ok(new { Data = result.Result, Paging = new { Total = totalCount, Limit = pageSize, CurrentPage = page, PageCount = (int) Math.Ceiling((double)totalCount / pageSize) } });
        }

        
        public IProductsAboveAveragePriceRepository ProductsAboveAveragePriceRepository
        {
            get { return _iProductsAboveAveragePriceRepository ?? (_iProductsAboveAveragePriceRepository = RF.New().ProductsAboveAveragePriceRepository); }
            set { _iProductsAboveAveragePriceRepository = value; }
        }
        

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
            }
            base.Dispose(disposing);
        }
	}
}
