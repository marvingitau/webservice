using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplicationWebService
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        DataTable dtCountries = new DataTable();

        [WebMethod]
        public string HelloWorld()
        {
            //Console.ReadLine();
            return "Hello World";
        }

        [WebMethod]
        public int add(int a, int b)
        {
            return a+b;
        }

        [WebMethod]
        public string Countries()
        {
            dtCountries.Columns.Add("CountryName");
            dtCountries.Columns.Add("Continent");
            dtCountries.Rows.Add("Pakistan","Asia");
            dtCountries.Rows.Add("Chain","Asia");
            dtCountries.Rows.Add("Egypt","Africa");
            dtCountries.Rows.Add("Venezule","America");
            dtCountries.Rows.Add("Chad","Africa");
            dtCountries.Rows.Add("France","Europe");

            return JsonConvert.SerializeObject(dtCountries);

        }
    }
}
