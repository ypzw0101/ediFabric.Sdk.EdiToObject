using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EdiFabric.Sdk.EdiToObject.CustomClasses.Edifact;
using EdiFabric.Sdk.EdiToObject.CustomClasses.X12;
using EdiFabric.Sdk.EdiToObject.CustomMaps.Helpers;

namespace EdiFabric.Sdk.EdiToObject.ConsoleApplication
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // This sample will parse an EDI message to a custom entity. The steps are:
            // 1. Converts an EDI message into XML. 
            // 2. Validates the Message object to ensure it adheres to the EDI rules for this transaction and version
            // 3. Transform each XML into a custom object
            // For simplicity the custom object bears the same structure as the ediFabric object. The only difference being the root element and the namespace
            // The default locations for the transaction set classes and validation XSD are set in the app.config

            // This sample is for Edifact and uses a compiled XSLT map to convert to custom object from ediFabric object
            const string sampleEdifact =
                "EdiFabric.Sdk.EdiToObject.ConsoleApplication.TestFiles.Edifact_INVOIC_D00A.txt";
            List<CustomInvoic> edifactInvoices =
                Helpers.ConvertEdifactToObjectsWithCompiledXsltMap(
                    Assembly.GetExecutingAssembly().GetManifestResourceStream(sampleEdifact)).ToList();

            var b = XslHelper.Serialize(edifactInvoices[0], "customedifact");

            // This sample is for X12 and uses a code map (I used Automapper, but could be any custom code\mapper) to convert to custom object from ediFabric object
            const string sampleX12 = "EdiFabric.Sdk.EdiToObject.ConsoleApplication.TestFiles.X12_810_00204.txt";
            List<Custom810> x12Invoices =
                Helpers.ConvertX12ToObjectsWithCodeMap(
                    Assembly.GetExecutingAssembly().GetManifestResourceStream(sampleX12)).ToList();
        }
    }
}
 