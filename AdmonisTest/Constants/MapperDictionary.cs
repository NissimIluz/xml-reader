using AdmonisTest.Admonis;
using System.Collections.Generic;
using System;
using System.Linq;

namespace AdmonisTest.Interfaces
{
    public class MapperDictionary
    {
        public readonly static Dictionary<string, Action<AdmonisProduct, string>> Attribute =
            new Dictionary<string, Action<AdmonisProduct, string>>
            {
                { "f54ProductVideo", (admonisProduct, value) => admonisProduct.VideoLink = value},
                { "f54ProductSize", (admonisProduct, value) => admonisProduct.Options.First().optionName = value},
                { "f54ProductColor", (admonisProduct, value) => admonisProduct.Options.First().optionSugName2 = value},
            };
        public readonly static Dictionary<string, Action<AdmonisProduct, string>> Field =
            new Dictionary<string, Action<AdmonisProduct, string>>
            {
                { "display-name", (admonisProduct, value) => admonisProduct.Name = value },
                { "short-description", (admonisProduct, value) => admonisProduct.Description = value },
                { "long-description", (admonisProduct, value) => admonisProduct.DescriptionLong = value},
                { "brand", (admonisProduct, value) => admonisProduct.Brand = value}
            };
    }
}
