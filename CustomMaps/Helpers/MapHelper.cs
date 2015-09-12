using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Xml.Serialization;
using AutoMapper;
using EdiFabric.Sdk.EdiToObject.CustomMaps.Automapper;

namespace EdiFabric.Sdk.EdiToObject.CustomMaps.Helpers
{
    public static class MapHelper
    {
        public static CustomClasses.X12.Custom810 Map(this Definitions.X12_002040_810.M_810 ediFabric810)
        {
            Debug.Assert(ediFabric810 != null);

            ToCustom810Map.CreateMap();

            return Mapper.Map<Definitions.X12_002040_810.M_810, CustomClasses.X12.Custom810>(ediFabric810);
        }

        /// <summary>
        /// To recompile it use:
        /// Open cmd console
        /// Go to \EdiFabric.Sdk.EdiToObject\CustomMaps\Xslt
        /// Run xsltc /out:ToCustomInvoic.dll /settings:script+ EdiFabricInvoic_To_CustomInvoic.xslt
        /// Replace the reference to ToCustomInvoic.dll and rebuild
        /// </summary>    
        public static CustomClasses.Edifact.CustomInvoic Map(this XElement ediFabricInvoic)
        {
            Debug.Assert(ediFabricInvoic != null);

            var from = XslHelper.ToByte(ediFabricInvoic);

            if (from == null)
                throw new InvalidOperationException(
                    "Expected valid input stream before transform in pre-compiled map ToCustomInvoic");

            var to = XslHelper.ExecuteCompiledXslMap(typeof(EdiFabricInvoic_To_CustomInvoic), from);

            if (to == null || to.Length == 0)
                throw new InvalidOperationException("Expected valid output stream after transform for map ToCustomInvoic precompiled map");

            var mapped = XElement.Load(new MemoryStream(to));

            var result = XslHelper.Deserialize<CustomClasses.Edifact.CustomInvoic>(mapped, "customedifact");

            return result;
        }

        public static string GetXmlEnumAttributeValueFromEnum<TEnum>(this TEnum value) where TEnum : struct, IConvertible
        {
            var enumType = typeof(TEnum);
            if (!enumType.IsEnum) return null;//or string.Empty, or throw exception

            var member = enumType.GetMember(value.ToString(CultureInfo.InvariantCulture)).FirstOrDefault();
            if (member == null) return null;//or string.Empty, or throw exception

            var attribute = member.GetCustomAttributes(false).OfType<XmlEnumAttribute>().FirstOrDefault();
            if (attribute == null) return null;//or string.Empty, or throw exception
            return attribute.Name;
        }
    }
}
