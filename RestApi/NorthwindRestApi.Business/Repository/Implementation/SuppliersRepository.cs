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
	///This is the definition of the SuppliersRepository.
	///</Summary>
	public partial class SuppliersRepository : ISuppliersRepository, IDisposable
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
		public virtual IzNorthwindRestApiConn_BaseData BaseData(IDAOSuppliers daoSuppliers)
		{	return (IzNorthwindRestApiConn_BaseData)(DAOSuppliers)daoSuppliers;	}

		public virtual IDAOSuppliers New()
		{	return new DAOSuppliers();	}

		public virtual void Insert(IDAOSuppliers daoSuppliers)
		{	daoSuppliers.Insert();	}

		public virtual void Update(IDAOSuppliers daoSuppliers)
		{	daoSuppliers.Update();	}

		public virtual void Delete(IDAOSuppliers daoSuppliers)
		{	daoSuppliers.Delete();	}

		public virtual IList<IDAOSuppliers> SelectAll()
		{	return DAOSuppliers.SelectAll();	}

		public virtual Int32 SelectAllCount()
		{	return DAOSuppliers.SelectAllCount();	}

		public virtual IDictionary<string, IList<object>> SelectAllByCriteriaProjection(IList<IDataProjection> listProjection, IList<IDataCriterion> listCriterion, IList<IDataOrderBy> listOrder, IDataSkip dataSkip, IDataTake dataTake)
		{	return DAOSuppliers.SelectAllByCriteriaProjection(listProjection, listCriterion, listOrder, dataSkip, dataTake);	}

		public virtual IList<IDAOSuppliers> SelectAllByCriteria(IList<IDataCriterion> listCriterion, IList<IDataOrderBy> listOrder, IDataSkip dataSkip, IDataTake dataTake)
		{	return DAOSuppliers.SelectAllByCriteria(listCriterion, listOrder, dataSkip, dataTake);	}

		public virtual Int32 SelectAllByCriteriaCount(IList<IDataCriterion> listCriterion)
		{	return DAOSuppliers.SelectAllByCriteriaCount(listCriterion);	}

		public virtual IDAOSuppliers SelectOne(Int32? supplierID)
		{	return DAOSuppliers.SelectOne(supplierID);	}

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
