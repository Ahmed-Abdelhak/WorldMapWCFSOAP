using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using ExtendedXmlSerializer.Configuration;
using ExtendedXmlSerializer.ExtensionModel.Xml;
using WorldMap.Custom_Serialization;
using WorldMap.POCOS;

namespace WorldMap
{
    /// <summary>
    /// Summary description for WebServiceSoap
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceSoap : System.Web.Services.WebService
    {
        private CountryCitiesDBEntities _context;

        public WebServiceSoap()
        {
            _context = new CountryCitiesDBEntities();
        }

        [WebMethod]
        public string GetCountries()
        {


            //IExtendedXmlSerializer sz = new ConfigurationContainer().UseOptimizedNamespaces().Type<Country>()
            //    .CustomSerializer(new CountryCustom()).EnableReferences(p => p.Id).EnableReferences(p => p.Id).EnableReferences(p => p.Cities)
            //        .Member(p => p.Id).Name("Id")
            //        .Member(p => p.Name).Name("CountryName")
            //        .Member(p => p.Cities).Name("Cities")
            //    .Create();

            IExtendedXmlSerializer sz = new ConfigurationContainer().UseOptimizedNamespaces().ConfigureType<CountryPOCO>()
                .EnableReferences(p => p.Id).EnableReferences(p => p.Id).EnableReferences(p => p.Cities)
                .Member(p => p.Id).Name("Id")
                .Member(p => p.Name).Name("CountryName")
                .Member(p => p.Cities).Name("Cities")
                .Create();

            var obj = _context.Countries.ToList();


            var xml = sz.Serialize(obj);

            return xml;

        }
    }
}

