/*************************************************************
** Class generated by CodeTrigger, Version 6.1.0.7
** This class was generated on 1.12.2018 16:11:04
** Changes to this file may cause incorrect behaviour and will be lost if the code is regenerated
**************************************************************/
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using NorthwindTest2.Data;
using NorthwindTest2.Data.Interfaces;
using NorthwindTest2.Business.Interfaces;
using NorthwindTest2.Business.Repository.Interfaces;

namespace NorthwindTest2.Business
{
	///<Summary>
	///Class definition
	///This is the definition of the class BOEmployeeTerritories.
	///</Summary>
	public partial class BOEmployeeTerritories : zNorthwindTest2Conn_BaseBusiness, IBOEmployeeTerritories, IQueryableCollection
	{
		#region member variables
		protected Int32? _employeeID;
		protected string _territoryID;
		protected bool _isDirty = false;
		/*collection member objects*******************/
		/*********************************************/
		/*repositories*********************************/
		protected IEmployeeTerritoriesRepository _iEmployeeTerritoriesRepository;
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
		public BOEmployeeTerritories()
		{
		}

		///<Summary>
		///Initializer
		///Initializer using primary key(s)
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///Int32 employeeID, string territoryID
		///</parameters>
		public void Init(Int32 employeeID, string territoryID)
		{
			try
			{
				IDAOEmployeeTerritories daoEmployeeTerritories = _iEmployeeTerritoriesRepository.SelectOne(employeeID, territoryID);
				_employeeID = daoEmployeeTerritories.EmployeeID;
				_territoryID = daoEmployeeTerritories.TerritoryID;
			}
			catch
			{
				throw;
			}
		}

		///<Summary>
		///Constructor
		///This constructor initializes the business object from its respective data object
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///DAOEmployeeTerritories
		///</parameters>
		protected internal BOEmployeeTerritories(IDAOEmployeeTerritories daoEmployeeTerritories)
		{
			try
			{
				_employeeID = daoEmployeeTerritories.EmployeeID;
				_territoryID = daoEmployeeTerritories.TerritoryID;
			}
			catch
			{
				throw;
			}
		}

		///<Summary>
		///SaveNew
		///This method persists a new EmployeeTerritories record to the store
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		public virtual void SaveNew()
		{
			Doing(this);
			IDAOEmployeeTerritories daoEmployeeTerritories = _iEmployeeTerritoriesRepository.New();
			RegisterDataObject( _iEmployeeTerritoriesRepository, _iEmployeeTerritoriesRepository.BaseData(daoEmployeeTerritories));
			BeginTransaction( _iEmployeeTerritoriesRepository, "savenewBOEmployeeTerritories");
			try
			{
				daoEmployeeTerritories.EmployeeID = _employeeID;
				daoEmployeeTerritories.TerritoryID = _territoryID;
				_iEmployeeTerritoriesRepository.Insert(daoEmployeeTerritories);
				CommitTransaction( _iEmployeeTerritoriesRepository);
				Done(this);
				
				_employeeID = daoEmployeeTerritories.EmployeeID;
				_territoryID = daoEmployeeTerritories.TerritoryID;
				_isDirty = false;
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				RollbackTransaction(_iEmployeeTerritoriesRepository, "savenewBOEmployeeTerritories");
				Handle(this, ex);
			}
		}
		///<Summary>
		///Delete
		///This method deletes one EmployeeTerritories record from the store
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		public virtual void Delete()
		{
			Doing(this);
			IDAOEmployeeTerritories daoEmployeeTerritories = _iEmployeeTerritoriesRepository.New();
			RegisterDataObject(_iEmployeeTerritoriesRepository, _iEmployeeTerritoriesRepository.BaseData(daoEmployeeTerritories));
			BeginTransaction(_iEmployeeTerritoriesRepository, "deleteBOEmployeeTerritories");
			try
			{
				daoEmployeeTerritories.EmployeeID = _employeeID;
				daoEmployeeTerritories.TerritoryID = _territoryID;
				_iEmployeeTerritoriesRepository.Delete(daoEmployeeTerritories);
				CommitTransaction(_iEmployeeTerritoriesRepository);
				Done(this);
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				RollbackTransaction(_iEmployeeTerritoriesRepository, "deleteBOEmployeeTerritories");
				Handle(this, ex);
			}
		}
		
