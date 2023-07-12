using AdmonisTest.Admonis;
using AdmonisTest.Constants;
using AdmonisTest.Interfaces;
using AdmonisTest.Models;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AdmonisTest.Services
{
    public class XMLReader2: IXMLReader
    {
        public readonly DefaultsValues defaultsValues;
        public XMLReader2(IOptions<DefaultsValues> options)
        {
            defaultsValues = options.Value;
        }
        public IEnumerable<AdmonisProduct> Read(string filePath)
        { 

            var catalogObject = GetRecordsXml<catalog>(filePath);
            ConcurrentBag<AdmonisProduct> admonisProducts = new ConcurrentBag<AdmonisProduct>();
            Parallel.ForEach(catalogObject.product, p =>
            {
                AdmonisProduct temp = MapToAdmonisProduct(p);
                admonisProducts.Add(temp);
            });
            return admonisProducts;
        }

        public AdmonisProduct MapToAdmonisProduct(catalogProduct p)
        {
            AdmonisProduct retVal = new AdmonisProduct();
            
            retVal.Name = p.displayname.Value;
            retVal.Description = p.shortdescription;
            retVal.DescriptionLong = p.longdescription;
            retVal.Brand = p.brand;
            retVal.VideoLink = p.customattributes.FirstOrDefault(x => x.attributeid == "f54ProductVideo")?.value?.FirstOrDefault();

            AdmonisProductOption admonisProductOption = new AdmonisProductOption();
            Halper.Init<AdmonisProductOption>(ref admonisProductOption, defaultsValues.AdmonisProductOption);

            admonisProductOption.optionSugName2 = p.customattributes.FirstOrDefault(x => x.attributeid == "f54ProductColor")?.value?.FirstOrDefault();
            admonisProductOption.optionName =  p.customattributes.FirstOrDefault(x => x.attributeid == "f54ProductSize")?.value?.FirstOrDefault();
            retVal.Options = new List<AdmonisProductOption>() { admonisProductOption };

            return retVal;
        }



        internal static T GetRecordsXml<T>(string filePath, string xmlNamespace = null) where T : class
        {
            try
            {
                XmlSerializer serializer;
                if (xmlNamespace == null)
                {
                    serializer = new XmlSerializer(typeof(T));
                }
                else
                {
                    serializer = new XmlSerializer(typeof(T), xmlNamespace);
                }

                var memoryStream = new MemoryStream();
                using (StreamReader fs = new StreamReader(File.OpenRead(filePath)))
                {
                    return (T)serializer.Deserialize(fs);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}