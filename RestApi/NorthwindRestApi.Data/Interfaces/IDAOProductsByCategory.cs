/*************************************************************
** Class generated by CodeTrigger, Version 6.1.0.7
** This class was generated on 1.12.2018 19:31:12
** Changes to this file may cause incorrect behaviour and will be lost if the code is regenerated
**************************************************************/
using System;

namespace NorthwindRestApi.Data.Interfaces
{
	public partial interface IDAOProductsByCategory 
	{
		#region class methods





		#endregion

		#region member properties

		string CategoryName	{	get;	set;	}
		
		string ProductName	{	get;	set;	}
		
		string QuantityPerUnit	{	get;	set;	}
		
		Int16? UnitsInStock	{	get;	set;	}
		
		bool? Discontinued	{	get;	set;	}
		
		#endregion
	}
}
