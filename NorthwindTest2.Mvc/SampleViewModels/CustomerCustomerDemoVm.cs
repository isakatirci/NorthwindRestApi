/*************************************************************
** Class generated by CodeTrigger, Version 6.1.0.7
** This class was generated on 1.12.2018 16:11:04
** Changes to this file may cause incorrect behaviour and will be lost if the code is regenerated
**************************************************************/
using System;
using NorthwindTest2.Business;
using NorthwindTest2.Business.Interfaces;
using NorthwindTest2.Business.Repository.Interfaces;

namespace NorthwindTest2.Mvc.SampleViewModels
{
	public partial class CustomerCustomerDemoVm
	{
		#region member properties
		
		public virtual string CustomerID { get; set;}
		
		public virtual string CustomerTypeID { get; set;}
		#endregion
		
		public CustomerCustomerDemoVm() {}
		
		public CustomerCustomerDemoVm(IBOCustomerCustomerDemo boCustomerCustomerDemo)
		{
			CustomerID = boCustomerCustomerDemo.CustomerID;
			CustomerTypeID = boCustomerCustomerDemo.CustomerTypeID;
		}
		
		public IBOCustomerCustomerDemo BOCustomerCustomerDemo()
		{
			var boCustomerCustomerDemo = new BOCustomerCustomerDemo()
			{
				CustomerID = this.CustomerID,
				CustomerTypeID = this.CustomerTypeID
			};
			return boCustomerCustomerDemo;
		}
		
		public IBOCustomerCustomerDemo BOCustomerCustomerDemo(ICustomerCustomerDemoRepository repo)
		{
			BOCustomerCustomerDemo boCustomerCustomerDemo = (BOCustomerCustomerDemo)BOCustomerCustomerDemo();
			boCustomerCustomerDemo.Repository = repo;
			return boCustomerCustomerDemo;
		}
	}
}