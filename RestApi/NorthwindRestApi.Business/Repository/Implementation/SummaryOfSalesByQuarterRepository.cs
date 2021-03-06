/*************************************************************
** Class generated by CodeTrigger, Version 6.1.0.7
** This class was generated on 1.12.2018 19:31:13
** Changes to this file may cause incorrect behaviour and will be lost if the code is regenerated
**************************************************************/
using System;
using System.Collections.Generic;
using NorthwindRestApi.Data;
using NorthwindRestApi.Data.Interfaces;
using NorthwindRestApi.Business.Repository.Interfaces;

namespace NorthwindRestApi.Business.Repository
{
	///<Summary>
	///Class definition
	///This is the definition of the SummaryOfSalesByQuarterRepository.
	///</Summary>
	public partial class SummaryOfSalesByQuarterRepository : ISummaryOfSalesByQuarterRepository, IDisposable
	{
		#region member variables
		IzNorthwindRestApiConn_TxConnectionProvider _connectionProvider;
		bool _isDisposed = false;
		#endregion

		#region disposable interface support
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		protected virtual void Dispose(bool isDisposing)
		{
			if(!_isDisposed)
			{
				if(isDisposing)
				{
					if(_connectionProvider != null)
					{
						((IDisposable)_connectionProvider).Dispose();
						_connectionProvider = null;
					}
				}
			}
			_isDisposed = true;
		}
		#endregion

		#region methods
		public virtual IzNorthwindRestApiConn_BaseData BaseData(IDAOSummaryOfSalesByQuarter daoSummaryOfSalesByQuarter)
		{	return (IzNorthwindRestApiConn_BaseData)(DAOSummaryOfSalesByQuarter)daoSummaryOfSalesByQuarter;	}

		public virtual IDAOSummaryOfSalesByQuarter New()
		{	return new DAOSummaryOfSalesByQuarter();	}

		public virtual IList<IDAOSummaryOfSalesByQuarter> SelectAll()
		{	return DAOSummaryOfSalesByQuarter.SelectAll();	}

		public virtual Int32 SelectAllCount()
		{	return DAOSummaryOfSalesByQuarter.SelectAllCount();	}

		public virtual IDictionary<string, IList<object>> SelectAllByCriteriaProjection(IList<IDataProjection> listProjection, IList<IDataCriterion> listCriterion, IList<IDataOrderBy> listOrder, IDataSkip dataSkip, IDataTake dataTake)
		{	return DAOSummaryOfSalesByQuarter.SelectAllByCriteriaProjection(listProjection, listCriterion, listOrder, dataSkip, dataTake);	}

		public virtual IList<IDAOSummaryOfSalesByQuarter> SelectAllByCriteria(IList<IDataCriterion> listCriterion, IList<IDataOrderBy> listOrder, IDataSkip dataSkip, IDataTake dataTake)
		{	return DAOSummaryOfSalesByQuarter.SelectAllByCriteria(listCriterion, listOrder, dataSkip, dataTake);	}

		public virtual Int32 SelectAllByCriteriaCount(IList<IDataCriterion> listCriterion)
		{	return DAOSummaryOfSalesByQuarter.SelectAllByCriteriaCount(listCriterion);	}

		#endregion

		#region properties
		public virtual IzNorthwindRestApiConn_TxConnectionProvider ConnectionProvider
		{
			get { return _connectionProvider; }
			set { _connectionProvider = value; }
		}

		#endregion

	}
}
