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
	///This is the definition of the class BORegion.
	///It maintains a collection of BOTerritories objects.
	///</Summary>
	public partial class BORegion : zNorthwindRestApiConn_BaseBusiness, IBORegion, IQueryableCollection, IUnitOfWorkEntity
	{
		#region member variables
		protected Int32? _regionID;
		protected string _regionDescription;
		protected Int32? _ctrVersion;
		protected bool _isDirty = false;
		/*collection member objects*******************/
		List<IBOTerritories> _boTerritoriesCollection;
		/*********************************************/
		/*repositories*********************************/
		protected IRegionRepository _iRegionRepository;
		protected ITerritoriesRepository _iTerritoriesRepository;
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
		public BORegion()
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
		///Int32 regionID
		///</parameters>
		public void Init(Int32 regionID)
		{
			try
			{
				IDAORegion daoRegion = _iRegionRepository.SelectOne(regionID);
				_regionID = daoRegion.RegionID;
				_regionDescription = daoRegion.RegionDescription;
				_ctrVersion = daoRegion.CtrVersion;
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
		///DAORegion
		///</parameters>
		protected internal BORegion(IDAORegion daoRegion)
		{
			try
			{
				_regionID = daoRegion.RegionID;
				_regionDescription = daoRegion.RegionDescription;
				_ctrVersion = daoRegion.CtrVersion;
			}
			catch
			{
				throw;
			}
		}

		///<Summary>
		///SaveNew
		///This method persists a new Region record to the store
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
			IDAORegion daoRegion = _iRegionRepository.New();
			RegisterDataObject( _iRegionRepository, _iRegionRepository.BaseData(daoRegion));
			BeginTransaction( _iRegionRepository, "savenewBORegion");
			try
			{
				daoRegion.RegionID = _regionID;
				daoRegion.RegionDescription = _regionDescription;
				_iRegionRepository.Insert(daoRegion);
				CommitTransaction( _iRegionRepository);
				Done(this);
				
				_regionID = daoRegion.RegionID;
				_regionDescription = daoRegion.RegionDescription;
				_ctrVersion = daoRegion.CtrVersion;
				_isDirty = false;
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				RollbackTransaction(_iRegionRepository, "savenewBORegion");
				Handle(this, ex);
			}
		}
		///<Summary>
		///Update
		///This method updates one Region record in the store
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///BORegion
		///</parameters>
		public virtual void Update()
		{
			Doing(this);
			IDAORegion daoRegion = _iRegionRepository.New();
			RegisterDataObject(_iRegionRepository, _iRegionRepository.BaseData(daoRegion));
			BeginTransaction(_iRegionRepository, "updateBORegion");
			try
			{
				daoRegion.RegionID = _regionID;
				daoRegion.RegionDescription = _regionDescription;
				daoRegion.CtrVersion = _ctrVersion;
				_iRegionRepository.Update(daoRegion);
				CommitTransaction(_iRegionRepository);
				Done(this);
				
				_regionID = daoRegion.RegionID;
				_regionDescription = daoRegion.RegionDescription;
				_ctrVersion = daoRegion.CtrVersion;
				_isDirty = false;
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				RollbackTransaction(_iRegionRepository, "updateBORegion");
				Handle(this, ex);
			}
		}
		///<Summary>
		///Delete
		///This method deletes one Region record from the store
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
			IDAORegion daoRegion = _iRegionRepository.New();
			RegisterDataObject(_iRegionRepository, _iRegionRepository.BaseData(daoRegion));
			BeginTransaction(_iRegionRepository, "deleteBORegion");
			try
			{
				daoRegion.RegionID = _regionID;
				_iRegionRepository.Delete(daoRegion);
				CommitTransaction(_iRegionRepository);
				Done(this);
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				RollbackTransaction(_iRegionRepository, "deleteBORegion");
				Handle(this, ex);
			}
		}
		
		///<Summary>
		///RegionCollection
		///This method returns the collection of BORegion objects
		///</Summary>
		///<returns>
		///IList[IBORegion]
		///</returns>
		///<parameters>
		///
		///</parameters>
		public static IList<IBORegion> RegionCollection(IRegionRepository iRegionRepository)
		{
			Doing(null);
			try
			{
				IList<IBORegion> boRegionCollection = new List<IBORegion>();
				IList<IDAORegion> daoRegionCollection = iRegionRepository.SelectAll();
				Done(null);
				
				foreach(IDAORegion daoRegion in daoRegionCollection)
					boRegionCollection.Add(new BORegion(daoRegion));
				
				return boRegionCollection;
			}
			catch(Exception ex)
			{
				Failed(null, ex);
				Handle(null, ex);
				return null;
			}
		}
		
		
		///<Summary>
		///RegionCollectionCount
		///This method returns the collection count of BORegion objects
		///</Summary>
		///<returns>
		///Int32
		///</returns>
		///<parameters>
		///
		///</parameters>
		public static Int32 RegionCollectionCount(IRegionRepository iRegionRepository)
		{
			Doing(null);
			try
			{
				Int32 objCount = iRegionRepository.SelectAllCount();
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
		///RegionCollectionFromCriteria
		///This method returns the collection of projections, ordered and filtered by optional criteria
		///</Summary>
		///<returns>
		///IList<IBORegion>
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
				return _iRegionRepository.SelectAllByCriteriaProjection(lstDataProjection, lstDataCriteria, lstDataOrder, dataSkip, dataTake);
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
				IList<T> boRegionCollection = new List<T>();
				IList<IDataCriterion> lstDataCriteria = (icriteria == null) ? null : icriteria.ListDataCriteria();
				IList<IDataOrderBy> lstDataOrder = (icriteria == null) ? null : icriteria.ListDataOrder();
				IDataSkip dataSkip = (icriteria == null) ? null : icriteria.DataSkip();
				IDataTake dataTake = (icriteria == null) ? null : icriteria.DataTake();
				IList<IDAORegion> daoRegionCollection = _iRegionRepository.SelectAllByCriteria(lstDataCriteria, lstDataOrder, dataSkip, dataTake);
				
				foreach(IDAORegion resdaoRegion in daoRegionCollection)
					boRegionCollection.Add((T)(object)new BORegion(resdaoRegion));
				
				return boRegionCollection;
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
		///This method returns the collection count of BORegion objects, filtered by optional criteria
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
				List<IBORegion> boRegionCollection = new List<IBORegion>();
				IList<IDataCriterion> lstDataCriteria = (icriteria == null) ? null : icriteria.ListDataCriteria();
				Int32 objCount = _iRegionRepository.SelectAllByCriteriaCount(lstDataCriteria);
				
				return objCount;
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				Handle(this, ex);
				return -1;
			}
		}
		
		///<Summary>
		///TerritoriesCollection
		///This method returns its collection of BOTerritories objects
		///</Summary>
		///<returns>
		///IList[IBOTerritories]
		///</returns>
		///<parameters>
		///BORegion
		///</parameters>
		public virtual IList<IBOTerritories> TerritoriesCollection()
		{
			Doing(this);
			try
			{
				if(_boTerritoriesCollection == null)
					LoadTerritoriesCollection();
				return _boTerritoriesCollection.AsReadOnly();
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				Handle(this, ex);
				return null;
			}
		}
		
		///<Summary>
		///LoadTerritoriesCollection
		///This method loads the internal collection of BOTerritories objects from storage. 
		///Call this if you need to ensure the collection is up-to-date (concurrency)
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		public virtual void LoadTerritoriesCollection()
		{
			Doing(this);
			try
			{
				_boTerritoriesCollection = new List<IBOTerritories>();
				IList<IDAOTerritories> daoTerritoriesCollection = _iTerritoriesRepository.SelectAllByRegionID(_regionID.Value);
				Done(this);
				
				foreach(IDAOTerritories daoTerritories in daoTerritoriesCollection)
					_boTerritoriesCollection.Add(new BOTerritories(daoTerritories));
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				Handle(this, ex);
			}
		}
		
		///<Summary>
		///AddTerritories
		///This method persists a BOTerritories object to the database collection
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///BOTerritories
		///</parameters>
		public virtual void AddTerritories(IBOTerritories boTerritories)
		{
			Doing(this);
			IDAOTerritories daoTerritories = _iTerritoriesRepository.New();
			RegisterDataObject(_iTerritoriesRepository, _iTerritoriesRepository.BaseData(daoTerritories));
			BeginTransaction(_iTerritoriesRepository, "addTerritories");
			try
			{
				daoTerritories.TerritoryID = boTerritories.TerritoryID;
				daoTerritories.TerritoryDescription = boTerritories.TerritoryDescription;
				daoTerritories.RegionID = _regionID.Value;
				_iTerritoriesRepository.Insert(daoTerritories);
				CommitTransaction(_iTerritoriesRepository);
				Done(this);
				
				/*pick up any primary keys, computed values etc*/
				boTerritories = new BOTerritories(daoTerritories);
				if(_boTerritoriesCollection != null)
					_boTerritoriesCollection.Add(boTerritories);
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				RollbackTransaction(_iTerritoriesRepository, "addTerritories");
				Handle(this, ex);
			}
		}
		
		///<Summary>
		///DeleteAllTerritories
		///This method deletes all BOTerritories objects from its collection
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		public virtual void DeleteAllTerritories()
		{
			Doing(this);
			RegisterDataObject(_iTerritoriesRepository, null);
			BeginTransaction(_iTerritoriesRepository, "deleteAllTerritories");
			try
			{
				_iTerritoriesRepository.DeleteAllByRegionID(_regionID.Value);
				CommitTransaction(_iTerritoriesRepository);
				Done(this);
				if(_boTerritoriesCollection != null)
				{
					_boTerritoriesCollection.Clear();
					_boTerritoriesCollection = null;
				}
			}
			catch(Exception ex)
			{
				Failed(this, ex);
				RollbackTransaction(_iTerritoriesRepository, "deleteAllTerritories");
				Handle(this, ex);
			}
		}
		
		#endregion

		#region member properties
		
		[InjectionPoint]
		[XmlIgnore]
		public virtual IRegionRepository RegionRepository
		{
			set
			{
				_iRegionRepository = value;
			}
		}
		
		[InjectionPoint]
		[XmlIgnore]
		public virtual ITerritoriesRepository TerritoriesRepository
		{
			set
			{
				_iTerritoriesRepository = value;
			}
		}
		
		public virtual Int32? RegionID
		{
			get
			{
				 return _regionID;
			}
			set
			{
				_regionID = value;
				_isDirty = true;
			}
		}
		
		public virtual string RegionDescription
		{
			get
			{
				 return _regionDescription;
			}
			set
			{
				_regionDescription = value;
				_isDirty = true;
			}
		}
		
		public virtual Int32? CtrVersion
		{
			get
			{
				 return _ctrVersion;
			}
			set
			{
				_ctrVersion = value;
			}
		}
		
		[XmlIgnore]
		public virtual object Repository
		{
			get {	return (object) _iRegionRepository;	}
			set {	RegionRepository = (IRegionRepository)value;	}
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
