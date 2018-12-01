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
	///This is the interface definition for the class BOEmployeeTerritories.
	///</Summary>
	public partial interface IBOEmployeeTerritories 
	{
		#region class methods
		
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
		void SaveNew();
		
		
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
		void Delete();
		
		#endregion

		#region member properties
		
		IEmployeeTerritoriesRepository EmployeeTerritoriesRepository	{	set;}
		
		Int32? EmployeeID	{	get;	set;}
		
		string TerritoryID	{	get;	set;}
		
		bool IsDirty	{	get;	set;}
		
		#endregion
	}
}