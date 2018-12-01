/*************************************************************
** Class generated by CodeTrigger, Version 6.1.0.7
** This class was generated on 1.12.2018 16:11:04
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
using NorthwindTest2.Mvc.SampleViewModels;
using NorthwindTest2.Business;
using NorthwindTest2.Business.Interfaces;
using NorthwindTest2.Business.Repository;
using NorthwindTest2.Business.Repository.Interfaces;

namespace NorthwindTest2.Mvc.SampleApiControllers
{
	public partial class TerritoriesController : ApiController
	{
		protected ITerritoriesRepository _iTerritoriesRepository;

            // GET: api/Territories
        public async Task<IHttpActionResult> GetTerritories(int page = 0, int pageSize = 5)
        {
            int totalCount = 0;

            IList<TerritoriesVm> listVm = new List<TerritoriesVm>();
            var result = Task.Factory.StartNew(() => {

                ICriteria criteria = new Criteria<BOTerritories>(TerritoriesRepository);
                totalCount = criteria.Count();

                IList<BOTerritories> listBOs = criteria
                    .Add(new OrderBy("TerritoryID", OrderBy.OrderDirection.Ascending))
                    .Skip(page * pageSize)
                    .Take(pageSize)
                    .List<BOTerritories>();

                foreach (var bo in listBOs)
                    listVm.Add(new TerritoriesVm(bo));
                return listVm;
            });
            await result;

            return Ok(new { Data = result.Result, Paging = new { Total = totalCount, Limit = pageSize, CurrentPage = page, PageCount = (int) Math.Ceiling((double)totalCount / pageSize) } });
        }

        // GET: api/Territories/5
        [ResponseType(typeof(TerritoriesVm))]
        public async Task<IHttpActionResult> GetTerritories(string id)
        {
            var result = Task.Factory.StartNew(() => {

                BOTerritories bo = new Criteria<BOTerritories>(TerritoriesRepository)
                .Add(Expression.Eq("TerritoryID", id))
                .SingleOrDefault<BOTerritories>();
                return bo == null ? null : new TerritoriesVm(bo);

            });
            await result;
            if (result.Result == null)
            {
                return NotFound();
            }

            return Ok(result.Result);
        }

        // PUT: api/Territories/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutTerritories(string id, TerritoriesVm vm)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != vm.TerritoryID)
            {
                return BadRequest();
            }

            var result = Task.Factory.StartNew(() => {

                IUnitOfWork uow = new UnitOfWorkImp(new IRepositoryConnection[] { TerritoriesRepository }); 
                var bo = (BOTerritories)vm.BOTerritories(TerritoriesRepository);
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

        // POST: api/Territories
        [ResponseType(typeof(TerritoriesVm))]
        public async Task<IHttpActionResult> PostTerritories(TerritoriesVm vm)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = Task.Factory.StartNew(() =>
            {
                IUnitOfWork uow = new UnitOfWorkImp(new IRepositoryConnection[] { TerritoriesRepository }); 
                var bo = (BOTerritories)vm.BOTerritories(TerritoriesRepository);
                uow.Create(bo);

                string err;
                if (!uow.Commit(out err))
                {
                    var resp = new HttpResponseMessage(HttpStatusCode.BadRequest) { Content = new StringContent(err) };
                    throw new HttpResponseException(resp);
                }
                vm = new TerritoriesVm(bo);
                return true;
            });
            await result;
            return CreatedAtRoute("DefaultApi", new { id = vm.TerritoryID }, vm);
        }

        // DELETE: api/Territories/5
        [ResponseType(typeof(TerritoriesVm))]
        public async Task<IHttpActionResult> DeleteTerritories(string id)
        {
            var result = Task.Factory.StartNew(() =>
            {
                 IUnitOfWork uow = new UnitOfWorkImp(new IRepositoryConnection[] { TerritoriesRepository }); 
                var bo = new BOTerritories();
                bo.Repository = TerritoriesRepository;
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

        
        public ITerritoriesRepository TerritoriesRepository
        {
            get { return _iTerritoriesRepository ?? (_iTerritoriesRepository = RF.New().TerritoriesRepository); }
            set { _iTerritoriesRepository = value; }
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