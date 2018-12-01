/*************************************************************
** Class generated by CodeTrigger, Version 6.1.0.7
** This class was generated on 1.12.2018 16:31:23
** Changes to this file may cause incorrect behaviour and will be lost if the code is regenerated
**************************************************************/
using System;
using NorthwindTest3.BusinessObjects;

namespace NorthwindTest3.RestApi.SampleViewModels
{
	public partial class EmployeeTerritoriesVm
	{
		#region member properties
		
		public virtual Int32? EmployeeID { get; set;}
		
		public virtual string TerritoryID { get; set;}
		#endregion
		
		public EmployeeTerritoriesVm() {}
		
		public EmployeeTerritoriesVm(BOEmployeeTerritories boEmployeeTerritories)
		{
			EmployeeID = boEmployeeTerritories.EmployeeID;
			TerritoryID = boEmployeeTerritories.TerritoryID;
		}
		
		public BOEmployeeTerritories BOEmployeeTerritories()
		{
			var boEmployeeTerritories = new BOEmployeeTerritories()
			{
				EmployeeID = this.EmployeeID,
				TerritoryID = this.TerritoryID
			};
			return boEmployeeTerritories;
		}
	}
}