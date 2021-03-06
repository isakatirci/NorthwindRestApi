/*************************************************************
** Class generated by CodeTrigger, Version 6.1.0.7
** This class was generated on 1.12.2018 19:31:12
** Changes to this file may cause incorrect behaviour and will be lost if the code is regenerated
**************************************************************/
using System;
using System.Collections.Generic;
using NorthwindRestApi.Data.Interfaces;
using NorthwindRestApi.Business.Repository.Interfaces;

namespace NorthwindRestApi.Business.Interfaces
{
	///<Summary>
	///Interface definition
	///This is the interface definition for the class BOOrders.
	///</Summary>
	public partial interface IBOOrders 
	{
		#region class methods
		
		///<Summary>
		///SaveNew
		///This method persists a new Orders record to the store
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
		///This method updates one Orders record in the store
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///BOOrders
		///</parameters>
		void Update();
		
		///<Summary>
		///Delete
		///This method deletes one Orders record from the store
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
		///BOOrders
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
		
		IOrdersRepository OrdersRepository	{	set;}
		
		IOrderDetailsRepository OrderDetailsRepository	{	set;}
		
		Int32? OrderID	{	get;	set;}
		
		string CustomerID	{	get;	set;}
		
		Int32? EmployeeID	{	get;	set;}
		
		DateTime? OrderDate	{	get;	set;}
		
		DateTime? RequiredDate	{	get;	set;}
		
		DateTime? ShippedDate	{	get;	set;}
		
		Int32? ShipVia	{	get;	set;}
		
		decimal? Freight	{	get;	set;}
		
		string ShipName	{	get;	set;}
		
		string ShipAddress	{	get;	set;}
		
		string ShipCity	{	get;	set;}
		
		string ShipRegion	{	get;	set;}
		
		string ShipPostalCode	{	get;	set;}
		
		string ShipCountry	{	get;	set;}
		
		Int32? CtrVersion	{	get;	}
		
		bool IsDirty	{	get;	set;}
		
		#endregion
	}
}
