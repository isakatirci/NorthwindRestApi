/*************************************************************
** Class generated by CodeTrigger, Version 6.1.0.7
** This class was generated on 1.12.2018 19:31:12
** Changes to this file may cause incorrect behaviour and will be lost if the code is regenerated
**************************************************************/
using System;

namespace NorthwindRestApi.Data.Interfaces
{
	public partial interface IDAOCategories 
	{
		#region class methods

		///<Summary>
		///Delete one row by primary key(s)
		///this method allows the object to delete itself from the table Categories based on its primary key
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		void Delete();

		///<Summary>
		///Insert a new row
		///This method saves a new object to the table Categories
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		void Insert();






		///<Summary>
		///Update one row by primary key(s)
		///This method allows the object to update itself in the table Categories based on its primary key(s)
		///</Summary>
		///<returns>
		///void
		///</returns>
		///<parameters>
		///
		///</parameters>
		void Update();

		#endregion

		#region member properties

		Int32? CategoryID	{	get;	set;	}
		
		string CategoryName	{	get;	set;	}
		
		string Description	{	get;	set;	}
		
		byte[] Picture	{	get;	set;	}
		
		Int32? CtrVersion	{	get;	set;	}
		
		#endregion
	}
}
