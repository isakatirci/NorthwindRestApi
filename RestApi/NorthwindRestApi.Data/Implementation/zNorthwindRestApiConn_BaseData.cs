/*************************************************************
** Class generated by CodeTrigger, Version 6.1.0.7
** This class was generated on 1.12.2018 19:31:12
**************************************************************/

using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using NorthwindRestApi.Data.Interfaces;

namespace NorthwindRestApi.Data
{
	public partial class zNorthwindRestApiConn_BaseData : IDisposable, IzNorthwindRestApiConn_BaseData
	{
		#region members
		protected IzNorthwindRestApiConn_TxConnectionProvider _connectionProvider;
		static string _staticConnectionString;
		bool _isDisposed = false;
		#endregion

		#region initialisation
		public zNorthwindRestApiConn_BaseData()
		{
			Init();
		}

		private void Init()
		{
		}
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

		#region connection support
		public static SqlConnection StaticSqlConnection
		{
			get
			{
				SqlConnection staticConnection = new SqlConnection();
				staticConnection.ConnectionString = StaticConnectionString;
				return staticConnection;
			}
		}

		public virtual IzNorthwindRestApiConn_TxConnectionProvider ConnectionProvider
		{
			set
			{
				if(value == null)
					throw new Exception("Connection provider cannot be null");
				
				_connectionProvider = value;
			}
		}

		public static string StaticConnectionString
		{
			set { _staticConnectionString = value; }
			get
			{
				if (!string.IsNullOrEmpty(_staticConnectionString))
					return _staticConnectionString;
				
				return zNorthwindRestApiConn_ConfigWrapper.GetConnectionString("63086bf4-75f2-4ca8-9dc7-b7f145eb21f6");
			}
		}
		#endregion

		#region criteria api support
		protected static string GetProjections(IList<IDataProjection> dataProjection)
		{
			string ret = "";
			if (dataProjection != null)
			{
				foreach (var projection in dataProjection)
				{
					if (ret != "") ret += ", ";
						ret += projection.ToSql();
				}
			}
			return ret;
		}

		public static string GetSelectionCriteria(IList<IDataCriterion> dataCriteria)
		{
			string ret = "";
			if(dataCriteria != null)
			{
				foreach (var criterion in dataCriteria)
				{
					if (ret != "") ret += " AND ";
					ret += criterion.ToSql();
				}
			}
			return ret;
		}

		public static string GetSelectionOrder(IList<IDataOrderBy> dataOrder)
		{
			string retorder = "";
			if(dataOrder != null)
			{
				foreach (var order in dataOrder)
				{
					if (retorder != "") retorder += ", ";
					retorder += order.ToSql();
				}
			}
			return retorder;
		}

		public static string GetSelectionSkip(IDataSkip dataSkip)
		{
			string retskip = "";
			if (dataSkip != null)
				retskip = " " + dataSkip.ToSql();
			return retskip;
		}

		public static string GetSelectionTake(IDataTake dataTake)
		{
			string rettake = "";
			if (dataTake != null)
				rettake = " " + dataTake.ToSql();
			return rettake;
		}

		protected static string UpdateFieldProjections(string query, string projections)
		{
			string fieldsStartMarker = "##STARTFIELDS##";
			string fieldsEndMarker = "##ENDFIELDS##";
			int fPosStart = query.IndexOf(fieldsStartMarker);
			int fPosEnd = query.IndexOf(fieldsEndMarker);
			if ((fPosStart < 0) || (fPosEnd < 0))
				return query;
			else if(string.IsNullOrEmpty(projections))
			{
				query = query.Replace(fieldsStartMarker, "");
				query = query.Replace(fieldsEndMarker, "");
			}
			else
			{
				string fieldsSubString = query.Substring(fPosStart, (fPosEnd - fPosStart + 13));
				query = query.Replace(fieldsSubString, projections);
			}
		return query;
		}

		public static string GetSelectionCriteria(string query, IList<IDataProjection> dataProjection, IList<IDataCriterion> dataCriteria, IList<IDataOrderBy> dataOrder)
		{
			return GetSelectionCriteria(query, dataProjection, dataCriteria, dataOrder, null, null);
		}
			
		public static string GetSelectionCriteria(string query, IList<IDataProjection> dataProjection, IList<IDataCriterion> dataCriteria, IList<IDataOrderBy> dataOrder, IDataSkip dataSkip, IDataTake dataTake)
		{
			string projections = "";
			projections = GetProjections(dataProjection);
			query = UpdateFieldProjections(query, projections);

			string ret = GetSelectionCriteria(dataCriteria);
			ret = (ret != "") ? " WHERE " + ret : "";
			
			string retorder = GetSelectionOrder(dataOrder);
			retorder = (retorder != "") ? " ORDER BY " + retorder : "";
			
			string retskip = GetSelectionSkip(dataSkip);
			string rettake = GetSelectionTake(dataTake);
			if ((retorder == "") && ((rettake != "") || (retskip != "")))
				throw new Exception("Invalid query: Using 'Take' or 'Skip' requires an OrderBy clause");
			
			retorder += (retskip + rettake);
			ret = ret + retorder;
			query = query.Replace("##CRITERIA##", ret);
			return query;
		}
		#endregion
		
		#region logging support
		static partial void LogDoing(object o, string memberName);
		static partial void LogDone(object o, string memberName);
		static partial void LogFailed(object o, Exception ex, string memberName);
		
		static protected void Doing(object o, [CallerMemberName] string memberName = "")
		{
			LogDoing(o, memberName);
		}
		
		static protected void Done(object o, [CallerMemberName] string memberName = "")
		{
			LogDone(o, memberName);
		}
		
		static protected void Failed(object o, Exception ex, [CallerMemberName] string memberName = "")
		{
			LogFailed(o, ex, memberName);
		}
		#endregion
		
		#region exception handling support
		static partial void HandleException(object o, Exception ex, string memberName);
		
		static protected void Handle(object o, Exception ex, [CallerMemberName] string memberName = "")
		{
			HandleException(o, ex, memberName);
		}
		#endregion
	}
}