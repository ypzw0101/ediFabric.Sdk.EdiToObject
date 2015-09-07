using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using EdiFabric.Framework;
using EdiFabric.Framework.Messages;
using EdiFabric.Sdk.EdiToObject.CustomClasses.Edifact;
using EdiFabric.Sdk.EdiToObject.CustomClasses.X12;
using EdiFabric.Sdk.EdiToObject.CustomMaps.Helpers;

namespace EdiFabric.Sdk.EdiToObject.ConsoleApplication
{
    internal static class Helpers
    {
        internal static IEnumerable<CustomInvoic> ConvertEdifactToObjectsWithCompiledXsltMap(Stream stream)
        {
            Framework.Envelopes.Edifact.Interchange interchange = null;

            try
            {
                // Parse the EDI
                // This will load the class from the default classes assembly (configured in app.config or EdiFabric.Definitions)
                interchange = Framework.Envelopes.Edifact.Interchange.LoadFrom(stream);
            }
            catch (ParserException ex)
            {
                // Do something if EDI can't be parsed
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.InnerException.Message);
                Debug.WriteLine(ex.ToString());
            }

            // Get all Invoic messages from all groups
            var invoicMessages = interchange.OfTag("INVOIC");

            foreach (var invoicMsg in invoicMessages)
            {
                // Validate each message
                // This will load the xsd from the default xsd assembly (configured in app.config or EdiFabric.Validators)
                var brokenRules = invoicMsg.Validate().ToList();

                if (brokenRules.Any())
                {
                    // Do something if the message is invalid
                    foreach (var br in brokenRules)
                        Debug.WriteLine(br);
                }

                // Convert each Invoic message to our custom entity using compiled Xslt map
                yield return invoicMsg.Item.Map();
            }
        }

        internal static IEnumerable<Custom810> ConvertX12ToObjectsWithCodeMap(Stream stream)
        {
            Framework.Envelopes.X12.Interchange interchange = null;

            try
            {
                // Parse the EDI
                // Pass in the name of the assembly because the class is not in the default assembly (configured in app.config or EdiFabric.Definitions)
                interchange = Framework.Envelopes.X12.Interchange.LoadFrom(stream, "EdiFabric.Sdk.EdiToObject.Classes2");
            }
            catch (ParserException ex)
            {
                // Do something if EDI can't be parsed
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.InnerException.Message);
                Debug.WriteLine(ex.ToString());
            }

            // Get all 810 messages from all groups
            foreach (var invoicMsg in interchange.OfTag("810"))
            {
                // Validate each message
                // Pass in the name of the assembly because the xsd is not in the default assembly (configured in app.config or EdiFabric.Validators)
                var brokenRules = invoicMsg.Validate("EdiFabric.Sdk.EdiToObject.Xsd2").ToList();

                if (brokenRules.Any())
                {
                    // Do something if the message is invalid
                    foreach (var br in brokenRules)
                        Debug.WriteLine(br);
                }

                // Get the 810 object from Xml
                var m810 = invoicMsg.DeserializeItem<Definitions.X12_002040_810.M_810>();

                // Convert each 810 message to our custom entity using code map
                yield return m810.Map();
            }
        }

        private static List<Message> OfTag(this Framework.Envelopes.Edifact.Interchange interchange, string tag)
        {
            return interchange.Groups.SelectMany(m => m.Messages).Where(msg => msg.Context.Tag == tag).ToList();
        }

        private static List<Message> OfTag(this Framework.Envelopes.X12.Interchange interchange, string tag)
        {
            return interchange.Groups.SelectMany(m => m.Messages).Where(msg => msg.Context.Tag == tag).ToList();
        }
    }
}
