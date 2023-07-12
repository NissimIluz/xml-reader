
using AdmonisTest.Admonis;
using AdmonisTest.Interfaces;
using AdmonisTest.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdmonisTest.Services
{
    public class App : IApp
    {
        public readonly IEnumerable<IXMLReader> xmlReaders;
        public readonly AppSettings appSettings;
        public App(IEnumerable<IXMLReader> xMLReaders, IOptions<AppSettings> options)
        { 
            this.xmlReaders = xMLReaders;
            this.appSettings = options.Value;
        }

        public void Run()
        {
            string filePath = System.IO.Path.Combine(
                !string.IsNullOrEmpty(appSettings.FilePath) ? appSettings.FilePath :
                System.IO.Path.GetDirectoryName(Directory.GetParent(AppContext.BaseDirectory).Parent.FullName),
                appSettings.FileName);

            IEnumerable <AdmonisProduct> option1 = xmlReaders.First().Read(filePath);
            IEnumerable<AdmonisProduct> option2 = xmlReaders.Last().Read(filePath);
        }

    }
}
