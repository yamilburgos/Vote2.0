﻿using System.Web;
using System.Web.Mvc;

namespace Vote_2._0
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}
