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
	public partial class CategoriesController : ApiController
	{
		protected ICategoriesRepository _iCategoriesRepository;

            // GET: api/Categories
        public async Task<IHttpActionResult> GetCategories(int page = 0, int pageSize = 5)
        {
            int totalCount = 0;

            IList<CategoriesVm> listVm = new List<CategoriesVm>();
            var result = Task.Factory.StartNew(() => {

                ICriteria criteria = new Criteria<BOCategories>(CategoriesRepository);
                totalCount = criteria.Count();

                IList<BOCategories> listBOs = criteria
                    .Add(new OrderBy("CategoryID", OrderBy.OrderDirection.Ascending))
                    .Skip(page * pageSize)
                    .Take(pageSize)
                    .List<BOCategories>();

                foreach (var bo in listBOs)
                    listVm.Add(new CategoriesVm(bo));
                return listVm;
            });
            await result;

            return Ok(new { Data = result.Result, Paging = new { Total = totalCount, Limit = pageSize, CurrentPage = page, PageCount = (int) Math.Ceiling((double)totalCount / pageSize) } });
        }

        // GET: api/Categories/5
        [ResponseType(typeof(CategoriesVm))]
        public async Task<IHttpActionResult> GetCategories(Int32 id)
        {
            var result = Task.Factory.StartNew(() => {

                BOCategories bo = new Criteria<BOCategories>(CategoriesRepository)
                .Add(Expression.Eq("CategoryID", id))
                .SingleOrDefault<BOCategories>();
                return bo == null ? null : new CategoriesVm(bo);

            });
            await result;
            if (result.Result == null)
            {
                return NotFound();
            }

            return Ok(result.Result);
        }

        // PUT: api/Categories/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutCategories(Int32 id, CategoriesVm vm)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != vm.CategoryID)
            {
                return BadRequest();
            }

            var result = Task.Factory.StartNew(() => {

                IUnitOfWork uow = new UnitOfWorkImp(new IRepositoryConnection[] { CategoriesRepository }); 
                var bo = (BOCategories)vm.BOCategories(CategoriesRepository);
                uow.Update(bo);

                string err;
                if (!uow.Commit(out err))
                {
                    var resp = new HttpResponseMessage(HttpStatusCode.BadRequest) { Content = new StringContent(err) };
                    throw new HttpResponseException(resp);
                }
                return true;
            });
            await result;
            if (!result.Result)
                return NotFound();

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Categories
        [ResponseType(typeof(CategoriesVm))]
        public async Task<IHttpActionResult> PostCategories(CategoriesVm vm)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = Task.Factory.StartNew(() =>
            {
                IUnitOfWork uow = new UnitOfWorkImp(new IRepositoryConnection[] { CategoriesRepository }); 
                var bo = (BOCategories)vm.BOCategories(CategoriesRepository);
                uow.Create(bo);

                string err;
                if (!uow.Commit(out err))
                {
                    var resp = new HttpResponseMessage(HttpStatusCode.BadRequest) { Content = new StringContent(err) };
                    throw new HttpResponseException(resp);
                }
                vm = new CategoriesVm(bo);
                return true;
            });
            await result;
            return CreatedAtRoute("DefaultApi", new { id = vm.CategoryID }, vm);
        }

        // DELETE: api/Categories/5
        [ResponseType(typeof(CategoriesVm))]
        public async Task<IHttpActionResult> DeleteCategories(Int32 id)
        {
            var result = Task.Factory.StartNew(() =>
            {
                 IUnitOfWork uow = new UnitOfWorkImp(new IRepositoryConnection[] { CategoriesRepository }); 
                var bo = new BOCategories();
                bo.Repository = CategoriesRepository;
                bo.Init(id);
                
                uow.Delete(bo);

                string err;
                if (!uow.Commit(out err))
                {
                    var resp = new HttpResponseMessage(HttpStatusCode.BadRequest) { Content = new StringContent(err) };
                    throw new HttpResponseException(resp);
                }
                return true;
            });
            await result;
            if (!result.Result)
                return NotFound();

            return Ok(result.Result);
        }

        
        public ICategoriesRepository CategoriesRepository
        {
            get { return _iCategoriesRepository ?? (_iCategoriesRepository = RF.New().CategoriesRepository); }
            set { _iCategoriesRepository = value; }
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