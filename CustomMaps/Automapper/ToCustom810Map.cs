using AutoMapper;
using EdiFabric.Definitions.X12_002040_810;
using EdiFabric.Sdk.EdiToObject.CustomClasses.X12;

namespace EdiFabric.Sdk.EdiToObject.CustomMaps.Automapper
{
    internal class ToCustom810Map
    {
        public static void CreateMap()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<M_810, Custom810>();
                cfg.CreateMap<Definitions.X12_002040_810.G_IT1, CustomClasses.X12.G_IT1>();
                cfg.CreateMap<Definitions.X12_002040_810.G_ITA, CustomClasses.X12.G_ITA>();
                cfg.CreateMap<Definitions.X12_002040_810.G_ITA_2, CustomClasses.X12.G_ITA_2>();
                cfg.CreateMap<Definitions.X12_002040_810.G_N1, CustomClasses.X12.G_N1>();
                cfg.CreateMap<Definitions.X12_002040_810.G_N1_2, CustomClasses.X12.G_N1_2>();
                cfg.CreateMap<Definitions.X12_002040_810.G_SLN, CustomClasses.X12.G_SLN>();
                cfg.CreateMap<Definitions.X12_002040_810.S_BIG, CustomClasses.X12.S_BIG>();
                cfg.CreateMap<Definitions.X12_002040_810.S_CAD, CustomClasses.X12.S_CAD>();
                cfg.CreateMap<Definitions.X12_002040_810.S_CAD_2, CustomClasses.X12.S_CAD_2>();
                cfg.CreateMap<Definitions.X12_002040_810.S_CTP, CustomClasses.X12.S_CTP>();
                cfg.CreateMap<Definitions.X12_002040_810.S_CTT, CustomClasses.X12.S_CTT>();
                cfg.CreateMap<Definitions.X12_002040_810.S_CUR, CustomClasses.X12.S_CUR>();
                cfg.CreateMap<Definitions.X12_002040_810.S_CUR_2, CustomClasses.X12.S_CUR_2>();
                cfg.CreateMap<Definitions.X12_002040_810.S_DTM, CustomClasses.X12.S_DTM>();
                cfg.CreateMap<Definitions.X12_002040_810.S_DTM_2, CustomClasses.X12.S_DTM_2>();
                cfg.CreateMap<Definitions.X12_002040_810.S_FOB, CustomClasses.X12.S_FOB>();
                cfg.CreateMap<Definitions.X12_002040_810.S_ISS, CustomClasses.X12.S_ISS>();
                cfg.CreateMap<Definitions.X12_002040_810.S_IT1, CustomClasses.X12.S_IT1>();
                cfg.CreateMap<Definitions.X12_002040_810.S_IT3, CustomClasses.X12.S_IT3>();
                cfg.CreateMap<Definitions.X12_002040_810.S_ITA, CustomClasses.X12.S_ITA>();
                cfg.CreateMap<Definitions.X12_002040_810.S_ITA_2, CustomClasses.X12.S_ITA_2>();
                cfg.CreateMap<Definitions.X12_002040_810.S_ITA_3, CustomClasses.X12.S_ITA_3>();
                cfg.CreateMap<Definitions.X12_002040_810.S_ITD, CustomClasses.X12.S_ITD>();
                cfg.CreateMap<Definitions.X12_002040_810.S_ITD_2, CustomClasses.X12.S_ITD_2>();
                cfg.CreateMap<Definitions.X12_002040_810.S_L7, CustomClasses.X12.S_L7>();
                cfg.CreateMap<Definitions.X12_002040_810.S_L7_2, CustomClasses.X12.S_L7_2>();
                cfg.CreateMap<Definitions.X12_002040_810.S_MEA, CustomClasses.X12.S_MEA>();
                cfg.CreateMap<Definitions.X12_002040_810.S_MEA_2, CustomClasses.X12.S_MEA_2>();
                cfg.CreateMap<Definitions.X12_002040_810.S_N1, CustomClasses.X12.S_N1>();
                cfg.CreateMap<Definitions.X12_002040_810.S_N1_2, CustomClasses.X12.S_N1_2>();
                cfg.CreateMap<Definitions.X12_002040_810.S_N2, CustomClasses.X12.S_N2>();
                cfg.CreateMap<Definitions.X12_002040_810.S_N2_2, CustomClasses.X12.S_N2_2>();
                cfg.CreateMap<Definitions.X12_002040_810.S_N3, CustomClasses.X12.S_N3>();
                cfg.CreateMap<Definitions.X12_002040_810.S_N3_2, CustomClasses.X12.S_N3_2>();
                cfg.CreateMap<Definitions.X12_002040_810.S_N4, CustomClasses.X12.S_N4>();
                cfg.CreateMap<Definitions.X12_002040_810.S_N4_2, CustomClasses.X12.S_N4_2>();
                cfg.CreateMap<Definitions.X12_002040_810.S_NTE, CustomClasses.X12.S_NTE>();
                cfg.CreateMap<Definitions.X12_002040_810.S_PER, CustomClasses.X12.S_PER>();
                cfg.CreateMap<Definitions.X12_002040_810.S_PER_2, CustomClasses.X12.S_PER_2>();
                cfg.CreateMap<Definitions.X12_002040_810.S_PER_3, CustomClasses.X12.S_PER_3>();
                cfg.CreateMap<Definitions.X12_002040_810.S_PER_4, CustomClasses.X12.S_PER_4>();
                cfg.CreateMap<Definitions.X12_002040_810.S_PID, CustomClasses.X12.S_PID>();
                cfg.CreateMap<Definitions.X12_002040_810.S_PID_2, CustomClasses.X12.S_PID_2>();
                cfg.CreateMap<Definitions.X12_002040_810.S_PID_3, CustomClasses.X12.S_PID_3>();
                cfg.CreateMap<Definitions.X12_002040_810.S_PKG, CustomClasses.X12.S_PKG>();
                cfg.CreateMap<Definitions.X12_002040_810.S_PKG_2, CustomClasses.X12.S_PKG_2>();
                cfg.CreateMap<Definitions.X12_002040_810.S_PO4, CustomClasses.X12.S_PO4>();
                cfg.CreateMap<Definitions.X12_002040_810.S_PWK, CustomClasses.X12.S_PWK>();
                cfg.CreateMap<Definitions.X12_002040_810.S_PWK_2, CustomClasses.X12.S_PWK_2>();
                cfg.CreateMap<Definitions.X12_002040_810.S_REF, CustomClasses.X12.S_REF>();
                cfg.CreateMap<Definitions.X12_002040_810.S_REF_2, CustomClasses.X12.S_REF_2>();
                cfg.CreateMap<Definitions.X12_002040_810.S_REF_3, CustomClasses.X12.S_REF_3>();
                cfg.CreateMap<Definitions.X12_002040_810.S_REF_4, CustomClasses.X12.S_REF_4>();
                cfg.CreateMap<Definitions.X12_002040_810.S_REF_5, CustomClasses.X12.S_REF_5>();
                cfg.CreateMap<Definitions.X12_002040_810.S_SDQ, CustomClasses.X12.S_SDQ>();
                cfg.CreateMap<Definitions.X12_002040_810.S_SE, CustomClasses.X12.S_SE>();
                cfg.CreateMap<Definitions.X12_002040_810.S_SLN, CustomClasses.X12.S_SLN>();
                cfg.CreateMap<Definitions.X12_002040_810.S_ST, CustomClasses.X12.S_ST>();
                cfg.CreateMap<Definitions.X12_002040_810.S_TDS, CustomClasses.X12.S_TDS>();
                cfg.CreateMap<Definitions.X12_002040_810.S_TXI, CustomClasses.X12.S_TXI>();
                cfg.CreateMap<Definitions.X12_002040_810.S_TXI_2, CustomClasses.X12.S_TXI_2>();
                cfg.CreateMap<Definitions.X12_002040_810.S_TXI_3, CustomClasses.X12.S_TXI_3>();
                cfg.CreateMap<Definitions.X12_002040_810.S_TXI_4, CustomClasses.X12.S_TXI_4>();                
            });
        }
    }
}
