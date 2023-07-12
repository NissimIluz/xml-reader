using AdmonisTest.Admonis;
using AdmonisTest.Constants;
using AdmonisTest.Interfaces;
using AdmonisTest.Models;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace AdmonisTest.Services
{
    public class XMLReader1 : IXMLReader
    {
        public readonly DefaultsValues defaultsValues;
        public XMLReader1(IOptions<DefaultsValues> options)
        {
            defaultsValues = options.Value;
        }
        public IEnumerable<AdmonisProduct> Read(string filePath)
        {
            var reader = new XmlTextReader(filePath);
            IList<AdmonisProduct> admonisProducts = new List<AdmonisProduct>();
            {
                try
                {
                    while (reader.Read())
                    {
                        if (reader.IsStartElement("product"))
                        {
                            AdmonisProduct temp = MapProduct(ref reader);
                            admonisProducts.Add(temp);
                        }
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString(), ex.InnerException?.Message);
                    throw ex;
                }
                finally
                {
                    reader.Close();
                }
            }
            return admonisProducts;
        }


        public AdmonisProduct MapProduct(ref XmlTextReader reader)
        {

            var mapField = MapperDictionary.Field;

            AdmonisProduct retVal = new AdmonisProduct();
            Halper.Init<AdmonisProduct>(ref retVal, defaultsValues.AdmonisProduct);
            retVal.Makat = reader.GetAttribute("product-id");

            while (reader.Read() &&
                reader.Name != "product")
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    if (mapField.Count > 0)
                    {
                        string nodeName = reader.Name;
                        var keyValuePair = mapField.FirstOrDefault(mapper => mapper.Key == nodeName);

                        if (keyValuePair.Value != null)
                        {
                            keyValuePair.Value(retVal, reader.ReadInnerXml());
                            mapField.Remove(keyValuePair.Key);
                        }
                    }

                    if (reader.Name == "custom-attributes")
                    {
                        AdmonisProductOption admonisProductOption = new AdmonisProductOption();
                        Halper.Init<AdmonisProductOption>(ref admonisProductOption, defaultsValues.AdmonisProductOption);
                        retVal.Options = new List<AdmonisProductOption>() { admonisProductOption };
                        CustomAttributesMapper(ref reader, ref retVal);
                    }
                }
            }
            return retVal;
        }

        public void MapByAttributeId(ref XmlTextReader reader, ref AdmonisProduct admonisProduct,
        string node, Dictionary<string, Action<AdmonisProduct, string>> mapCustomAttribute)
        {
            while (reader.Read() &&
                reader.Name != node &&
                mapCustomAttribute.Count > 0)
            {
                string attributeId = reader.GetAttribute("attribute-id");
                var keyValuePair = mapCustomAttribute
                    .FirstOrDefault(mapper => mapper.Key == attributeId);

                if (keyValuePair.Value != null)
                {
                    keyValuePair.Value(admonisProduct, reader.ReadInnerXml());
                    mapCustomAttribute.Remove(keyValuePair.Key);
                }
            }
            while (reader.NodeType != XmlNodeType.EndElement && reader.Name != node && reader.Read()) { }
        }


        public void CustomAttributesMapper(ref XmlTextReader reader, ref AdmonisProduct product)
        {

            MapByAttributeId(ref reader, ref product, "custom-attributes", MapperDictionary.Attribute);
        }
    }
}