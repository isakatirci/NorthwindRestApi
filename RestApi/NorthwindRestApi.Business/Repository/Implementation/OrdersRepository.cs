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
	///This is the definition of the OrdersRepository.
	///</Summary>
	public partial class OrdersRepository : IOrdersRepository, IDisposable
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
		public virtual IzNorthwindRestApiConn_BaseData BaseData(IDAOOrders daoOrders)
		{	return (IzNorthwindRestApiConn_BaseData)(DAOOrders)daoOrders;	}

		public virtual IDAOOrders New()
		{	return new DAOOrders();	}

		public virtual void Insert(IDAOOrders daoOrders)
		{	daoOrders.Insert();	}

		public virtual void Update(IDAOOrders daoOrders)
		{	daoOrders.Update();	}

		public virtual void Delete(IDAOOrders daoOrders)
		{	daoOrders.Delete();	}

		public virtual IList<IDAOOrders> SelectAll()
		{	return DAOOrders.SelectAll();	}

		public virtual Int32 SelectAllCount()
		{	return DAOOrders.SelectAllCount();	}

		public virtual IDictionary<string, IList<object>> SelectAllByCriteriaProjection(IList<IDataProjection> listProjection, IList<IDataCriterion> listCriterion, IList<IDataOrderBy> listOrder, IDataSkip dataSkip, IDataTake dataTake)
		{	return DAOOrders.SelectAllByCriteriaProjection(listProjection, listCriterion, listOrder, dataSkip, dataTake);	}

		public virtual IList<IDAOOrders> SelectAllByCriteria(IList<IDataCriterion> listCriterion, IList<IDataOrderBy> listOrder, IDataSkip dataSkip, IDataTake dataTake)
		{	return DAOOrders.SelectAllByCriteria(listCriterion, listOrder, dataSkip, dataTake);	}

		public virtual Int32 SelectAllByCriteriaCount(IList<IDataCriterion> listCriterion)
		{	return DAOOrders.SelectAllByCriteriaCount(listCriterion);	}

		public virtual IDAOOrders SelectOne(Int32? orderID)
		{	return DAOOrders.SelectOne(orderID);	}

		public virtual IList<IDAOOrders> SelectAllByCustomerID(string customerID)
		{	return DAOOrders.SelectAllByCustomerID(customerID);	}

		public virtual void DeleteAllByCustomerID(string customerID)
		{	DAOOrders.DeleteAllByCustomerID(ConnectionProvider, customerID);	}

		public virtual IList<IDAOOrders> SelectAllByEmployeeID(Int32? employeeID)
		{	return DAOOrders.SelectAllByEmployeeID(employeeID);	}

		public virtual void DeleteAllByEmployeeID(Int32? employeeID)
		{	DAOOrders.DeleteAllByEmployeeID(ConnectionProvider, employeeID);	}

		public virtual IList<IDAOOrders> SelectAllByShipVia(Int32? shipVia)
		{	return DAOOrders.SelectAllByShipVia(shipVia);	}

		public virtual void DeleteAllByShipVia(Int32? shipVia)
		{	DAOOrders.DeleteAllByShipVia(ConnectionProvider, shipVia);	}

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