		///<Summary>
		///EmployeeTerritoriesCollection
		///This method returns the collection of BOEmployeeTerritories objects
		///</Summary>
		///<returns>
		///IList[IBOEmployeeTerritories]
		///</returns>
		///<parameters>
		///
		///</parameters>
		public static IList<IBOEmployeeTerritories> EmployeeTerritoriesCollection(IEmployeeTerritoriesRepository iEmployeeTerritoriesRepository)
		{
			Doing(null);
			try
			{
				IList<IBOEmployeeTerritories> boEmployeeTerritoriesCollection = new List<IBOEmployeeTerritories>();
				IList<IDAOEmployeeTerritories> daoEmployeeTerritoriesCollection = iEmployeeTerritoriesRepository.SelectAll();
				Done(null);
				
				foreach(IDAOEmployeeTerritories daoEmployeeTerritories in daoEmployeeTerritoriesCollection)
					boEmployeeTerritoriesCollection.Add(new BOEmployeeTerritories(daoEmployeeTerritories));
				
				return boEmployeeTerritoriesCollection;
			}
			catch(Exception ex)
			{
				Failed(null, ex);
				Handle(null, ex);
				return null;
			}
		}
		
		
		///<Summary>
		///EmployeeTerritoriesCollectionCount
		///This method returns the collection count of BOEmployeeTerritories objects
		///</Summary>
		///<returns>
		///Int32
		///</returns>
		///<parameters>
		///
		///</parameters>
		public static Int32 EmployeeTerritoriesCollectionCount(IEmployeeTerritoriesRepository iEmployeeTerritoriesRepository)
		{
			Doing(null);
			try
			{
				Int32 objCount = iEmployeeTerritoriesRepository.SelectAllCount();
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
		///EmployeeTerritoriesCollectionFromCriteria
		///This method returns the collection of projections, ordered and filtered by optional criteria
		///</Summary>
		///<returns>
		///IList<IBOEmployeeTerritories>
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
				return _iEmployeeTerritoriesRepository.SelectAllByCriteriaProjection(lstDataProjection, lstDataCriteria, lstDataOrder, dataSkip, dataTake);
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
				IList<T> boEmployeeTerritoriesCollection = new List<T>();
				IList<IDataCriterion> lstDataCriteria = (icriteria == null) ? null : icriteria.ListDataCriteria();
				IList<IDataOrderBy> lstDataOrder = (icriteria == null) ? null : icriteria.ListDataOrder();
				IDataSkip dataSkip = (icriteria == null) ? null : icriteria.DataSkip();
				IDataTake dataTake = (icriteria == null) ? null : icriteria.DataTake();
				IList<IDAOEmployeeTerritories> daoEmployeeTerritoriesCollection = _iEmployeeTerritoriesRepository.SelectAllByCriteria(lstDataCriteria, lstDataOrder, dataSkip, dataTake);
				
				foreach(IDAOEmployeeTerritories resdaoEmployeeTerritories in daoEmployeeTerritoriesCollection)
					boEmployeeTerritoriesCollection.Add((T)(object)new BOEmployeeTerritories(resdaoEmployeeTerritories));
				
				return boEmployeeTerritoriesCollection;
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
		///This method returns the collection count of BOEmployeeTerritories objects, filtered by optional criteria
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
				List<IBOEmployeeTerritories> boEmployeeTerritoriesCollection = new List<IBOEmployeeTerritories>();
				IList<IDataCriterion> lstDataCriteria = (icriteria == null) ? null : icriteria.ListDataCriteria();
				Int32 objCount = _iEmployeeTerritoriesRepository.SelectAllByCriteriaCount(lstDataCriteria);
				
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
		public virtual IEmployeeTerritoriesRepository EmployeeTerritoriesRepository
		{
			set
			{
				_iEmployeeTerritoriesRepository = value;
			}
		}
		
		public virtual Int32? EmployeeID
		{
			get
			{
				 return _employeeID;
			}
			set
			{
				_employeeID = value;
				_isDirty = true;
			}
		}
		
		public virtual string TerritoryID
		{
			get
			{
				 return _territoryID;
			}
			set
			{
				_territoryID = value;
				_isDirty = true;
			}
		}
		
		[XmlIgnore]
		public virtual object Repository
		{
			get {	return (object) _iEmployeeTerritoriesRepository;	}
			set {	EmployeeTerritoriesRepository = (IEmployeeTerritoriesRepository)value;	}
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