/*************************************************************
** Class generated by CodeTrigger, Version 6.1.0.7
** This class was generated on 1.12.2018 19:31:13
** Changes to this file may cause incorrect behaviour and will be lost if the code is regenerated
**************************************************************/
using System;
using System.Collections.Generic;
using NorthwindRestApi.Data.Interfaces;

namespace NorthwindRestApi.Business.Repository.Interfaces
{
	///<Summary>
	///Interface definition
	///This is the interface definition for the OrderDetails repository
	///</Summary>
	public partial interface IOrderDetailsRepository : IGenericRepository<IDAOOrderDetails>, IRepositoryConnection
	{
		void Insert(IDAOOrderDetails daoOrderDetails);
		void Update(IDAOOrderDetails daoOrderDetails);
		void Delete(IDAOOrderDetails daoOrderDetails);
		IDAOOrderDetails SelectOne(Int32? orderID, Int32? productID);
		IList<IDAOOrderDetails> SelectAllByOrderID(Int32? orderID);
		void DeleteAllByOrderID(Int32? orderID);
		IList<IDAOOrderDetails> SelectAllByProductID(Int32? productID);
		void DeleteAllByProductID(Int32? productID);
	}
}