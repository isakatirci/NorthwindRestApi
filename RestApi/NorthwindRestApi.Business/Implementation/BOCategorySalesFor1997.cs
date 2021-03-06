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
	///This is the definition of the class BOCategorySalesFor1997.
	///</Summary>
	public partial class BOCategorySalesFor1997 : zNorthwindRestApiConn_BaseBusiness, IBOCategorySalesFor1997, IQueryableCollection
	{
		#region member variables
		protected string _categoryName;
		protected decimal? _categorySales;
		protected bool _isDirty = false;
		/*collection member objects*******************/
		/*********************************************/
		/*repositories*********************************/
		protected ICategorySalesFor1997Repository _iCategorySalesFor1997Repository;
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
		public BOCategorySalesFor1997()
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
		///DAOCategorySalesFor1997
		///</parameters>
		protected internal BOCategorySalesFor1997(IDAOCategorySalesFor1997 daoCategorySalesFor1997)
		{
			try
			{
				_categoryName = daoCategorySalesFor1997.CategoryName;
				_categorySales = daoCategorySalesFor1997.CategorySales;
			}
			catch
			{
				throw;
			}
		}

		
		///<Summary>
		///CategorySalesFor1997Collection
		///This method returns the collection of BOCategorySalesFor1997 objects
		///</Summary>
		///<returns>
		///IList[IBOCategorySalesFor1997]
		///</returns>
		///<parameters>
		///
		///</parameters>
		public static IList<IBOCategorySalesFor1997> CategorySalesFor1997Collection(ICategorySalesFor1997Repository iCategorySalesFor1997Repository)
		{
			Doing(null);
			try
			{
				IList<IBOCategorySalesFor1997> boCategorySalesFor1997Collection = new List<IBOCategorySalesFor1997>();
				IList<IDAOCategorySalesFor1997> daoCategorySalesFor1997Collection = iCategorySalesFor1997Repository.SelectAll();
				Done(null);
				
				foreach(IDAOCategorySalesFor1997 daoCategorySalesFor1997 in daoCategorySalesFor1997Collection)
					boCategorySalesFor1997Collection.Add(new BOCategorySalesFor1997(daoCategorySalesFor1997));
				
				return boCategorySalesFor1997Collection;
			}
			catch(Exception ex)
			{
				Failed(null, ex);
				Handle(null, ex);
				return null;
			}
		}
		
		
		///<Summary>
		///CategorySalesFor1997CollectionCount
		///This method returns the collection count of BOCategorySalesFor1997 objects
		///</Summary>
		///<returns>
		///Int32
		///</returns>
		///<parameters>
		///
		///</parameters>
		public static Int32 CategorySalesFor1997CollectionCount(ICategorySalesFor1997Repository iCategorySalesFor1997Repository)
		{
			Doing(null);
			try
			{
				Int32 objCount = iCategorySalesFor1997Repository.SelectAllCount();
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
		///CategorySalesFor1997CollectionFromCriteria
		///This method returns the collection of projections, ordered and filtered by optional criteria
		///</Summary>
		///<returns>
		///IList<IBOCategorySalesFor1997>
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
				return _iCategorySalesFor1997Repository.SelectAllByCriteriaProjection(lstDataProjection, lstDataCriteria, lstDataOrder, dataSkip, dataTake);
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
				IList<T> boCategorySalesFor1997Collection = new List<T>();
				IList<IDataCriterion> lstDataCriteria = (icriteria == null) ? null : icriteria.ListDataCriteria();
				IList<IDataOrderBy> lstDataOrder = (icriteria == null) ? null : icriteria.ListDataOrder();
				IDataSkip dataSkip = (icriteria == null) ? null : icriteria.DataSkip();
				IDataTake dataTake = (icriteria == null) ? null : icriteria.DataTake();
				IList<IDAOCategorySalesFor1997> daoCategorySalesFor1997Collection = _iCategorySalesFor1997Repository.SelectAllByCriteria(lstDataCriteria, lstDataOrder, dataSkip, dataTake);
				
				foreach(IDAOCategorySalesFor1997 resdaoCategorySalesFor1997 in daoCategorySalesFor1997Collection)
					boCategorySalesFor1997Collection.Add((T)(object)new BOCategorySalesFor1997(resdaoCategorySalesFor1997));
				
				return boCategorySalesFor1997Collection;
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
		///This method returns the collection count of BOCategorySalesFor1997 objects, filtered by optional criteria
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
				List<IBOCategorySalesFor1997> boCategorySalesFor1997Collection = new List<IBOCategorySalesFor1997>();
				IList<IDataCriterion> lstDataCriteria = (icriteria == null) ? null : icriteria.ListDataCriteria();
				Int32 objCount = _iCategorySalesFor1997Repository.SelectAllByCriteriaCount(lstDataCriteria);
				
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
		public virtual ICategorySalesFor1997Repository CategorySalesFor1997Repository
		{
			set
			{
				_iCategorySalesFor1997Repository = value;
			}
		}
		
		public virtual string CategoryName
		{
			get
			{
				 return _categoryName;
			}
			set
			{
				_categoryName = value;
				_isDirty = true;
			}
		}
		
		public virtual decimal? CategorySales
		{
			get
			{
				 return _categorySales;
			}
			set
			{
				_categorySales = value;
				_isDirty = true;
			}
		}
		
		[XmlIgnore]
		public virtual object Repository
		{
			get {	return (object) _iCategorySalesFor1997Repository;	}
			set {	CategorySalesFor1997Repository = (ICategorySalesFor1997Repository)value;	}
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
