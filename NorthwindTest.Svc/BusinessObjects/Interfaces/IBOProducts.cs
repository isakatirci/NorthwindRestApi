/*************************************************************
** Class generated by CodeTrigger, Version 6.1.0.7
** This class was generated on 1.12.2018 16:26:30
** Changes to this file may cause incorrect behaviour and will be lost if the code is regenerated
**************************************************************/
using System;
using System.Collections.Generic;
using NorthwindTest.DataObjects.Interfaces;
using NorthwindTest.BusinessObjects.Repository.Interfaces;

namespace NorthwindTest.BusinessObjects.Interfaces
{
	///<Summary>
	///Interface definition
	///This is the interface definition for the class BOProducts.
	///</Summary>
	public partial interface IBOProducts 
	{
		#region class methods
		
		///<Summary>
		///SaveNew
		///This method persists a new Products record to the store
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		void SaveNew();
		
		///<Summary>
		///Update
		///This method updates one Products record in the store
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///BOProducts
		///</parameters>
		void Update();
		
		///<Summary>
		///Delete
		///This method deletes one Products record from the store
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		void Delete();
		
		///<Summary>
		///OrderDetailsCollection
		///This method returns its collection of BOOrderDetails objects
		///</Summary>
		///<returns>
		///IList[IBOOrderDetails]
		///</returns>
		///<parameters>
		///BOProducts
		///</parameters>
		IList<IBOOrderDetails> OrderDetailsCollection();
		
		///<Summary>
		///LoadOrderDetailsCollection
		///This method loads the internal collection of BOOrderDetails objects from storage. 
		///Call this if you need to ensure the collection is up-to-date (concurrency)
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		void LoadOrderDetailsCollection();
		
		///<Summary>
		///AddOrderDetails
		///This method persists a BOOrderDetails object to the database collection
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///BOOrderDetails
		///</parameters>
		void AddOrderDetails(IBOOrderDetails boOrderDetails);
		
		///<Summary>
		///DeleteAllOrderDetails
		///This method deletes all BOOrderDetails objects from its collection
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		void DeleteAllOrderDetails();
		
		#endregion

		#region member properties
		
		IProductsRepository ProductsRepository	{	set;}
		
		IOrderDetailsRepository OrderDetailsRepository	{	set;}
		
		Int32? ProductID	{	get;	set;}
		
		string ProductName	{	get;	set;}
		
		Int32? SupplierID	{	get;	set;}
		
		Int32? CategoryID	{	get;	set;}
		
		string QuantityPerUnit	{	get;	set;}
		
		decimal? UnitPrice	{	get;	set;}
		
		Int16? UnitsInStock	{	get;	set;}
		
		Int16? UnitsOnOrder	{	get;	set;}
		
		Int16? ReorderLevel	{	get;	set;}
		
		bool? Discontinued	{	get;	set;}
		
		Int32? CtrVersion	{	get;	}
		
		bool IsDirty	{	get;	set;}
		
		#endregion
	}
}