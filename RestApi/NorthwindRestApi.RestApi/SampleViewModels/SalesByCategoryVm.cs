/*************************************************************
** Class generated by CodeTrigger, Version 6.1.0.7
** This class was generated on 1.12.2018 19:31:13
** Changes to this file may cause incorrect behaviour and will be lost if the code is regenerated
**************************************************************/
using System;
using NorthwindRestApi.Business;
using NorthwindRestApi.Business.Interfaces;
using NorthwindRestApi.Business.Repository.Interfaces;

namespace NorthwindRestApi.RestApi.SampleViewModels
{
	public partial class SalesByCategoryVm
	{
		#region member properties
		
		public virtual Int32? CategoryID { get; set;}
		
		public virtual string CategoryName { get; set;}
		
		public virtual string ProductName { get; set;}
		
		public virtual decimal? ProductSales { get; set;}
		#endregion
		
		public SalesByCategoryVm() {}
		
		public SalesByCategoryVm(IBOSalesByCategory boSalesByCategory)
		{
			CategoryID = boSalesByCategory.CategoryID;
			CategoryName = boSalesByCategory.CategoryName;
			ProductName = boSalesByCategory.ProductName;
			ProductSales = boSalesByCategory.ProductSales;
		}
		
		public IBOSalesByCategory BOSalesByCategory()
		{
			var boSalesByCategory = new BOSalesByCategory()
			{
				CategoryID = this.CategoryID,
				CategoryName = this.CategoryName,
				ProductName = this.ProductName,
				ProductSales = this.ProductSales
			};
			return boSalesByCategory;
		}
		
		public IBOSalesByCategory BOSalesByCategory(ISalesByCategoryRepository repo)
		{
			BOSalesByCategory boSalesByCategory = (BOSalesByCategory)BOSalesByCategory();
			boSalesByCategory.Repository = repo;
			return boSalesByCategory;
		}
	}
}
