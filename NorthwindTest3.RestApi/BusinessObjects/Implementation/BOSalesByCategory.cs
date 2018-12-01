/*************************************************************
** Class generated by CodeTrigger, Version 6.1.0.7
** This class was generated on 1.12.2018 16:31:22
** Changes to this file may cause incorrect behaviour and will be lost if the code is regenerated
**************************************************************/
using System;
using System.Collections.Generic;
using NorthwindTest3.DataObjects;
using NorthwindTest3.DataObjects.Interfaces;
using NorthwindTest3.BusinessObjects.Interfaces;

namespace NorthwindTest3.BusinessObjects
{
	///<Summary>
	///Class definition
	///This is the definition of the class BOSalesByCategory.
	///</Summary>
	public partial class BOSalesByCategory : zNorthwindTest3Conn_BaseBusiness, IQueryableCollection
	{
		#region member variables
		protected Int32? _categoryID;
		protected string _categoryName;
		protected string _productName;
		protected decimal? _productSales;
		protected bool _isDirty = false;
		/*collection member objects*******************/
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
		public BOSalesByCategory()
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
		///DAOSalesByCategory
		///</parameters>
		protected internal BOSalesByCategory(DAOSalesByCategory daoSalesByCategory)
		{
			try
			{
				_categoryID = daoSalesByCategory.CategoryID;
				_categoryName = daoSalesByCategory.CategoryName;
				_productName = daoSalesByCategory.ProductName;
				_productSales = daoSalesByCategory.ProductSales;
			}
			catch
			{
				throw;
			}
		}

		
		///<Summary>
		///SalesByCategoryCollection
		///This method returns the collection of BOSalesByCategory objects
		///</Summary>
		///<returns>
		///List[BOSalesByCategory]
		///</returns>
		///<parameters>
		///
		///</parameters>
		public static IList<BOSalesByCategory> SalesByCategoryCollection()
		{
			try
			{
				IList<BOSalesByCategory> boSalesByCategoryCollection = new List<BOSalesByCategory>();
				IList<DAOSalesByCategory> daoSalesByCategoryCollection = DAOSalesByCategory.SelectAll();
			
				foreach(DAOSalesByCategory daoSalesByCategory in daoSalesByCategoryCollection)
					boSalesByCategoryCollection.Add(new BOSalesByCategory(daoSalesByCategory));
			
				return boSalesByCategoryCollection;
			}
			catch
			{
				throw;
			}
		}
		
		
		///<Summary>
		///SalesByCategoryCollectionCount
		///This method returns the collection count of BOSalesByCategory objects
		///</Summary>
		///<returns>
		///Int32
		///</returns>
		///<parameters>
		///
		///</parameters>
		public static Int32 SalesByCategoryCollectionCount()
		{
			try
			{
				Int32 objCount = DAOSalesByCategory.SelectAllCount();
				return objCount;
			}
			catch
			{
				throw;
			}
		}
		
		
		///<Summary>
		///Projections
		///This method returns the collection of projections, ordered and filtered by optional criteria
		///</Summary>
		///<returns>
		///List<BOSalesByCategory>
		///</returns>
		///<parameters>
		///ICriteria icriteria
		///</parameters>
		public virtual IDictionary<string, IList<object>> Projections(object o)
		{
			try
			{
				ICriteria icriteria = (ICriteria)o;
				IList<IDataProjection> lstDataProjection = (icriteria == null) ? null : icriteria.ListDataProjection();
				IList<IDataCriterion> lstDataCriteria = (icriteria == null) ? null : icriteria.ListDataCriteria();
				IList<IDataOrderBy> lstDataOrder = (icriteria == null) ? null : icriteria.ListDataOrder();
				IDataTake dataTake = (icriteria == null) ? null : icriteria.DataTake();
				IDataSkip dataSkip = (icriteria == null) ? null : icriteria.DataSkip();
				IDictionary<string, IList<object>> retObj = DAOSalesByCategory.SelectAllByCriteriaProjection(lstDataProjection, lstDataCriteria, lstDataOrder, dataSkip, dataTake);
				return retObj;
			}
			catch
			{
				throw;
			}
		}
		
		
		///<Summary>
		///SalesByCategoryCollection<T>
		///This method implements the IQueryable Collection<T> method, returning a collection of BOSalesByCategory objects, filtered by optional criteria
		///</Summary>
		///<returns>
		///IList<T>
		///</returns>
		///<parameters>
		///object o
		///</parameters>
		public virtual IList<T> Collection<T>(object o)
		{
			try
			{
				ICriteria icriteria = (ICriteria)o;
				IList<T> boSalesByCategoryCollection = new List<T>();
				IList<IDataCriterion> lstDataCriteria = (icriteria == null) ? null : icriteria.ListDataCriteria();
				IList<IDataOrderBy> lstDataOrder = (icriteria == null) ? null : icriteria.ListDataOrder();
				IDataTake dataTake = (icriteria == null) ? null : icriteria.DataTake();
				IDataSkip dataSkip = (icriteria == null) ? null : icriteria.DataSkip();
				IList<DAOSalesByCategory> daoSalesByCategoryCollection = DAOSalesByCategory.SelectAllByCriteria(lstDataCriteria, lstDataOrder, dataSkip, dataTake);
			
				foreach(DAOSalesByCategory resdaoSalesByCategory in daoSalesByCategoryCollection)
					boSalesByCategoryCollection.Add((T)(object)new BOSalesByCategory(resdaoSalesByCategory));
			
				return boSalesByCategoryCollection;
			}
			catch
			{
				throw;
			}
		}
		
		
		///<Summary>
		///SalesByCategoryCollectionCount
		///This method implements the IQueryable CollectionCount method, returning a collection count of BOSalesByCategory objects, filtered by optional criteria
		///</Summary>
		///<returns>
		///Int32
		///</returns>
		///<parameters>
		///object o
		///</parameters>
		public virtual Int32 CollectionCount(object o)
		{
			try
			{
				ICriteria icriteria = (ICriteria)o;
				IList<IDataCriterion> lstDataCriteria = (icriteria == null) ? null : icriteria.ListDataCriteria();
				Int32 objCount = DAOSalesByCategory.SelectAllByCriteriaCount(lstDataCriteria);
				return objCount;
			}
			catch
			{
				throw;
			}
		}
		
		#endregion

		#region member properties
		
		public virtual Int32? CategoryID
		{
			get
			{
				 return _categoryID;
			}
			set
			{
				_categoryID = value;
				_isDirty = true;
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
		
		public virtual string ProductName
		{
			get
			{
				 return _productName;
			}
			set
			{
				_productName = value;
				_isDirty = true;
			}
		}
		
		public virtual decimal? ProductSales
		{
			get
			{
				 return _productSales;
			}
			set
			{
				_productSales = value;
				_isDirty = true;
			}
		}
		
		public virtual object Repository
		{
			get {	return null;	}
			set	{	}
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