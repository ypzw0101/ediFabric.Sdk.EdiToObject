using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EdiFabric.Sdk.EdiToObject.CustomClasses.Edifact;
using EdiFabric.Sdk.EdiToObject.CustomClasses.X12;

namespace EdiFabric.Sdk.EdiToObject.ConsoleApplication
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // 1. Convert Edifact message to Xml
            // 2. Validate each transaction
            // 3. Transform each transaction Xml into a custom object using a precompiled Xslt
            // It uses the default locations for the transaction set classes and validation xsd, which are set in the app.config
            const string sampleEdifact =
                "EdiFabric.Sdk.EdiToObject.ConsoleApplication.TestFiles.Edifact_INVOIC_D00A.txt";
            List<CustomInvoic> edifactInvoices =
                Helpers.ConvertEdifactToObjectsWithCompiledXsltMap(
                    Assembly.GetExecutingAssembly().GetManifestResourceStream(sampleEdifact)).ToList();

            // 1. Convert X12 message to Xml
            // 2. Validate each transaction
            // 3. Deserialize the xml into ediFabric .NET object
            // 4. Transform the ediFabric .NET object into a custom object using a code map
            // It uses custom locations for the transaction set classes and validation xsd and passes them in as parameters
            const string sampleX12 = "EdiFabric.Sdk.EdiToObject.ConsoleApplication.TestFiles.X12_810_00204.txt";
            List<Custom810> x12Invoices =
                Helpers.ConvertX12ToObjectsWithCodeMap(
                    Assembly.GetExecutingAssembly().GetManifestResourceStream(sampleX12)).ToList();
        }
    }
}
 