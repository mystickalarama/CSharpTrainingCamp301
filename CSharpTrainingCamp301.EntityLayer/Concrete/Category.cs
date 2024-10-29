﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTrainingCamp301.EntityLayer.Concrete
{
	public class Category
	{
		public int CategoryId { get; set; }
		public string CategoryName { get; set; }
		public bool CategoryStatus { get; set; }
	}
}
/* 
 Field - Variable - Property
 */

/*
 inx x; --> Field

void test()
{
	int z;  --> Variable
}

public int y {get; set;} --> Property
 */