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
	///This is the definition of the OrderDetailsExtendedRepository.
	///</Summary>
	public partial class OrderDetailsExtendedRepository : IOrderDetailsExtendedRepository, IDisposable
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
		public virtual IzNorthwindRestApiConn_BaseData BaseData(IDAOOrderDetailsExtended daoOrderDetailsExtended)
		{	return (IzNorthwindRestApiConn_BaseData)(DAOOrderDetailsExtended)daoOrderDetailsExtended;	}

		public virtual IDAOOrderDetailsExtended New()
		{	return new DAOOrderDetailsExtended();	}

		public virtual IList<IDAOOrderDetailsExtended> SelectAll()
		{	return DAOOrderDetailsExtended.SelectAll();	}

		public virtual Int32 SelectAllCount()
		{	return DAOOrderDetailsExtended.SelectAllCount();	}

		public virtual IDictionary<string, IList<object>> SelectAllByCriteriaProjection(IList<IDataProjection> listProjection, IList<IDataCriterion> listCriterion, IList<IDataOrderBy> listOrder, IDataSkip dataSkip, IDataTake dataTake)
		{	return DAOOrderDetailsExtended.SelectAllByCriteriaProjection(listProjection, listCriterion, listOrder, dataSkip, dataTake);	}

		public virtual IList<IDAOOrderDetailsExtended> SelectAllByCriteria(IList<IDataCriterion> listCriterion, IList<IDataOrderBy> listOrder, IDataSkip dataSkip, IDataTake dataTake)
		{	return DAOOrderDetailsExtended.SelectAllByCriteria(listCriterion, listOrder, dataSkip, dataTake);	}

		public virtual Int32 SelectAllByCriteriaCount(IList<IDataCriterion> listCriterion)
		{	return DAOOrderDetailsExtended.SelectAllByCriteriaCount(listCriterion);	}

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