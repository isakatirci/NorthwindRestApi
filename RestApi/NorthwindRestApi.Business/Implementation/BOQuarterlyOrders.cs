/*************************************************************
** Class generated by CodeTrigger, Version 6.1.0.7
** This class was generated on 1.12.2018 19:31:12
** Changes to this file may cause incorrect behaviour and will be lost if the code is regenerated
**************************************************************/
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using NorthwindRestApi.Data;
using NorthwindRestApi.Data.Interfaces;
using NorthwindRestApi.Business.Interfaces;
using NorthwindRestApi.Business.Repository.Interfaces;

namespace NorthwindRestApi.Business
{
	///<Summary>
	///Class definition
	///This is the definition of the class BOQuarterlyOrders.
	///</Summary>
	public partial class BOQuarterlyOrders : zNorthwindRestApiConn_BaseBusiness, IBOQuarterlyOrders, IQueryableCollection
	{
		#region member variables
		protected string _customerID;
		protected string _companyName;
		protected string _city;
		protected string _country;
		protected bool _isDirty = false;
		/*collection member objects*******************/
		/*********************************************/
		/*repositories*********************************/
		protected IQuarterlyOrdersRepository _iQuarterlyOrdersRepository;
		/*********************************************/
		#endregion

		#region class methods
		///<Summary>
		///Constructor
		///This is the default constructor
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		public BOQuarterlyOrders()
		{
		}

		///<Summary>
		///Constructor
		///This constructor initializes the business object from its respective data object
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///DAOQuarterlyOrders
		///</parameters>
		protected internal BOQuarterlyOrders(IDAOQuarterlyOrders daoQuarterlyOrders)
		{
			try
			{
				_customerID = daoQuarterlyOrders.CustomerID;
				_companyName = daoQuarterlyOrders.CompanyName;
				_city = daoQuarterlyOrders.City;
				_country = daoQuarterlyOrders.Country;
			}
			catch
			{
				throw;
			}
		}

		
		///<Summary>
		///QuarterlyOrdersCollection
		///This method returns the collection of BOQuarterlyOrders objects
		///</Summary>
		///<returns>
		///IList[IBOQuarterlyOrders]
		///</returns>
		///<parameters>
		///
		///</parameters>
		public static IList<IBOQuarterlyOrders> QuarterlyOrdersCollection(IQuarterlyOrdersRepository iQuarterlyOrdersRepository)
		{
			Doing(null);
			try
			{
				IList<IBOQuarterlyOrders> boQuarterlyOrdersCollection = new List<IBOQuarterlyOrders>();
				IList<IDAOQuarterlyOrders> daoQuarterlyOrdersCollection = iQuarterlyOrdersRepository.SelectAll();
				Done(null);
				
				foreach(IDAOQuarterlyOrders daoQuarterlyOrders in daoQuarterlyOrdersCollection)
					boQuarterlyOrdersCollection.Add(new BOQuarterlyOrders(daoQuarterlyOrders));
				
				return boQuarterlyOrdersCollection;
			}
			catch(Exception ex)
			{
				Failed(null, ex);
				Handle(null, ex);
				return null;
			}
		}
		
		
		///<Summary>
		///QuarterlyOrdersCollectionCount
		///This method returns the collection count of BOQuarterlyOrders objects
		///</Summary>
		///<returns>
		///Int32
		///</returns>
		///<parameters>
		///
		///</parameters>
		public static Int32 QuarterlyOrdersCollectionCount(IQuarterlyOrdersRepository iQuarterlyOrdersRepository)
		{
			Doing(null);
			try
			{
				Int32 objCount = iQuarterlyOrdersRepository.SelectAllCount();
				return objCount;
			}
			catch(Exception ex)
			{
				Failed(null, ex);
				Handle(null, ex);
				return -1;
			}
		}
		
		
		///<Summary>
		///QuarterlyOrdersCollectionFromCriteria
		///This method returns the collection of projections, ordered and filtered by optional criteria
		///</Summary>
		///<returns>
		///IList<IBOQuarterlyOrders>
		///</returns>
		///<parameters>
		///ICriteria icriteria
		///</parameters>
		public virtual IDictionary<string, IList<object>> Projections(object o)
		{
			Doing(this);
			try
			{
				ICriteria icriteria = (ICriteria)o;
				IList<IDataProjection> lstDataProjection = (icriteria == null) ? null : icriteria.ListDataProjection();
				IList<IDataCriterion> lstDataCriteria = (icriteria == null) ? null : icriteria.ListDataCriteria();
				IList<IDataOrderBy> lstDataOrder = (icriteria == null) ? null : icriteria.ListDataOrder();
				IDataSkip dataSkip = (icriteria == null) ? null : icriteria.DataSkip();
				IDataTake dataTake = (icriteria == null) ? null : icriteria.DataTake();
				return _iQuarterlyOrdersRepository.SelectAllByCriteriaProjection(lstDataProjection, lstDataCriteria, lstDataOrder, dataSkip, dataTake);
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				Handle(this, ex);
				return null;
			}
		}
		
