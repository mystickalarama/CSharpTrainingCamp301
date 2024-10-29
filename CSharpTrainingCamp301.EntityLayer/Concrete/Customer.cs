﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTrainingCamp301.EntityLayer.Concrete
{
	internal class Customer
	{
		public int CustomerId { get; set; }
		public string CustomerName { get; set; }
		public string CustomerSurname { get; set; }
		public string CostomerDistrict { get; set; }
		public string CostomerCity { get; set; }
	}
}

/* 
 SOLID
-------------------------------
Single Responsibility

 */