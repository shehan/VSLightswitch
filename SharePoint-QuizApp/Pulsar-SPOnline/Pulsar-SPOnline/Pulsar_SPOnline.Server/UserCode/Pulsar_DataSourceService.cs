using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Security.Server;
namespace LightSwitchApplication
{
    public partial class Pulsar_DataSourceService
    {

        partial void Query_GetQuestion_PreprocessQuery(string SelectedCategory_Parameter, ref IQueryable<Question> query)
        {
            query = query.Take(1); 
        }
    }
}
