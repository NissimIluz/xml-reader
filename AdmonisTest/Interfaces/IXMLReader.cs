using AdmonisTest.Admonis;
using System.Collections.Generic;

namespace AdmonisTest.Interfaces
{
    public interface IXMLReader
    {
        IEnumerable<AdmonisProduct> Read(string filePath);
    }
}