		///<Summary>
		///Collection<T>
		///This method returns the collection of T objects, ordered and filtered by optional criteria
		///</Summary>
		///<returns>
		///IList<T>
		///</returns>
		///<parameters>
		///object o (ICriteria)
		///</parameters>
		public virtual IList<T> Collection<T>(object o)
		{
			Doing(this);
			try
			{
				ICriteria icriteria = (ICriteria)o;
				IList<T> boQuarterlyOrdersCollection = new List<T>();
				IList<IDataCriterion> lstDataCriteria = (icriteria == null) ? null : icriteria.ListDataCriteria();
				IList<IDataOrderBy> lstDataOrder = (icriteria == null) ? null : icriteria.ListDataOrder();
				IDataSkip dataSkip = (icriteria == null) ? null : icriteria.DataSkip();
				IDataTake dataTake = (icriteria == null) ? null : icriteria.DataTake();
				IList<IDAOQuarterlyOrders> daoQuarterlyOrdersCollection = _iQuarterlyOrdersRepository.SelectAllByCriteria(lstDataCriteria, lstDataOrder, dataSkip, dataTake);
				
				foreach(IDAOQuarterlyOrders resdaoQuarterlyOrders in daoQuarterlyOrdersCollection)
					boQuarterlyOrdersCollection.Add((T)(object)new BOQuarterlyOrders(resdaoQuarterlyOrders));
				
				return boQuarterlyOrdersCollection;
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				Handle(this, ex);
				return null;
			}
		}
		
		
		///<Summary>
		///CollectionCount
		///This method returns the collection count of BOQuarterlyOrders objects, filtered by optional criteria
		///</Summary>
		///<returns>
		///Int32
		///</returns>
		///<parameters>
		///ICriteria icriteria
		///</parameters>
		public virtual Int32 CollectionCount(object o)
		{
			Doing(this);
			try
			{
				ICriteria icriteria = (ICriteria)o;
				List<IBOQuarterlyOrders> boQuarterlyOrdersCollection = new List<IBOQuarterlyOrders>();
				IList<IDataCriterion> lstDataCriteria = (icriteria == null) ? null : icriteria.ListDataCriteria();
				Int32 objCount = _iQuarterlyOrdersRepository.SelectAllByCriteriaCount(lstDataCriteria);
				
				return objCount;
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				Handle(this, ex);
				return -1;
			}
		}
		
		#endregion

		#region member properties
		
		[InjectionPoint]
		[XmlIgnore]
		public virtual IQuarterlyOrdersRepository QuarterlyOrdersRepository
		{
			set
			{
				_iQuarterlyOrdersRepository = value;
			}
		}
		
		public virtual string CustomerID
		{
			get
			{
				 return _customerID;
			}
			set
			{
				_customerID = value;
				_isDirty = true;
			}
		}
		
		public virtual string CompanyName
		{
			get
			{
				 return _companyName;
			}
			set
			{
				_companyName = value;
				_isDirty = true;
			}
		}
		
		public virtual string City
		{
			get
			{
				 return _city;
			}
			set
			{
				_city = value;
				_isDirty = true;
			}
		}
		
		public virtual string Country
		{
			get
			{
				 return _country;
			}
			set
			{
				_country = value;
				_isDirty = true;
			}
		}
		
		[XmlIgnore]
		public virtual object Repository
		{
			get {	return (object) _iQuarterlyOrdersRepository;	}
			set {	QuarterlyOrdersRepository = (IQuarterlyOrdersRepository)value;	}
		}
		
		public virtual bool IsDirty
		{
			get
			{
				 return _isDirty;
			}
			set
			{
				_isDirty = value;
			}
		}
		#endregion
	}
}
