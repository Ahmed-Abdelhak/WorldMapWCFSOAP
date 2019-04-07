using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Xml;
using System.Xml.Linq;
using ExtendedXmlSerializer.ExtensionModel.Xml;
using WorldMap.POCOS;

namespace WorldMap.Custom_Serialization
{
    public class CountryCustom:IExtendedXmlCustomSerializer<Country>
    {
        public Country Deserialize(XElement xElement)
        {
            throw new NotImplementedException();
        }

        public void Serializer(XmlWriter writer, Country obj)
        {
            writer.WriteElementString("String", obj.Name);
            writer.WriteElementString("String", obj.Cities.ToString());
            writer.WriteElementString("Int", obj.Id.ToString(CultureInfo.InvariantCulture));
        }
    }
}