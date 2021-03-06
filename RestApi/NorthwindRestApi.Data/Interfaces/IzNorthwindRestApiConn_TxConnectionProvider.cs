/*************************************************************
** Class generated by CodeTrigger, Version 6.1.0.7
** This class was generated on 1.12.2018 19:31:12
**************************************************************/

using System;
using System.Data.SqlClient;

namespace NorthwindRestApi.Data.Interfaces
{
	public partial interface IzNorthwindRestApiConn_TxConnectionProvider
	{
		void OpenConnection();
		void CloseConnection(bool commit);
		void BeginTransaction(string trans);
		void CommitTransaction();
		void RollbackTransaction(string trans);
		SqlTransaction CurrentTransaction	{	get;	}
		SqlConnection Connection	{	get;	}
		Int32 TransactionCount { get; set; }
	}
}
