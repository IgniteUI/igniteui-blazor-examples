//begin data
    using System;
    using System.Collections.Generic;
    using System.Text.Json;
    using System.Collections.ObjectModel;
    using IgniteUI.Blazor.Controls;

    public class RetailSalesPerformanceLocalDataSource : IgbLocalDataSource
    {

        public RetailSalesPerformanceLocalDataSource(){
			this.DataSource = CodeGenHelper.FindByName<IList>("RetailSalesPerformanceData");
		}

    }

    //end data