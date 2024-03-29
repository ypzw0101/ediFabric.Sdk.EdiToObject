namespace EdiFabric.Sdk.EdiToObject.CustomClasses.X12
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.Collections.Generic;


    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public partial class Custom810
    {

        private S_ST s_STField;

        private S_BIG s_BIGField;

        private List<S_NTE> s_NTEField;

        private S_CUR s_CURField;

        private List<S_REF> s_REFField;

        private List<S_PER> s_PERField;

        private List<G_N1> g_N1Field;

        private List<S_ITD> s_ITDField;

        private List<S_DTM> s_DTMField;

        private S_FOB s_FOBField;

        private List<S_PID> s_PIDField;

        private List<S_MEA> s_MEAField;

        private List<S_PWK> s_PWKField;

        private List<S_PKG> s_PKGField;

        private S_L7 s_L7Field;

        private List<G_IT1> g_IT1Field;

        private S_TDS s_TDSField;

        private List<S_TXI_3> s_TXI_3Field;

        private S_CAD_2 s_CAD_2Field;

        private List<G_ITA_2> g_ITA_2Field;

        private List<S_ISS> s_ISSField;

        private S_CTT s_CTTField;

        private S_SE s_SEField;

        public Custom810()
        {
            this.s_SEField = new S_SE();
            this.s_CTTField = new S_CTT();
            this.s_ISSField = new List<S_ISS>();
            this.g_ITA_2Field = new List<G_ITA_2>();
            this.s_CAD_2Field = new S_CAD_2();
            this.s_TXI_3Field = new List<S_TXI_3>();
            this.s_TDSField = new S_TDS();
            this.g_IT1Field = new List<G_IT1>();
            this.s_L7Field = new S_L7();
            this.s_PKGField = new List<S_PKG>();
            this.s_PWKField = new List<S_PWK>();
            this.s_MEAField = new List<S_MEA>();
            this.s_PIDField = new List<S_PID>();
            this.s_FOBField = new S_FOB();
            this.s_DTMField = new List<S_DTM>();
            this.s_ITDField = new List<S_ITD>();
            this.g_N1Field = new List<G_N1>();
            this.s_PERField = new List<S_PER>();
            this.s_REFField = new List<S_REF>();
            this.s_CURField = new S_CUR();
            this.s_NTEField = new List<S_NTE>();
            this.s_BIGField = new S_BIG();
            this.s_STField = new S_ST();
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public S_ST S_ST
        {
            get
            {
                return this.s_STField;
            }
            set
            {
                this.s_STField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public S_BIG S_BIG
        {
            get
            {
                return this.s_BIGField;
            }
            set
            {
                this.s_BIGField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("S_NTE", Order = 2)]
        public List<S_NTE> S_NTE
        {
            get
            {
                return this.s_NTEField;
            }
            set
            {
                this.s_NTEField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public S_CUR S_CUR
        {
            get
            {
                return this.s_CURField;
            }
            set
            {
                this.s_CURField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("S_REF", Order = 4)]
        public List<S_REF> S_REF
        {
            get
            {
                return this.s_REFField;
            }
            set
            {
                this.s_REFField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("S_PER", Order = 5)]
        public List<S_PER> S_PER
        {
            get
            {
                return this.s_PERField;
            }
            set
            {
                this.s_PERField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("G_N1", Order = 6)]
        public List<G_N1> G_N1
        {
            get
            {
                return this.g_N1Field;
            }
            set
            {
                this.g_N1Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("S_ITD", Order = 7)]
        public List<S_ITD> S_ITD
        {
            get
            {
                return this.s_ITDField;
            }
            set
            {
                this.s_ITDField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("S_DTM", Order = 8)]
        public List<S_DTM> S_DTM
        {
            get
            {
                return this.s_DTMField;
            }
            set
            {
                this.s_DTMField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public S_FOB S_FOB
        {
            get
            {
                return this.s_FOBField;
            }
            set
            {
                this.s_FOBField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("S_PID", Order = 10)]
        public List<S_PID> S_PID
        {
            get
            {
                return this.s_PIDField;
            }
            set
            {
                this.s_PIDField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("S_MEA", Order = 11)]
        public List<S_MEA> S_MEA
        {
            get
            {
                return this.s_MEAField;
            }
            set
            {
                this.s_MEAField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("S_PWK", Order = 12)]
        public List<S_PWK> S_PWK
        {
            get
            {
                return this.s_PWKField;
            }
            set
            {
                this.s_PWKField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("S_PKG", Order = 13)]
        public List<S_PKG> S_PKG
        {
            get
            {
                return this.s_PKGField;
            }
            set
            {
                this.s_PKGField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
        public S_L7 S_L7
        {
            get
            {
                return this.s_L7Field;
            }
            set
            {
                this.s_L7Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("G_IT1", Order = 15)]
        public List<G_IT1> G_IT1
        {
            get
            {
                return this.g_IT1Field;
            }
            set
            {
                this.g_IT1Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 16)]
        public S_TDS S_TDS
        {
            get
            {
                return this.s_TDSField;
            }
            set
            {
                this.s_TDSField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("S_TXI_3", Order = 17)]
        public List<S_TXI_3> S_TXI_3
        {
            get
            {
                return this.s_TXI_3Field;
            }
            set
            {
                this.s_TXI_3Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 18)]
        public S_CAD_2 S_CAD_2
        {
            get
            {
                return this.s_CAD_2Field;
            }
            set
            {
                this.s_CAD_2Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("G_ITA_2", Order = 19)]
        public List<G_ITA_2> G_ITA_2
        {
            get
            {
                return this.g_ITA_2Field;
            }
            set
            {
                this.g_ITA_2Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("S_ISS", Order = 20)]
        public List<S_ISS> S_ISS
        {
            get
            {
                return this.s_ISSField;
            }
            set
            {
                this.s_ISSField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 21)]
        public S_CTT S_CTT
        {
            get
            {
                return this.s_CTTField;
            }
            set
            {
                this.s_CTTField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 22)]
        public S_SE S_SE
        {
            get
            {
                return this.s_SEField;
            }
            set
            {
                this.s_SEField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public partial class S_ST
    {

        private S_STD_143_1 d_143_1Field;

        private string d_329_2Field;

        private string d_1705_3Field;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public S_STD_143_1 D_143_1
        {
            get
            {
                return this.d_143_1Field;
            }
            set
            {
                this.d_143_1Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string D_329_2
        {
            get
            {
                return this.d_329_2Field;
            }
            set
            {
                this.d_329_2Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string D_1705_3
        {
            get
            {
                return this.d_1705_3Field;
            }
            set
            {
                this.d_1705_3Field = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "customx12")]
    public enum S_STD_143_1
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("810")]
        Item810,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public partial class S_BIG
    {

        private string d_245_1Field;

        private string d_76_2Field;

        private string d_323_3Field;

        private string d_324_4Field;

        private string d_328_5Field;

        private string d_327_6Field;

        private X12_ID_640 d_640_7Field;

        private bool d_640_7FieldSpecified;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string D_245_1
        {
            get
            {
                return this.d_245_1Field;
            }
            set
            {
                this.d_245_1Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string D_76_2
        {
            get
            {
                return this.d_76_2Field;
            }
            set
            {
                this.d_76_2Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string D_323_3
        {
            get
            {
                return this.d_323_3Field;
            }
            set
            {
                this.d_323_3Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string D_324_4
        {
            get
            {
                return this.d_324_4Field;
            }
            set
            {
                this.d_324_4Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string D_328_5
        {
            get
            {
                return this.d_328_5Field;
            }
            set
            {
                this.d_328_5Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string D_327_6
        {
            get
            {
                return this.d_327_6Field;
            }
            set
            {
                this.d_327_6Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public X12_ID_640 D_640_7
        {
            get
            {
                return this.d_640_7Field;
            }
            set
            {
                this.d_640_7Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_640_7Specified
        {
            get
            {
                return this.d_640_7FieldSpecified;
            }
            set
            {
                this.d_640_7FieldSpecified = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public enum X12_ID_640
    {

        /// <remarks/>
        BA,

        /// <remarks/>
        BB,

        /// <remarks/>
        BH,

        /// <remarks/>
        CA,

        /// <remarks/>
        CC,

        /// <remarks/>
        CI,

        /// <remarks/>
        CN,

        /// <remarks/>
        CO,

        /// <remarks/>
        CR,

        /// <remarks/>
        DC,

        /// <remarks/>
        DI,

        /// <remarks/>
        DR,

        /// <remarks/>
        DU,

        /// <remarks/>
        EB,

        /// <remarks/>
        EF,

        /// <remarks/>
        EI,

        /// <remarks/>
        ER,

        /// <remarks/>
        FB,

        /// <remarks/>
        IB,

        /// <remarks/>
        IF,

        /// <remarks/>
        IR,

        /// <remarks/>
        IU,

        /// <remarks/>
        MC,

        /// <remarks/>
        ME,

        /// <remarks/>
        MF,

        /// <remarks/>
        MI,

        /// <remarks/>
        MM,

        /// <remarks/>
        MR,

        /// <remarks/>
        MS,

        /// <remarks/>
        PB,

        /// <remarks/>
        PP,

        /// <remarks/>
        PR,

        /// <remarks/>
        RA,

        /// <remarks/>
        RB,

        /// <remarks/>
        RC,

        /// <remarks/>
        RE,

        /// <remarks/>
        RF,

        /// <remarks/>
        SM,

        /// <remarks/>
        SS,

        /// <remarks/>
        UF,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public partial class S_NTE
    {

        private X12_ID_363 d_363_1Field;

        private bool d_363_1FieldSpecified;

        private string d_3_2Field;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public X12_ID_363 D_363_1
        {
            get
            {
                return this.d_363_1Field;
            }
            set
            {
                this.d_363_1Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_363_1Specified
        {
            get
            {
                return this.d_363_1FieldSpecified;
            }
            set
            {
                this.d_363_1FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string D_3_2
        {
            get
            {
                return this.d_3_2Field;
            }
            set
            {
                this.d_3_2Field = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public enum X12_ID_363
    {

        /// <remarks/>
        ALL,

        /// <remarks/>
        BOL,

        /// <remarks/>
        CHG,

        /// <remarks/>
        CUS,

        /// <remarks/>
        DEL,

        /// <remarks/>
        GEN,

        /// <remarks/>
        INS,

        /// <remarks/>
        INT,

        /// <remarks/>
        INV,

        /// <remarks/>
        LAB,

        /// <remarks/>
        LIN,

        /// <remarks/>
        LOI,

        /// <remarks/>
        MFG,

        /// <remarks/>
        ORI,

        /// <remarks/>
        OTH,

        /// <remarks/>
        PAY,

        /// <remarks/>
        PKG,

        /// <remarks/>
        PMT,

        /// <remarks/>
        PRI,

        /// <remarks/>
        PUR,

        /// <remarks/>
        QUT,

        /// <remarks/>
        REV,

        /// <remarks/>
        SPH,

        /// <remarks/>
        TAF,

        /// <remarks/>
        TCF,

        /// <remarks/>
        TIL,

        /// <remarks/>
        TLF,

        /// <remarks/>
        TRA,

        /// <remarks/>
        TRF,

        /// <remarks/>
        TSF,

        /// <remarks/>
        WHI,

        /// <remarks/>
        WRP,

        /// <remarks/>
        ZZZ,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public partial class S_CUR
    {

        private X12_ID_98 d_98_1Field;

        private string d_100_2Field;

        private string d_280_3Field;

        private X12_ID_98 d_98_4Field;

        private bool d_98_4FieldSpecified;

        private string d_100_5Field;

        private X12_ID_669 d_669_6Field;

        private bool d_669_6FieldSpecified;

        private X12_ID_374 d_374_7Field;

        private bool d_374_7FieldSpecified;

        private string d_373_8Field;

        private string d_337_9Field;

        private X12_ID_374 d_374_10Field;

        private bool d_374_10FieldSpecified;

        private string d_373_11Field;

        private string d_337_12Field;

        private X12_ID_374 d_374_13Field;

        private bool d_374_13FieldSpecified;

        private string d_373_14Field;

        private string d_337_15Field;

        private X12_ID_374 d_374_16Field;

        private bool d_374_16FieldSpecified;

        private string d_373_17Field;

        private string d_337_18Field;

        private X12_ID_374 d_374_19Field;

        private bool d_374_19FieldSpecified;

        private string d_373_20Field;

        private string d_337_21Field;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public X12_ID_98 D_98_1
        {
            get
            {
                return this.d_98_1Field;
            }
            set
            {
                this.d_98_1Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string D_100_2
        {
            get
            {
                return this.d_100_2Field;
            }
            set
            {
                this.d_100_2Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string D_280_3
        {
            get
            {
                return this.d_280_3Field;
            }
            set
            {
                this.d_280_3Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public X12_ID_98 D_98_4
        {
            get
            {
                return this.d_98_4Field;
            }
            set
            {
                this.d_98_4Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_98_4Specified
        {
            get
            {
                return this.d_98_4FieldSpecified;
            }
            set
            {
                this.d_98_4FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string D_100_5
        {
            get
            {
                return this.d_100_5Field;
            }
            set
            {
                this.d_100_5Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public X12_ID_669 D_669_6
        {
            get
            {
                return this.d_669_6Field;
            }
            set
            {
                this.d_669_6Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_669_6Specified
        {
            get
            {
                return this.d_669_6FieldSpecified;
            }
            set
            {
                this.d_669_6FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public X12_ID_374 D_374_7
        {
            get
            {
                return this.d_374_7Field;
            }
            set
            {
                this.d_374_7Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_374_7Specified
        {
            get
            {
                return this.d_374_7FieldSpecified;
            }
            set
            {
                this.d_374_7FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string D_373_8
        {
            get
            {
                return this.d_373_8Field;
            }
            set
            {
                this.d_373_8Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string D_337_9
        {
            get
            {
                return this.d_337_9Field;
            }
            set
            {
                this.d_337_9Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public X12_ID_374 D_374_10
        {
            get
            {
                return this.d_374_10Field;
            }
            set
            {
                this.d_374_10Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_374_10Specified
        {
            get
            {
                return this.d_374_10FieldSpecified;
            }
            set
            {
                this.d_374_10FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public string D_373_11
        {
            get
            {
                return this.d_373_11Field;
            }
            set
            {
                this.d_373_11Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public string D_337_12
        {
            get
            {
                return this.d_337_12Field;
            }
            set
            {
                this.d_337_12Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public X12_ID_374 D_374_13
        {
            get
            {
                return this.d_374_13Field;
            }
            set
            {
                this.d_374_13Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_374_13Specified
        {
            get
            {
                return this.d_374_13FieldSpecified;
            }
            set
            {
                this.d_374_13FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public string D_373_14
        {
            get
            {
                return this.d_373_14Field;
            }
            set
            {
                this.d_373_14Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
        public string D_337_15
        {
            get
            {
                return this.d_337_15Field;
            }
            set
            {
                this.d_337_15Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 15)]
        public X12_ID_374 D_374_16
        {
            get
            {
                return this.d_374_16Field;
            }
            set
            {
                this.d_374_16Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_374_16Specified
        {
            get
            {
                return this.d_374_16FieldSpecified;
            }
            set
            {
                this.d_374_16FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 16)]
        public string D_373_17
        {
            get
            {
                return this.d_373_17Field;
            }
            set
            {
                this.d_373_17Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 17)]
        public string D_337_18
        {
            get
            {
                return this.d_337_18Field;
            }
            set
            {
                this.d_337_18Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 18)]
        public X12_ID_374 D_374_19
        {
            get
            {
                return this.d_374_19Field;
            }
            set
            {
                this.d_374_19Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_374_19Specified
        {
            get
            {
                return this.d_374_19FieldSpecified;
            }
            set
            {
                this.d_374_19FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 19)]
        public string D_373_20
        {
            get
            {
                return this.d_373_20Field;
            }
            set
            {
                this.d_373_20Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 20)]
        public string D_337_21
        {
            get
            {
                return this.d_337_21Field;
            }
            set
            {
                this.d_337_21Field = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public enum X12_ID_98
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("11")]
        Item11,

        /// <remarks/>
        AC,

        /// <remarks/>
        AD,

        /// <remarks/>
        AG,

        /// <remarks/>
        AK,

        /// <remarks/>
        AL,

        /// <remarks/>
        AO,

        /// <remarks/>
        BF,

        /// <remarks/>
        BG,

        /// <remarks/>
        BK,

        /// <remarks/>
        BL,

        /// <remarks/>
        BN,

        /// <remarks/>
        BO,

        /// <remarks/>
        BS,

        /// <remarks/>
        BT,

        /// <remarks/>
        BW,

        /// <remarks/>
        BY,

        /// <remarks/>
        C1,

        /// <remarks/>
        C2,

        /// <remarks/>
        CA,

        /// <remarks/>
        CB,

        /// <remarks/>
        CC,

        /// <remarks/>
        CD,

        /// <remarks/>
        CE,

        /// <remarks/>
        CF,

        /// <remarks/>
        CI,

        /// <remarks/>
        CL,

        /// <remarks/>
        CM,

        /// <remarks/>
        CN,

        /// <remarks/>
        CO,

        /// <remarks/>
        CP,

        /// <remarks/>
        CR,

        /// <remarks/>
        CS,

        /// <remarks/>
        CV,

        /// <remarks/>
        DB,

        /// <remarks/>
        DC,

        /// <remarks/>
        DE,

        /// <remarks/>
        DL,

        /// <remarks/>
        DP,

        /// <remarks/>
        DS,

        /// <remarks/>
        EC,

        /// <remarks/>
        EE,

        /// <remarks/>
        EM,

        /// <remarks/>
        EN,

        /// <remarks/>
        EP,

        /// <remarks/>
        EX,

        /// <remarks/>
        FH,

        /// <remarks/>
        FR,

        /// <remarks/>
        FW,

        /// <remarks/>
        IA,

        /// <remarks/>
        IC,

        /// <remarks/>
        II,

        /// <remarks/>
        IK,

        /// <remarks/>
        IM,

        /// <remarks/>
        IN,

        /// <remarks/>
        IS,

        /// <remarks/>
        IT,

        /// <remarks/>
        LN,

        /// <remarks/>
        LP,

        /// <remarks/>
        MA,

        /// <remarks/>
        MC,

        /// <remarks/>
        MF,

        /// <remarks/>
        MI,

        /// <remarks/>
        MP,

        /// <remarks/>
        MQ,

        /// <remarks/>
        N1,

        /// <remarks/>
        N2,

        /// <remarks/>
        OB,

        /// <remarks/>
        OC,

        /// <remarks/>
        OI,

        /// <remarks/>
        OO,

        /// <remarks/>
        OP,

        /// <remarks/>
        OT,

        /// <remarks/>
        OV,

        /// <remarks/>
        OW,

        /// <remarks/>
        PA,

        /// <remarks/>
        PB,

        /// <remarks/>
        PC,

        /// <remarks/>
        PD,

        /// <remarks/>
        PE,

        /// <remarks/>
        PF,

        /// <remarks/>
        PG,

        /// <remarks/>
        PH,

        /// <remarks/>
        PI,

        /// <remarks/>
        PJ,

        /// <remarks/>
        PK,

        /// <remarks/>
        PM,

        /// <remarks/>
        PN,

        /// <remarks/>
        PP,

        /// <remarks/>
        PR,

        /// <remarks/>
        PT,

        /// <remarks/>
        PU,

        /// <remarks/>
        PV,

        /// <remarks/>
        RB,

        /// <remarks/>
        RC,

        /// <remarks/>
        RE,

        /// <remarks/>
        RF,

        /// <remarks/>
        RL,

        /// <remarks/>
        RM,

        /// <remarks/>
        RP,

        /// <remarks/>
        RQ,

        /// <remarks/>
        RR,

        /// <remarks/>
        RS,

        /// <remarks/>
        SA,

        /// <remarks/>
        SB,

        /// <remarks/>
        SC,

        /// <remarks/>
        SD,

        /// <remarks/>
        SE,

        /// <remarks/>
        SF,

        /// <remarks/>
        SG,

        /// <remarks/>
        SH,

        /// <remarks/>
        SI,

        /// <remarks/>
        SM,

        /// <remarks/>
        SN,

        /// <remarks/>
        SO,

        /// <remarks/>
        SP,

        /// <remarks/>
        SR,

        /// <remarks/>
        SS,

        /// <remarks/>
        ST,

        /// <remarks/>
        SU,

        /// <remarks/>
        SW,

        /// <remarks/>
        TC,

        /// <remarks/>
        TF,

        /// <remarks/>
        TO,

        /// <remarks/>
        TR,

        /// <remarks/>
        TS,

        /// <remarks/>
        TT,

        /// <remarks/>
        UC,

        /// <remarks/>
        UP,

        /// <remarks/>
        VN,

        /// <remarks/>
        WF,

        /// <remarks/>
        WH,

        /// <remarks/>
        ZZ,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public enum X12_ID_669
    {

        /// <remarks/>
        IMF,

        /// <remarks/>
        LNF,

        /// <remarks/>
        LNS,

        /// <remarks/>
        NYC,

        /// <remarks/>
        PHI,

        /// <remarks/>
        ZUR,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public enum X12_ID_374
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("001")]
        Item001,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("002")]
        Item002,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("003")]
        Item003,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("004")]
        Item004,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("005")]
        Item005,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("006")]
        Item006,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("007")]
        Item007,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("008")]
        Item008,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("009")]
        Item009,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("010")]
        Item010,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("011")]
        Item011,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("012")]
        Item012,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("013")]
        Item013,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("014")]
        Item014,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("015")]
        Item015,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("016")]
        Item016,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("017")]
        Item017,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("018")]
        Item018,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("019")]
        Item019,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("020")]
        Item020,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("021")]
        Item021,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("022")]
        Item022,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("023")]
        Item023,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("024")]
        Item024,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("025")]
        Item025,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("026")]
        Item026,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("027")]
        Item027,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("028")]
        Item028,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("029")]
        Item029,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("030")]
        Item030,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("031")]
        Item031,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("032")]
        Item032,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("033")]
        Item033,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("034")]
        Item034,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("035")]
        Item035,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("036")]
        Item036,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("037")]
        Item037,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("038")]
        Item038,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("039")]
        Item039,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("040")]
        Item040,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("041")]
        Item041,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("042")]
        Item042,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("043")]
        Item043,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("050")]
        Item050,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("051")]
        Item051,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("052")]
        Item052,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("053")]
        Item053,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("054")]
        Item054,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("055")]
        Item055,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("056")]
        Item056,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("057")]
        Item057,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("058")]
        Item058,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("059")]
        Item059,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("060")]
        Item060,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("061")]
        Item061,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("062")]
        Item062,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("063")]
        Item063,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("064")]
        Item064,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("065")]
        Item065,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("066")]
        Item066,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("067")]
        Item067,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("068")]
        Item068,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("069")]
        Item069,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("070")]
        Item070,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("071")]
        Item071,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("072")]
        Item072,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("073")]
        Item073,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("074")]
        Item074,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("075")]
        Item075,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("076")]
        Item076,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("077")]
        Item077,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("078")]
        Item078,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("079")]
        Item079,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("080")]
        Item080,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("081")]
        Item081,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("082")]
        Item082,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("083")]
        Item083,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("084")]
        Item084,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("085")]
        Item085,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("086")]
        Item086,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("087")]
        Item087,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("088")]
        Item088,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("089")]
        Item089,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("090")]
        Item090,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("091")]
        Item091,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("092")]
        Item092,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("093")]
        Item093,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("094")]
        Item094,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("095")]
        Item095,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("096")]
        Item096,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("097")]
        Item097,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("098")]
        Item098,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("099")]
        Item099,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("100")]
        Item100,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("101")]
        Item101,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("102")]
        Item102,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("103")]
        Item103,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("104")]
        Item104,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("105")]
        Item105,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("106")]
        Item106,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("107")]
        Item107,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("108")]
        Item108,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("109")]
        Item109,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("110")]
        Item110,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("111")]
        Item111,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("112")]
        Item112,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("113")]
        Item113,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("114")]
        Item114,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("115")]
        Item115,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("116")]
        Item116,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("119")]
        Item119,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("120")]
        Item120,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("121")]
        Item121,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("122")]
        Item122,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("124")]
        Item124,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("125")]
        Item125,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("126")]
        Item126,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("127")]
        Item127,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("128")]
        Item128,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("129")]
        Item129,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("130")]
        Item130,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("131")]
        Item131,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("132")]
        Item132,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("133")]
        Item133,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("134")]
        Item134,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("135")]
        Item135,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("136")]
        Item136,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("137")]
        Item137,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("138")]
        Item138,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("150")]
        Item150,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("151")]
        Item151,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("152")]
        Item152,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("153")]
        Item153,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("154")]
        Item154,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("155")]
        Item155,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("156")]
        Item156,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("157")]
        Item157,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("158")]
        Item158,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("159")]
        Item159,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("160")]
        Item160,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public partial class S_REF
    {

        private X12_ID_128 d_128_1Field;

        private string d_127_2Field;

        private string d_352_3Field;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public X12_ID_128 D_128_1
        {
            get
            {
                return this.d_128_1Field;
            }
            set
            {
                this.d_128_1Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string D_127_2
        {
            get
            {
                return this.d_127_2Field;
            }
            set
            {
                this.d_127_2Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string D_352_3
        {
            get
            {
                return this.d_352_3Field;
            }
            set
            {
                this.d_352_3Field = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public enum X12_ID_128
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("52")]
        Item52,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("53")]
        Item53,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("54")]
        Item54,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("61")]
        Item61,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("62")]
        Item62,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("63")]
        Item63,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("64")]
        Item64,

        /// <remarks/>
        A1,

        /// <remarks/>
        AA,

        /// <remarks/>
        AB,

        /// <remarks/>
        AC,

        /// <remarks/>
        AD,

        /// <remarks/>
        AE,

        /// <remarks/>
        AF,

        /// <remarks/>
        AG,

        /// <remarks/>
        AI,

        /// <remarks/>
        AL,

        /// <remarks/>
        AM,

        /// <remarks/>
        AN,

        /// <remarks/>
        AO,

        /// <remarks/>
        AP,

        /// <remarks/>
        AR,

        /// <remarks/>
        AS,

        /// <remarks/>
        AT,

        /// <remarks/>
        AU,

        /// <remarks/>
        AW,

        /// <remarks/>
        BC,

        /// <remarks/>
        BD,

        /// <remarks/>
        BI,

        /// <remarks/>
        BJ,

        /// <remarks/>
        BK,

        /// <remarks/>
        BL,

        /// <remarks/>
        BM,

        /// <remarks/>
        BN,

        /// <remarks/>
        BO,

        /// <remarks/>
        BR,

        /// <remarks/>
        BT,

        /// <remarks/>
        BU,

        /// <remarks/>
        C1,

        /// <remarks/>
        C2,

        /// <remarks/>
        C3,

        /// <remarks/>
        CA,

        /// <remarks/>
        CB,

        /// <remarks/>
        CC,

        /// <remarks/>
        CD,

        /// <remarks/>
        CE,

        /// <remarks/>
        CF,

        /// <remarks/>
        CG,

        /// <remarks/>
        CH,

        /// <remarks/>
        CI,

        /// <remarks/>
        CJ,

        /// <remarks/>
        CK,

        /// <remarks/>
        CL,

        /// <remarks/>
        CM,

        /// <remarks/>
        CN,

        /// <remarks/>
        CO,

        /// <remarks/>
        CP,

        /// <remarks/>
        CQ,

        /// <remarks/>
        CR,

        /// <remarks/>
        CS,

        /// <remarks/>
        CT,

        /// <remarks/>
        CU,

        /// <remarks/>
        CX,

        /// <remarks/>
        CY,

        /// <remarks/>
        DB,

        /// <remarks/>
        DC,

        /// <remarks/>
        DD,

        /// <remarks/>
        DE,

        /// <remarks/>
        DF,

        /// <remarks/>
        DI,

        /// <remarks/>
        DK,

        /// <remarks/>
        DL,

        /// <remarks/>
        DN,

        /// <remarks/>
        DO,

        /// <remarks/>
        DP,

        /// <remarks/>
        DQ,

        /// <remarks/>
        DR,

        /// <remarks/>
        DS,

        /// <remarks/>
        DV,

        /// <remarks/>
        DW,

        /// <remarks/>
        EB,

        /// <remarks/>
        ED,

        /// <remarks/>
        EI,

        /// <remarks/>
        EL,

        /// <remarks/>
        EN,

        /// <remarks/>
        EP,

        /// <remarks/>
        EQ,

        /// <remarks/>
        ER,

        /// <remarks/>
        ES,

        /// <remarks/>
        ET,

        /// <remarks/>
        EU,

        /// <remarks/>
        EZ,

        /// <remarks/>
        FA,

        /// <remarks/>
        FC,

        /// <remarks/>
        FE,

        /// <remarks/>
        FI,

        /// <remarks/>
        FN,

        /// <remarks/>
        FP,

        /// <remarks/>
        FR,

        /// <remarks/>
        FS,

        /// <remarks/>
        FT,

        /// <remarks/>
        GB,

        /// <remarks/>
        GC,

        /// <remarks/>
        GE,

        /// <remarks/>
        GG,

        /// <remarks/>
        GP,

        /// <remarks/>
        GR,

        /// <remarks/>
        GS,

        /// <remarks/>
        HB,

        /// <remarks/>
        HC,

        /// <remarks/>
        HD,

        /// <remarks/>
        HE,

        /// <remarks/>
        HN,

        /// <remarks/>
        HO,

        /// <remarks/>
        HP,

        /// <remarks/>
        HS,

        /// <remarks/>
        HW,

        /// <remarks/>
        IA,

        /// <remarks/>
        IB,

        /// <remarks/>
        IC,

        /// <remarks/>
        ID,

        /// <remarks/>
        IE,

        /// <remarks/>
        II,

        /// <remarks/>
        IL,

        /// <remarks/>
        IN,

        /// <remarks/>
        IO,

        /// <remarks/>
        IR,

        /// <remarks/>
        IS,

        /// <remarks/>
        IT,

        /// <remarks/>
        IV,

        /// <remarks/>
        JA,

        /// <remarks/>
        JB,

        /// <remarks/>
        JE,

        /// <remarks/>
        JS,

        /// <remarks/>
        KB,

        /// <remarks/>
        KE,

        /// <remarks/>
        LA,

        /// <remarks/>
        LB,

        /// <remarks/>
        LC,

        /// <remarks/>
        LF,

        /// <remarks/>
        LI,

        /// <remarks/>
        LM,

        /// <remarks/>
        LN,

        /// <remarks/>
        LO,

        /// <remarks/>
        LP,

        /// <remarks/>
        LS,

        /// <remarks/>
        LT,

        /// <remarks/>
        LW,

        /// <remarks/>
        MA,

        /// <remarks/>
        MB,

        /// <remarks/>
        MC,

        /// <remarks/>
        ME,

        /// <remarks/>
        MF,

        /// <remarks/>
        MG,

        /// <remarks/>
        MH,

        /// <remarks/>
        MI,

        /// <remarks/>
        MK,

        /// <remarks/>
        MN,

        /// <remarks/>
        MP,

        /// <remarks/>
        MR,

        /// <remarks/>
        MS,

        /// <remarks/>
        MT,

        /// <remarks/>
        MY,

        /// <remarks/>
        NA,

        /// <remarks/>
        NB,

        /// <remarks/>
        ND,

        /// <remarks/>
        NN,

        /// <remarks/>
        NP,

        /// <remarks/>
        NR,

        /// <remarks/>
        NS,

        /// <remarks/>
        OB,

        /// <remarks/>
        OC,

        /// <remarks/>
        OI,

        /// <remarks/>
        OM,

        /// <remarks/>
        OP,

        /// <remarks/>
        OS,

        /// <remarks/>
        P1,

        /// <remarks/>
        P2,

        /// <remarks/>
        P3,

        /// <remarks/>
        P4,

        /// <remarks/>
        P5,

        /// <remarks/>
        P6,

        /// <remarks/>
        P7,

        /// <remarks/>
        PA,

        /// <remarks/>
        PB,

        /// <remarks/>
        PC,

        /// <remarks/>
        PD,

        /// <remarks/>
        PE,

        /// <remarks/>
        PF,

        /// <remarks/>
        PG,

        /// <remarks/>
        PH,

        /// <remarks/>
        PI,

        /// <remarks/>
        PJ,

        /// <remarks/>
        PK,

        /// <remarks/>
        PL,

        /// <remarks/>
        PM,

        /// <remarks/>
        PN,

        /// <remarks/>
        PO,

        /// <remarks/>
        PP,

        /// <remarks/>
        PQ,

        /// <remarks/>
        PR,

        /// <remarks/>
        PS,

        /// <remarks/>
        PT,

        /// <remarks/>
        PV,

        /// <remarks/>
        PW,

        /// <remarks/>
        PX,

        /// <remarks/>
        PY,

        /// <remarks/>
        PZ,

        /// <remarks/>
        QR,

        /// <remarks/>
        RB,

        /// <remarks/>
        RC,

        /// <remarks/>
        RD,

        /// <remarks/>
        RE,

        /// <remarks/>
        RF,

        /// <remarks/>
        RG,

        /// <remarks/>
        RH,

        /// <remarks/>
        RI,

        /// <remarks/>
        RJ,

        /// <remarks/>
        RK,

        /// <remarks/>
        RL,

        /// <remarks/>
        RM,

        /// <remarks/>
        RN,

        /// <remarks/>
        RP,

        /// <remarks/>
        RQ,

        /// <remarks/>
        RR,

        /// <remarks/>
        RS,

        /// <remarks/>
        RT,

        /// <remarks/>
        RU,

        /// <remarks/>
        RV,

        /// <remarks/>
        RW,

        /// <remarks/>
        RX,

        /// <remarks/>
        RY,

        /// <remarks/>
        SA,

        /// <remarks/>
        SB,

        /// <remarks/>
        SC,

        /// <remarks/>
        SD,

        /// <remarks/>
        SE,

        /// <remarks/>
        SF,

        /// <remarks/>
        SH,

        /// <remarks/>
        SI,

        /// <remarks/>
        SJ,

        /// <remarks/>
        SK,

        /// <remarks/>
        SL,

        /// <remarks/>
        SM,

        /// <remarks/>
        SN,

        /// <remarks/>
        SO,

        /// <remarks/>
        SP,

        /// <remarks/>
        SQ,

        /// <remarks/>
        SR,

        /// <remarks/>
        SS,

        /// <remarks/>
        ST,

        /// <remarks/>
        SU,

        /// <remarks/>
        SV,

        /// <remarks/>
        SW,

        /// <remarks/>
        SX,

        /// <remarks/>
        SY,

        /// <remarks/>
        TA,

        /// <remarks/>
        TB,

        /// <remarks/>
        TC,

        /// <remarks/>
        TF,

        /// <remarks/>
        TG,

        /// <remarks/>
        TH,

        /// <remarks/>
        TI,

        /// <remarks/>
        TK,

        /// <remarks/>
        TL,

        /// <remarks/>
        TM,

        /// <remarks/>
        TN,

        /// <remarks/>
        TO,

        /// <remarks/>
        TR,

        /// <remarks/>
        TS,

        /// <remarks/>
        TX,

        /// <remarks/>
        UB,

        /// <remarks/>
        UD,

        /// <remarks/>
        UG,

        /// <remarks/>
        UN,

        /// <remarks/>
        US,

        /// <remarks/>
        UT,

        /// <remarks/>
        VA,

        /// <remarks/>
        VB,

        /// <remarks/>
        VC,

        /// <remarks/>
        VM,

        /// <remarks/>
        VN,

        /// <remarks/>
        VP,

        /// <remarks/>
        VR,

        /// <remarks/>
        VS,

        /// <remarks/>
        VT,

        /// <remarks/>
        VV,

        /// <remarks/>
        VX,

        /// <remarks/>
        WM,

        /// <remarks/>
        WN,

        /// <remarks/>
        WR,

        /// <remarks/>
        WS,

        /// <remarks/>
        WY,

        /// <remarks/>
        XC,

        /// <remarks/>
        XP,

        /// <remarks/>
        ZA,

        /// <remarks/>
        ZB,

        /// <remarks/>
        ZC,

        /// <remarks/>
        ZZ,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public partial class S_PER
    {

        private X12_ID_366 d_366_1Field;

        private string d_93_2Field;

        private X12_ID_365 d_365_3Field;

        private bool d_365_3FieldSpecified;

        private string d_364_4Field;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public X12_ID_366 D_366_1
        {
            get
            {
                return this.d_366_1Field;
            }
            set
            {
                this.d_366_1Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string D_93_2
        {
            get
            {
                return this.d_93_2Field;
            }
            set
            {
                this.d_93_2Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public X12_ID_365 D_365_3
        {
            get
            {
                return this.d_365_3Field;
            }
            set
            {
                this.d_365_3Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_365_3Specified
        {
            get
            {
                return this.d_365_3FieldSpecified;
            }
            set
            {
                this.d_365_3FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string D_364_4
        {
            get
            {
                return this.d_364_4Field;
            }
            set
            {
                this.d_364_4Field = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public enum X12_ID_366
    {

        /// <remarks/>
        AC,

        /// <remarks/>
        AD,

        /// <remarks/>
        AP,

        /// <remarks/>
        AR,

        /// <remarks/>
        BD,

        /// <remarks/>
        CA,

        /// <remarks/>
        CB,

        /// <remarks/>
        CC,

        /// <remarks/>
        CD,

        /// <remarks/>
        CE,

        /// <remarks/>
        CR,

        /// <remarks/>
        CW,

        /// <remarks/>
        DC,

        /// <remarks/>
        DE,

        /// <remarks/>
        DI,

        /// <remarks/>
        EB,

        /// <remarks/>
        EC,

        /// <remarks/>
        ED,

        /// <remarks/>
        EF,

        /// <remarks/>
        EN,

        /// <remarks/>
        EX,

        /// <remarks/>
        HM,

        /// <remarks/>
        IC,

        /// <remarks/>
        IO,

        /// <remarks/>
        NP,

        /// <remarks/>
        NT,

        /// <remarks/>
        OC,

        /// <remarks/>
        OD,

        /// <remarks/>
        PE,

        /// <remarks/>
        PM,

        /// <remarks/>
        PR,

        /// <remarks/>
        QA,

        /// <remarks/>
        QC,

        /// <remarks/>
        QI,

        /// <remarks/>
        RC,

        /// <remarks/>
        RD,

        /// <remarks/>
        SA,

        /// <remarks/>
        SC,

        /// <remarks/>
        SD,

        /// <remarks/>
        SR,

        /// <remarks/>
        SU,

        /// <remarks/>
        TA,

        /// <remarks/>
        TR,

        /// <remarks/>
        WH,

        /// <remarks/>
        ZZ,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public enum X12_ID_365
    {

        /// <remarks/>
        AU,

        /// <remarks/>
        EM,

        /// <remarks/>
        FT,

        /// <remarks/>
        FX,

        /// <remarks/>
        IT,

        /// <remarks/>
        PS,

        /// <remarks/>
        TE,

        /// <remarks/>
        TL,

        /// <remarks/>
        TM,

        /// <remarks/>
        TX,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public partial class G_N1
    {

        private S_N1 s_N1Field;

        private List<S_N2> s_N2Field;

        private List<S_N3> s_N3Field;

        private S_N4 s_N4Field;

        private List<S_REF_2> s_REF_2Field;

        private List<S_PER_2> s_PER_2Field;

        public G_N1()
        {
            this.s_PER_2Field = new List<S_PER_2>();
            this.s_REF_2Field = new List<S_REF_2>();
            this.s_N4Field = new S_N4();
            this.s_N3Field = new List<S_N3>();
            this.s_N2Field = new List<S_N2>();
            this.s_N1Field = new S_N1();
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public S_N1 S_N1
        {
            get
            {
                return this.s_N1Field;
            }
            set
            {
                this.s_N1Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("S_N2", Order = 1)]
        public List<S_N2> S_N2
        {
            get
            {
                return this.s_N2Field;
            }
            set
            {
                this.s_N2Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("S_N3", Order = 2)]
        public List<S_N3> S_N3
        {
            get
            {
                return this.s_N3Field;
            }
            set
            {
                this.s_N3Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public S_N4 S_N4
        {
            get
            {
                return this.s_N4Field;
            }
            set
            {
                this.s_N4Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("S_REF_2", Order = 4)]
        public List<S_REF_2> S_REF_2
        {
            get
            {
                return this.s_REF_2Field;
            }
            set
            {
                this.s_REF_2Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("S_PER_2", Order = 5)]
        public List<S_PER_2> S_PER_2
        {
            get
            {
                return this.s_PER_2Field;
            }
            set
            {
                this.s_PER_2Field = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public partial class S_N1
    {

        private X12_ID_98 d_98_1Field;

        private string d_93_2Field;

        private X12_ID_66 d_66_3Field;

        private bool d_66_3FieldSpecified;

        private string d_67_4Field;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public X12_ID_98 D_98_1
        {
            get
            {
                return this.d_98_1Field;
            }
            set
            {
                this.d_98_1Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string D_93_2
        {
            get
            {
                return this.d_93_2Field;
            }
            set
            {
                this.d_93_2Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public X12_ID_66 D_66_3
        {
            get
            {
                return this.d_66_3Field;
            }
            set
            {
                this.d_66_3Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_66_3Specified
        {
            get
            {
                return this.d_66_3FieldSpecified;
            }
            set
            {
                this.d_66_3FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string D_67_4
        {
            get
            {
                return this.d_67_4Field;
            }
            set
            {
                this.d_67_4Field = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public enum X12_ID_66
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("10")]
        Item10,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("11")]
        Item11,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12")]
        Item12,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("13")]
        Item13,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("14")]
        Item14,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("15")]
        Item15,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("16")]
        Item16,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("18")]
        Item18,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("19")]
        Item19,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("20")]
        Item20,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("21")]
        Item21,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("22")]
        Item22,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("23")]
        Item23,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("24")]
        Item24,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("25")]
        Item25,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("26")]
        Item26,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("27")]
        Item27,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("28")]
        Item28,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("30")]
        Item30,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("31")]
        Item31,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("32")]
        Item32,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("34")]
        Item34,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6")]
        Item6,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7")]
        Item7,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("8")]
        Item8,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9")]
        Item9,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("91")]
        Item91,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("92")]
        Item92,

        /// <remarks/>
        ZZ,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public partial class S_N2
    {

        private string d_93_1Field;

        private string d_93_2Field;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string D_93_1
        {
            get
            {
                return this.d_93_1Field;
            }
            set
            {
                this.d_93_1Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string D_93_2
        {
            get
            {
                return this.d_93_2Field;
            }
            set
            {
                this.d_93_2Field = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public partial class S_N3
    {

        private string d_166_1Field;

        private string d_166_2Field;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string D_166_1
        {
            get
            {
                return this.d_166_1Field;
            }
            set
            {
                this.d_166_1Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string D_166_2
        {
            get
            {
                return this.d_166_2Field;
            }
            set
            {
                this.d_166_2Field = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public partial class S_N4
    {

        private string d_19_1Field;

        private string d_156_2Field;

        private string d_116_3Field;

        private string d_26_4Field;

        private X12_ID_309 d_309_5Field;

        private bool d_309_5FieldSpecified;

        private string d_310_6Field;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string D_19_1
        {
            get
            {
                return this.d_19_1Field;
            }
            set
            {
                this.d_19_1Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string D_156_2
        {
            get
            {
                return this.d_156_2Field;
            }
            set
            {
                this.d_156_2Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string D_116_3
        {
            get
            {
                return this.d_116_3Field;
            }
            set
            {
                this.d_116_3Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string D_26_4
        {
            get
            {
                return this.d_26_4Field;
            }
            set
            {
                this.d_26_4Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public X12_ID_309 D_309_5
        {
            get
            {
                return this.d_309_5Field;
            }
            set
            {
                this.d_309_5Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_309_5Specified
        {
            get
            {
                return this.d_309_5FieldSpecified;
            }
            set
            {
                this.d_309_5FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string D_310_6
        {
            get
            {
                return this.d_310_6Field;
            }
            set
            {
                this.d_310_6Field = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public enum X12_ID_309
    {

        /// <remarks/>
        AC,

        /// <remarks/>
        CC,

        /// <remarks/>
        CI,

        /// <remarks/>
        CL,

        /// <remarks/>
        CO,

        /// <remarks/>
        CS,

        /// <remarks/>
        CY,

        /// <remarks/>
        D,

        /// <remarks/>
        DC,

        /// <remarks/>
        DE,

        /// <remarks/>
        FA,

        /// <remarks/>
        FE,

        /// <remarks/>
        FI,

        /// <remarks/>
        FV,

        /// <remarks/>
        IM,

        /// <remarks/>
        IP,

        /// <remarks/>
        MI,

        /// <remarks/>
        NS,

        /// <remarks/>
        OA,

        /// <remarks/>
        OL,

        /// <remarks/>
        OP,

        /// <remarks/>
        OR,

        /// <remarks/>
        PL,

        /// <remarks/>
        PP,

        /// <remarks/>
        RS,

        /// <remarks/>
        RT,

        /// <remarks/>
        SC,

        /// <remarks/>
        SL,

        /// <remarks/>
        SN,

        /// <remarks/>
        SP,

        /// <remarks/>
        TC,

        /// <remarks/>
        TL,

        /// <remarks/>
        TN,

        /// <remarks/>
        TX,

        /// <remarks/>
        W,

        /// <remarks/>
        WH,

        /// <remarks/>
        ZZ,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public partial class S_REF_2
    {

        private X12_ID_128 d_128_1Field;

        private string d_127_2Field;

        private string d_352_3Field;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public X12_ID_128 D_128_1
        {
            get
            {
                return this.d_128_1Field;
            }
            set
            {
                this.d_128_1Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string D_127_2
        {
            get
            {
                return this.d_127_2Field;
            }
            set
            {
                this.d_127_2Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string D_352_3
        {
            get
            {
                return this.d_352_3Field;
            }
            set
            {
                this.d_352_3Field = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public partial class S_PER_2
    {

        private X12_ID_366 d_366_1Field;

        private string d_93_2Field;

        private X12_ID_365 d_365_3Field;

        private bool d_365_3FieldSpecified;

        private string d_364_4Field;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public X12_ID_366 D_366_1
        {
            get
            {
                return this.d_366_1Field;
            }
            set
            {
                this.d_366_1Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string D_93_2
        {
            get
            {
                return this.d_93_2Field;
            }
            set
            {
                this.d_93_2Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public X12_ID_365 D_365_3
        {
            get
            {
                return this.d_365_3Field;
            }
            set
            {
                this.d_365_3Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_365_3Specified
        {
            get
            {
                return this.d_365_3FieldSpecified;
            }
            set
            {
                this.d_365_3FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string D_364_4
        {
            get
            {
                return this.d_364_4Field;
            }
            set
            {
                this.d_364_4Field = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public partial class S_ITD
    {

        private X12_ID_336 d_336_1Field;

        private bool d_336_1FieldSpecified;

        private X12_ID_333 d_333_2Field;

        private string d_338_3Field;

        private string d_370_4Field;

        private string d_351_5Field;

        private string d_446_6Field;

        private string d_386_7Field;

        private string d_362_8Field;

        private string d_388_9Field;

        private string d_389_10Field;

        private string d_342_11Field;

        private string d_352_12Field;

        private string d_765_13Field;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public X12_ID_336 D_336_1
        {
            get
            {
                return this.d_336_1Field;
            }
            set
            {
                this.d_336_1Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_336_1Specified
        {
            get
            {
                return this.d_336_1FieldSpecified;
            }
            set
            {
                this.d_336_1FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public X12_ID_333 D_333_2
        {
            get
            {
                return this.d_333_2Field;
            }
            set
            {
                this.d_333_2Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string D_338_3
        {
            get
            {
                return this.d_338_3Field;
            }
            set
            {
                this.d_338_3Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string D_370_4
        {
            get
            {
                return this.d_370_4Field;
            }
            set
            {
                this.d_370_4Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string D_351_5
        {
            get
            {
                return this.d_351_5Field;
            }
            set
            {
                this.d_351_5Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string D_446_6
        {
            get
            {
                return this.d_446_6Field;
            }
            set
            {
                this.d_446_6Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string D_386_7
        {
            get
            {
                return this.d_386_7Field;
            }
            set
            {
                this.d_386_7Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string D_362_8
        {
            get
            {
                return this.d_362_8Field;
            }
            set
            {
                this.d_362_8Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string D_388_9
        {
            get
            {
                return this.d_388_9Field;
            }
            set
            {
                this.d_388_9Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string D_389_10
        {
            get
            {
                return this.d_389_10Field;
            }
            set
            {
                this.d_389_10Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public string D_342_11
        {
            get
            {
                return this.d_342_11Field;
            }
            set
            {
                this.d_342_11Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public string D_352_12
        {
            get
            {
                return this.d_352_12Field;
            }
            set
            {
                this.d_352_12Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public string D_765_13
        {
            get
            {
                return this.d_765_13Field;
            }
            set
            {
                this.d_765_13Field = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public enum X12_ID_336
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("01")]
        Item01,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("02")]
        Item02,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("03")]
        Item03,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04")]
        Item04,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("05")]
        Item05,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("06")]
        Item06,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("07")]
        Item07,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("08")]
        Item08,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("09")]
        Item09,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("10")]
        Item10,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("11")]
        Item11,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12")]
        Item12,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("13")]
        Item13,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("14")]
        Item14,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("16")]
        Item16,

        /// <remarks/>
        ZZ,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public enum X12_ID_333
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6")]
        Item6,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7")]
        Item7,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("8")]
        Item8,

        /// <remarks/>
        ZZ,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public partial class S_DTM
    {

        private string d_374_1Field;

        private string d_373_2Field;

        private string d_337_3Field;

        private X12_ID_623 d_623_4Field;

        private bool d_623_4FieldSpecified;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string D_374_1
        {
            get
            {
                return this.d_374_1Field;
            }
            set
            {
                this.d_374_1Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string D_373_2
        {
            get
            {
                return this.d_373_2Field;
            }
            set
            {
                this.d_373_2Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string D_337_3
        {
            get
            {
                return this.d_337_3Field;
            }
            set
            {
                this.d_337_3Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public X12_ID_623 D_623_4
        {
            get
            {
                return this.d_623_4Field;
            }
            set
            {
                this.d_623_4Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_623_4Specified
        {
            get
            {
                return this.d_623_4FieldSpecified;
            }
            set
            {
                this.d_623_4FieldSpecified = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public enum X12_ID_623
    {

        /// <remarks/>
        CD,

        /// <remarks/>
        CS,

        /// <remarks/>
        CT,

        /// <remarks/>
        ED,

        /// <remarks/>
        ES,

        /// <remarks/>
        ET,

        /// <remarks/>
        GM,

        /// <remarks/>
        LT,

        /// <remarks/>
        MD,

        /// <remarks/>
        MS,

        /// <remarks/>
        MT,

        /// <remarks/>
        PD,

        /// <remarks/>
        PS,

        /// <remarks/>
        PT,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public partial class S_FOB
    {

        private X12_ID_146 d_146_1Field;

        private X12_ID_309 d_309_2Field;

        private bool d_309_2FieldSpecified;

        private string d_352_3Field;

        private X12_ID_334 d_334_4Field;

        private bool d_334_4FieldSpecified;

        private X12_ID_335 d_335_5Field;

        private bool d_335_5FieldSpecified;

        private X12_ID_309 d_309_6Field;

        private bool d_309_6FieldSpecified;

        private string d_352_7Field;

        private X12_ID_54 d_54_8Field;

        private bool d_54_8FieldSpecified;

        private string d_352_9Field;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public X12_ID_146 D_146_1
        {
            get
            {
                return this.d_146_1Field;
            }
            set
            {
                this.d_146_1Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public X12_ID_309 D_309_2
        {
            get
            {
                return this.d_309_2Field;
            }
            set
            {
                this.d_309_2Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_309_2Specified
        {
            get
            {
                return this.d_309_2FieldSpecified;
            }
            set
            {
                this.d_309_2FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string D_352_3
        {
            get
            {
                return this.d_352_3Field;
            }
            set
            {
                this.d_352_3Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public X12_ID_334 D_334_4
        {
            get
            {
                return this.d_334_4Field;
            }
            set
            {
                this.d_334_4Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_334_4Specified
        {
            get
            {
                return this.d_334_4FieldSpecified;
            }
            set
            {
                this.d_334_4FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public X12_ID_335 D_335_5
        {
            get
            {
                return this.d_335_5Field;
            }
            set
            {
                this.d_335_5Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_335_5Specified
        {
            get
            {
                return this.d_335_5FieldSpecified;
            }
            set
            {
                this.d_335_5FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public X12_ID_309 D_309_6
        {
            get
            {
                return this.d_309_6Field;
            }
            set
            {
                this.d_309_6Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_309_6Specified
        {
            get
            {
                return this.d_309_6FieldSpecified;
            }
            set
            {
                this.d_309_6FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string D_352_7
        {
            get
            {
                return this.d_352_7Field;
            }
            set
            {
                this.d_352_7Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public X12_ID_54 D_54_8
        {
            get
            {
                return this.d_54_8Field;
            }
            set
            {
                this.d_54_8Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_54_8Specified
        {
            get
            {
                return this.d_54_8FieldSpecified;
            }
            set
            {
                this.d_54_8FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string D_352_9
        {
            get
            {
                return this.d_352_9Field;
            }
            set
            {
                this.d_352_9Field = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public enum X12_ID_146
    {

        /// <remarks/>
        CA,

        /// <remarks/>
        CC,

        /// <remarks/>
        CF,

        /// <remarks/>
        DF,

        /// <remarks/>
        FO,

        /// <remarks/>
        HP,

        /// <remarks/>
        IC,

        /// <remarks/>
        MX,

        /// <remarks/>
        NC,

        /// <remarks/>
        NR,

        /// <remarks/>
        NS,

        /// <remarks/>
        PA,

        /// <remarks/>
        PB,

        /// <remarks/>
        PC,

        /// <remarks/>
        PO,

        /// <remarks/>
        PP,

        /// <remarks/>
        PU,

        /// <remarks/>
        RC,

        /// <remarks/>
        RF,

        /// <remarks/>
        RS,

        /// <remarks/>
        TP,

        /// <remarks/>
        WC,

        /// <remarks/>
        ZZ,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public enum X12_ID_334
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("01")]
        Item01,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("02")]
        Item02,

        /// <remarks/>
        ZZ,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public enum X12_ID_335
    {

        /// <remarks/>
        CAF,

        /// <remarks/>
        CIF,

        /// <remarks/>
        DAF,

        /// <remarks/>
        DDP,

        /// <remarks/>
        EXQ,

        /// <remarks/>
        EXS,

        /// <remarks/>
        EXW,

        /// <remarks/>
        FAS,

        /// <remarks/>
        FCA,

        /// <remarks/>
        FCI,

        /// <remarks/>
        FCP,

        /// <remarks/>
        FOB,

        /// <remarks/>
        FOR,

        /// <remarks/>
        FOT,

        /// <remarks/>
        ZZZ,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public enum X12_ID_54
    {

        /// <remarks/>
        BY,

        /// <remarks/>
        FE,

        /// <remarks/>
        PP,

        /// <remarks/>
        SE,

        /// <remarks/>
        ZZ,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public partial class S_PID
    {

        private X12_ID_349 d_349_1Field;

        private X12_ID_750 d_750_2Field;

        private bool d_750_2FieldSpecified;

        private X12_ID_348 d_348_3Field;

        private bool d_348_3FieldSpecified;

        private string d_751_4Field;

        private string d_352_5Field;

        private X12_ID_752 d_752_6Field;

        private bool d_752_6FieldSpecified;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public X12_ID_349 D_349_1
        {
            get
            {
                return this.d_349_1Field;
            }
            set
            {
                this.d_349_1Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public X12_ID_750 D_750_2
        {
            get
            {
                return this.d_750_2Field;
            }
            set
            {
                this.d_750_2Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_750_2Specified
        {
            get
            {
                return this.d_750_2FieldSpecified;
            }
            set
            {
                this.d_750_2FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public X12_ID_348 D_348_3
        {
            get
            {
                return this.d_348_3Field;
            }
            set
            {
                this.d_348_3Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_348_3Specified
        {
            get
            {
                return this.d_348_3FieldSpecified;
            }
            set
            {
                this.d_348_3FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string D_751_4
        {
            get
            {
                return this.d_751_4Field;
            }
            set
            {
                this.d_751_4Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string D_352_5
        {
            get
            {
                return this.d_352_5Field;
            }
            set
            {
                this.d_352_5Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public X12_ID_752 D_752_6
        {
            get
            {
                return this.d_752_6Field;
            }
            set
            {
                this.d_752_6Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_752_6Specified
        {
            get
            {
                return this.d_752_6FieldSpecified;
            }
            set
            {
                this.d_752_6FieldSpecified = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public enum X12_ID_349
    {

        /// <remarks/>
        F,

        /// <remarks/>
        S,

        /// <remarks/>
        X,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public enum X12_ID_750
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("01")]
        Item01,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("02")]
        Item02,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("08")]
        Item08,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("09")]
        Item09,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("10")]
        Item10,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("11")]
        Item11,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12")]
        Item12,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("13")]
        Item13,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("14")]
        Item14,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("15")]
        Item15,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("16")]
        Item16,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("17")]
        Item17,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("18")]
        Item18,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("19")]
        Item19,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("20")]
        Item20,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("21")]
        Item21,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("22")]
        Item22,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("23")]
        Item23,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("25")]
        Item25,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("28")]
        Item28,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("29")]
        Item29,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("30")]
        Item30,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("32")]
        Item32,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("33")]
        Item33,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("34")]
        Item34,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("35")]
        Item35,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("36")]
        Item36,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("37")]
        Item37,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("38")]
        Item38,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("39")]
        Item39,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("40")]
        Item40,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("41")]
        Item41,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("42")]
        Item42,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("43")]
        Item43,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("54")]
        Item54,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("55")]
        Item55,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("56")]
        Item56,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("58")]
        Item58,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("59")]
        Item59,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("60")]
        Item60,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("61")]
        Item61,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("62")]
        Item62,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("63")]
        Item63,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("64")]
        Item64,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("65")]
        Item65,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("66")]
        Item66,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("67")]
        Item67,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("68")]
        Item68,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("69")]
        Item69,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("70")]
        Item70,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("71")]
        Item71,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("72")]
        Item72,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("73")]
        Item73,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("74")]
        Item74,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("75")]
        Item75,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("76")]
        Item76,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("77")]
        Item77,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("78")]
        Item78,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("79")]
        Item79,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("99")]
        Item99,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9A")]
        Item9A,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9B")]
        Item9B,

        /// <remarks/>
        BC,

        /// <remarks/>
        BW,

        /// <remarks/>
        C2,

        /// <remarks/>
        C3,

        /// <remarks/>
        C4,

        /// <remarks/>
        C5,

        /// <remarks/>
        GD,

        /// <remarks/>
        GM,

        /// <remarks/>
        HB,

        /// <remarks/>
        HZ,

        /// <remarks/>
        MS,

        /// <remarks/>
        NH,

        /// <remarks/>
        OD,

        /// <remarks/>
        OT,

        /// <remarks/>
        PP,

        /// <remarks/>
        RX,

        /// <remarks/>
        TR,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public enum X12_ID_348
    {

        /// <remarks/>
        AA,

        /// <remarks/>
        AB,

        /// <remarks/>
        AI,

        /// <remarks/>
        AP,

        /// <remarks/>
        AS,

        /// <remarks/>
        BI,

        /// <remarks/>
        CA,

        /// <remarks/>
        CC,

        /// <remarks/>
        CI,

        /// <remarks/>
        CR,

        /// <remarks/>
        DE,

        /// <remarks/>
        DR,

        /// <remarks/>
        EI,

        /// <remarks/>
        FA,

        /// <remarks/>
        FD,

        /// <remarks/>
        IS,

        /// <remarks/>
        NE,

        /// <remarks/>
        NR,

        /// <remarks/>
        OP,

        /// <remarks/>
        PA,

        /// <remarks/>
        ST,

        /// <remarks/>
        TI,

        /// <remarks/>
        TM,

        /// <remarks/>
        TX,

        /// <remarks/>
        VI,

        /// <remarks/>
        ZZ,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public enum X12_ID_752
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1S")]
        Item1S,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2S")]
        Item2S,

        /// <remarks/>
        BS,

        /// <remarks/>
        BT,

        /// <remarks/>
        IN,

        /// <remarks/>
        OA,

        /// <remarks/>
        OS,

        /// <remarks/>
        OT,

        /// <remarks/>
        R0,

        /// <remarks/>
        R1,

        /// <remarks/>
        R2,

        /// <remarks/>
        R3,

        /// <remarks/>
        R4,

        /// <remarks/>
        R5,

        /// <remarks/>
        R6,

        /// <remarks/>
        R7,

        /// <remarks/>
        R8,

        /// <remarks/>
        R9,

        /// <remarks/>
        RA,

        /// <remarks/>
        RB,

        /// <remarks/>
        RC,

        /// <remarks/>
        RD,

        /// <remarks/>
        RE,

        /// <remarks/>
        RF,

        /// <remarks/>
        RG,

        /// <remarks/>
        RH,

        /// <remarks/>
        RI,

        /// <remarks/>
        RJ,

        /// <remarks/>
        RK,

        /// <remarks/>
        RL,

        /// <remarks/>
        RM,

        /// <remarks/>
        RN,

        /// <remarks/>
        RO,

        /// <remarks/>
        RP,

        /// <remarks/>
        RQ,

        /// <remarks/>
        RR,

        /// <remarks/>
        RS,

        /// <remarks/>
        RT,

        /// <remarks/>
        RU,

        /// <remarks/>
        RV,

        /// <remarks/>
        RW,

        /// <remarks/>
        RX,

        /// <remarks/>
        RY,

        /// <remarks/>
        RZ,

        /// <remarks/>
        TP,

        /// <remarks/>
        TS,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public partial class S_MEA
    {

        private X12_ID_737 d_737_1Field;

        private bool d_737_1FieldSpecified;

        private X12_ID_738 d_738_2Field;

        private bool d_738_2FieldSpecified;

        private string d_739_3Field;

        private X12_ID_355 d_355_4Field;

        private bool d_355_4FieldSpecified;

        private string d_740_5Field;

        private string d_741_6Field;

        private X12_ID_935 d_935_7Field;

        private bool d_935_7FieldSpecified;

        private X12_ID_936 d_936_8Field;

        private bool d_936_8FieldSpecified;

        private X12_ID_752 d_752_9Field;

        private bool d_752_9FieldSpecified;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public X12_ID_737 D_737_1
        {
            get
            {
                return this.d_737_1Field;
            }
            set
            {
                this.d_737_1Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_737_1Specified
        {
            get
            {
                return this.d_737_1FieldSpecified;
            }
            set
            {
                this.d_737_1FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public X12_ID_738 D_738_2
        {
            get
            {
                return this.d_738_2Field;
            }
            set
            {
                this.d_738_2Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_738_2Specified
        {
            get
            {
                return this.d_738_2FieldSpecified;
            }
            set
            {
                this.d_738_2FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string D_739_3
        {
            get
            {
                return this.d_739_3Field;
            }
            set
            {
                this.d_739_3Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public X12_ID_355 D_355_4
        {
            get
            {
                return this.d_355_4Field;
            }
            set
            {
                this.d_355_4Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_355_4Specified
        {
            get
            {
                return this.d_355_4FieldSpecified;
            }
            set
            {
                this.d_355_4FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string D_740_5
        {
            get
            {
                return this.d_740_5Field;
            }
            set
            {
                this.d_740_5Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string D_741_6
        {
            get
            {
                return this.d_741_6Field;
            }
            set
            {
                this.d_741_6Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public X12_ID_935 D_935_7
        {
            get
            {
                return this.d_935_7Field;
            }
            set
            {
                this.d_935_7Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_935_7Specified
        {
            get
            {
                return this.d_935_7FieldSpecified;
            }
            set
            {
                this.d_935_7FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public X12_ID_936 D_936_8
        {
            get
            {
                return this.d_936_8Field;
            }
            set
            {
                this.d_936_8Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_936_8Specified
        {
            get
            {
                return this.d_936_8FieldSpecified;
            }
            set
            {
                this.d_936_8FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public X12_ID_752 D_752_9
        {
            get
            {
                return this.d_752_9Field;
            }
            set
            {
                this.d_752_9Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_752_9Specified
        {
            get
            {
                return this.d_752_9FieldSpecified;
            }
            set
            {
                this.d_752_9FieldSpecified = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public enum X12_ID_737
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9L")]
        Item9L,

        /// <remarks/>
        AA,

        /// <remarks/>
        AE,

        /// <remarks/>
        BA,

        /// <remarks/>
        BL,

        /// <remarks/>
        BP,

        /// <remarks/>
        BZ,

        /// <remarks/>
        CH,

        /// <remarks/>
        CN,

        /// <remarks/>
        CO,

        /// <remarks/>
        CS,

        /// <remarks/>
        CT,

        /// <remarks/>
        DE,

        /// <remarks/>
        DT,

        /// <remarks/>
        EA,

        /// <remarks/>
        EE,

        /// <remarks/>
        EN,

        /// <remarks/>
        IN,

        /// <remarks/>
        LC,

        /// <remarks/>
        LL,

        /// <remarks/>
        LM,

        /// <remarks/>
        P1,

        /// <remarks/>
        PC,

        /// <remarks/>
        PD,

        /// <remarks/>
        PL,

        /// <remarks/>
        PO,

        /// <remarks/>
        PR,

        /// <remarks/>
        RL,

        /// <remarks/>
        RN,

        /// <remarks/>
        RP,

        /// <remarks/>
        SE,

        /// <remarks/>
        SH,

        /// <remarks/>
        SL,

        /// <remarks/>
        SM,

        /// <remarks/>
        SP,

        /// <remarks/>
        SR,

        /// <remarks/>
        ST,

        /// <remarks/>
        SU,

        /// <remarks/>
        TD,

        /// <remarks/>
        TE,

        /// <remarks/>
        TI,

        /// <remarks/>
        TL,

        /// <remarks/>
        TR,

        /// <remarks/>
        WT,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public enum X12_ID_738
    {

        /// <remarks/>
        A,

        /// <remarks/>
        AA,

        /// <remarks/>
        AB,

        /// <remarks/>
        AC,

        /// <remarks/>
        AD,

        /// <remarks/>
        AE,

        /// <remarks/>
        AF,

        /// <remarks/>
        AG,

        /// <remarks/>
        AH,

        /// <remarks/>
        AZ,

        /// <remarks/>
        B,

        /// <remarks/>
        BA,

        /// <remarks/>
        BB,

        /// <remarks/>
        BC,

        /// <remarks/>
        BD,

        /// <remarks/>
        BE,

        /// <remarks/>
        BF,

        /// <remarks/>
        BG,

        /// <remarks/>
        BH,

        /// <remarks/>
        BK,

        /// <remarks/>
        BO,

        /// <remarks/>
        BR,

        /// <remarks/>
        BW,

        /// <remarks/>
        C,

        /// <remarks/>
        CA,

        /// <remarks/>
        CB,

        /// <remarks/>
        CD,

        /// <remarks/>
        CE,

        /// <remarks/>
        CF,

        /// <remarks/>
        CG,

        /// <remarks/>
        CH,

        /// <remarks/>
        CI,

        /// <remarks/>
        CJ,

        /// <remarks/>
        CK,

        /// <remarks/>
        CL,

        /// <remarks/>
        CN,

        /// <remarks/>
        CO,

        /// <remarks/>
        CP,

        /// <remarks/>
        CR,

        /// <remarks/>
        CS,

        /// <remarks/>
        CU,

        /// <remarks/>
        CW,

        /// <remarks/>
        D,

        /// <remarks/>
        DA,

        /// <remarks/>
        DB,

        /// <remarks/>
        DC,

        /// <remarks/>
        DD,

        /// <remarks/>
        DE,

        /// <remarks/>
        DF,

        /// <remarks/>
        DG,

        /// <remarks/>
        DH,

        /// <remarks/>
        DI,

        /// <remarks/>
        DL,

        /// <remarks/>
        DN,

        /// <remarks/>
        DP,

        /// <remarks/>
        DS,

        /// <remarks/>
        DT,

        /// <remarks/>
        DU,

        /// <remarks/>
        DW,

        /// <remarks/>
        DY,

        /// <remarks/>
        E,

        /// <remarks/>
        EA,

        /// <remarks/>
        EB,

        /// <remarks/>
        EC,

        /// <remarks/>
        ED,

        /// <remarks/>
        EE,

        /// <remarks/>
        EF,

        /// <remarks/>
        EG,

        /// <remarks/>
        EH,

        /// <remarks/>
        EL,

        /// <remarks/>
        EN,

        /// <remarks/>
        EX,

        /// <remarks/>
        F,

        /// <remarks/>
        FA,

        /// <remarks/>
        FB,

        /// <remarks/>
        FC,

        /// <remarks/>
        FD,

        /// <remarks/>
        FE,

        /// <remarks/>
        FF,

        /// <remarks/>
        FH,

        /// <remarks/>
        FI,

        /// <remarks/>
        FL,

        /// <remarks/>
        FN,

        /// <remarks/>
        FP,

        /// <remarks/>
        FR,

        /// <remarks/>
        FT,

        /// <remarks/>
        FV,

        /// <remarks/>
        FW,

        /// <remarks/>
        G,

        /// <remarks/>
        GA,

        /// <remarks/>
        GB,

        /// <remarks/>
        GC,

        /// <remarks/>
        GD,

        /// <remarks/>
        GE,

        /// <remarks/>
        GF,

        /// <remarks/>
        GG,

        /// <remarks/>
        GH,

        /// <remarks/>
        GL,

        /// <remarks/>
        GP,

        /// <remarks/>
        GW,

        /// <remarks/>
        HA,

        /// <remarks/>
        HB,

        /// <remarks/>
        HC,

        /// <remarks/>
        HD,

        /// <remarks/>
        HE,

        /// <remarks/>
        HF,

        /// <remarks/>
        HG,

        /// <remarks/>
        HH,

        /// <remarks/>
        HI,

        /// <remarks/>
        HJ,

        /// <remarks/>
        HM,

        /// <remarks/>
        HP,

        /// <remarks/>
        HR,

        /// <remarks/>
        HT,

        /// <remarks/>
        HZ,

        /// <remarks/>
        IA,

        /// <remarks/>
        IB,

        /// <remarks/>
        IC,

        /// <remarks/>
        ID,

        /// <remarks/>
        IE,

        /// <remarks/>
        IF,

        /// <remarks/>
        IG,

        /// <remarks/>
        IH,

        /// <remarks/>
        II,

        /// <remarks/>
        IJ,

        /// <remarks/>
        IK,

        /// <remarks/>
        IL,

        /// <remarks/>
        IM,

        /// <remarks/>
        IN,

        /// <remarks/>
        IO,

        /// <remarks/>
        IP,

        /// <remarks/>
        IQ,

        /// <remarks/>
        IR,

        /// <remarks/>
        IS,

        /// <remarks/>
        IT,

        /// <remarks/>
        IU,

        /// <remarks/>
        IV,

        /// <remarks/>
        IW,

        /// <remarks/>
        IX,

        /// <remarks/>
        IZ,

        /// <remarks/>
        JA,

        /// <remarks/>
        KA,

        /// <remarks/>
        KB,

        /// <remarks/>
        L,

        /// <remarks/>
        LA,

        /// <remarks/>
        LB,

        /// <remarks/>
        LC,

        /// <remarks/>
        LD,

        /// <remarks/>
        LE,

        /// <remarks/>
        LF,

        /// <remarks/>
        LG,

        /// <remarks/>
        LL,

        /// <remarks/>
        LM,

        /// <remarks/>
        LN,

        /// <remarks/>
        LO,

        /// <remarks/>
        LP,

        /// <remarks/>
        LS,

        /// <remarks/>
        LT,

        /// <remarks/>
        LW,

        /// <remarks/>
        M,

        /// <remarks/>
        MA,

        /// <remarks/>
        MB,

        /// <remarks/>
        MC,

        /// <remarks/>
        MD,

        /// <remarks/>
        ME,

        /// <remarks/>
        MF,

        /// <remarks/>
        MG,

        /// <remarks/>
        MI,

        /// <remarks/>
        MJ,

        /// <remarks/>
        MK,

        /// <remarks/>
        MN,

        /// <remarks/>
        MS,

        /// <remarks/>
        MT,

        /// <remarks/>
        MU,

        /// <remarks/>
        MV,

        /// <remarks/>
        MX,

        /// <remarks/>
        N,

        /// <remarks/>
        NA,

        /// <remarks/>
        NB,

        /// <remarks/>
        NC,

        /// <remarks/>
        ND,

        /// <remarks/>
        NE,

        /// <remarks/>
        NF,

        /// <remarks/>
        NG,

        /// <remarks/>
        NH,

        /// <remarks/>
        NI,

        /// <remarks/>
        NJ,

        /// <remarks/>
        NL,

        /// <remarks/>
        NM,

        /// <remarks/>
        NP,

        /// <remarks/>
        NS,

        /// <remarks/>
        NU,

        /// <remarks/>
        O,

        /// <remarks/>
        OA,

        /// <remarks/>
        OB,

        /// <remarks/>
        OC,

        /// <remarks/>
        OD,

        /// <remarks/>
        OE,

        /// <remarks/>
        OF,

        /// <remarks/>
        OG,

        /// <remarks/>
        OH,

        /// <remarks/>
        OI,

        /// <remarks/>
        OJ,

        /// <remarks/>
        OK,

        /// <remarks/>
        OL,

        /// <remarks/>
        OM,

        /// <remarks/>
        ON,

        /// <remarks/>
        OO,

        /// <remarks/>
        OP,

        /// <remarks/>
        OQ,

        /// <remarks/>
        OR,

        /// <remarks/>
        OS,

        /// <remarks/>
        OT,

        /// <remarks/>
        OV,

        /// <remarks/>
        OW,

        /// <remarks/>
        PA,

        /// <remarks/>
        PB,

        /// <remarks/>
        PC,

        /// <remarks/>
        PD,

        /// <remarks/>
        PE,

        /// <remarks/>
        PF,

        /// <remarks/>
        PG,

        /// <remarks/>
        PH,

        /// <remarks/>
        PI,

        /// <remarks/>
        PJ,

        /// <remarks/>
        PK,

        /// <remarks/>
        PL,

        /// <remarks/>
        PM,

        /// <remarks/>
        PN,

        /// <remarks/>
        PO,

        /// <remarks/>
        PP,

        /// <remarks/>
        PQ,

        /// <remarks/>
        PR,

        /// <remarks/>
        PS,

        /// <remarks/>
        PSA,

        /// <remarks/>
        PW,

        /// <remarks/>
        PY,

        /// <remarks/>
        PZ,

        /// <remarks/>
        QA,

        /// <remarks/>
        R,

        /// <remarks/>
        RA,

        /// <remarks/>
        RB,

        /// <remarks/>
        RC,

        /// <remarks/>
        RD,

        /// <remarks/>
        RE,

        /// <remarks/>
        RF,

        /// <remarks/>
        RG,

        /// <remarks/>
        RH,

        /// <remarks/>
        RI,

        /// <remarks/>
        RJ,

        /// <remarks/>
        RK,

        /// <remarks/>
        RL,

        /// <remarks/>
        RM,

        /// <remarks/>
        RN,

        /// <remarks/>
        RO,

        /// <remarks/>
        RP,

        /// <remarks/>
        RQ,

        /// <remarks/>
        RR,

        /// <remarks/>
        RS,

        /// <remarks/>
        RU,

        /// <remarks/>
        RV,

        /// <remarks/>
        RW,

        /// <remarks/>
        S,

        /// <remarks/>
        S1,

        /// <remarks/>
        S2,

        /// <remarks/>
        SA,

        /// <remarks/>
        SB,

        /// <remarks/>
        SC,

        /// <remarks/>
        SD,

        /// <remarks/>
        SE,

        /// <remarks/>
        SF,

        /// <remarks/>
        SG,

        /// <remarks/>
        SH,

        /// <remarks/>
        SI,

        /// <remarks/>
        SJ,

        /// <remarks/>
        SK,

        /// <remarks/>
        SL,

        /// <remarks/>
        SM,

        /// <remarks/>
        SN,

        /// <remarks/>
        SO,

        /// <remarks/>
        SP,

        /// <remarks/>
        SQ,

        /// <remarks/>
        SR,

        /// <remarks/>
        SS,

        /// <remarks/>
        ST,

        /// <remarks/>
        SU,

        /// <remarks/>
        SV,

        /// <remarks/>
        SW,

        /// <remarks/>
        SX,

        /// <remarks/>
        SY,

        /// <remarks/>
        SZ,

        /// <remarks/>
        T,

        /// <remarks/>
        TA,

        /// <remarks/>
        TB,

        /// <remarks/>
        TC,

        /// <remarks/>
        TD,

        /// <remarks/>
        TE,

        /// <remarks/>
        TF,

        /// <remarks/>
        TG,

        /// <remarks/>
        TH,

        /// <remarks/>
        TI,

        /// <remarks/>
        TJ,

        /// <remarks/>
        TK,

        /// <remarks/>
        TL,

        /// <remarks/>
        TM,

        /// <remarks/>
        TN,

        /// <remarks/>
        TO,

        /// <remarks/>
        TP,

        /// <remarks/>
        TQ,

        /// <remarks/>
        TR,

        /// <remarks/>
        TS,

        /// <remarks/>
        TT,

        /// <remarks/>
        TU,

        /// <remarks/>
        TV,

        /// <remarks/>
        TX,

        /// <remarks/>
        TY,

        /// <remarks/>
        U,

        /// <remarks/>
        UA,

        /// <remarks/>
        VH,

        /// <remarks/>
        VW,

        /// <remarks/>
        WA,

        /// <remarks/>
        WB,

        /// <remarks/>
        WC,

        /// <remarks/>
        WD,

        /// <remarks/>
        WE,

        /// <remarks/>
        WF,

        /// <remarks/>
        WL,

        /// <remarks/>
        WM,

        /// <remarks/>
        WT,

        /// <remarks/>
        WU,

        /// <remarks/>
        X,

        /// <remarks/>
        XA,

        /// <remarks/>
        XH,

        /// <remarks/>
        XP,

        /// <remarks/>
        XQ,

        /// <remarks/>
        XZ,

        /// <remarks/>
        YA,

        /// <remarks/>
        YB,

        /// <remarks/>
        YC,

        /// <remarks/>
        ZA,

        /// <remarks/>
        ZAL,

        /// <remarks/>
        ZAS,

        /// <remarks/>
        ZB,

        /// <remarks/>
        ZBI,

        /// <remarks/>
        ZC,

        /// <remarks/>
        ZCA,

        /// <remarks/>
        ZCB,

        /// <remarks/>
        ZCE,

        /// <remarks/>
        ZCO,

        /// <remarks/>
        ZCR,

        /// <remarks/>
        ZCU,

        /// <remarks/>
        ZFE,

        /// <remarks/>
        ZFS,

        /// <remarks/>
        ZGE,

        /// <remarks/>
        ZH,

        /// <remarks/>
        ZMG,

        /// <remarks/>
        ZMN,

        /// <remarks/>
        ZMO,

        /// <remarks/>
        ZN,

        /// <remarks/>
        ZNB,

        /// <remarks/>
        ZNI,

        /// <remarks/>
        ZO,

        /// <remarks/>
        ZP,

        /// <remarks/>
        ZPB,

        /// <remarks/>
        ZS,

        /// <remarks/>
        ZSB,

        /// <remarks/>
        ZSE,

        /// <remarks/>
        ZSI,

        /// <remarks/>
        ZSN,

        /// <remarks/>
        ZTA,

        /// <remarks/>
        ZTE,

        /// <remarks/>
        ZTI,

        /// <remarks/>
        ZV,

        /// <remarks/>
        ZW,

        /// <remarks/>
        ZZN,

        /// <remarks/>
        ZZR,

        /// <remarks/>
        ZZZ,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public enum X12_ID_355
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("01")]
        Item01,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("02")]
        Item02,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("03")]
        Item03,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04")]
        Item04,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("05")]
        Item05,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("08")]
        Item08,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("10")]
        Item10,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("11")]
        Item11,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12")]
        Item12,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("13")]
        Item13,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("14")]
        Item14,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("15")]
        Item15,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("24")]
        Item24,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("26")]
        Item26,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("27")]
        Item27,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("31")]
        Item31,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("50")]
        Item50,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("51")]
        Item51,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("53")]
        Item53,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("54")]
        Item54,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("56")]
        Item56,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("58")]
        Item58,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("59")]
        Item59,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("60")]
        Item60,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("61")]
        Item61,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("62")]
        Item62,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("63")]
        Item63,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("64")]
        Item64,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("65")]
        Item65,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("66")]
        Item66,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("67")]
        Item67,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("68")]
        Item68,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("69")]
        Item69,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("70")]
        Item70,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("71")]
        Item71,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("72")]
        Item72,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("73")]
        Item73,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("74")]
        Item74,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("75")]
        Item75,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("76")]
        Item76,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("77")]
        Item77,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("78")]
        Item78,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("79")]
        Item79,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("80")]
        Item80,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("81")]
        Item81,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("82")]
        Item82,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("83")]
        Item83,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("84")]
        Item84,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("85")]
        Item85,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("86")]
        Item86,

        /// <remarks/>
        AA,

        /// <remarks/>
        AC,

        /// <remarks/>
        AM,

        /// <remarks/>
        AP,

        /// <remarks/>
        AS,

        /// <remarks/>
        AY,

        /// <remarks/>
        B1,

        /// <remarks/>
        B2,

        /// <remarks/>
        B3,

        /// <remarks/>
        B4,

        /// <remarks/>
        B5,

        /// <remarks/>
        B6,

        /// <remarks/>
        B7,

        /// <remarks/>
        B8,

        /// <remarks/>
        B9,

        /// <remarks/>
        BA,

        /// <remarks/>
        BB,

        /// <remarks/>
        BC,

        /// <remarks/>
        BD,

        /// <remarks/>
        BE,

        /// <remarks/>
        BF,

        /// <remarks/>
        BG,

        /// <remarks/>
        BH,

        /// <remarks/>
        BI,

        /// <remarks/>
        BJ,

        /// <remarks/>
        BK,

        /// <remarks/>
        BL,

        /// <remarks/>
        BM,

        /// <remarks/>
        BN,

        /// <remarks/>
        BO,

        /// <remarks/>
        BP,

        /// <remarks/>
        BQ,

        /// <remarks/>
        BR,

        /// <remarks/>
        BS,

        /// <remarks/>
        BT,

        /// <remarks/>
        BU,

        /// <remarks/>
        BV,

        /// <remarks/>
        BW,

        /// <remarks/>
        BX,

        /// <remarks/>
        BY,

        /// <remarks/>
        BZ,

        /// <remarks/>
        C1,

        /// <remarks/>
        C2,

        /// <remarks/>
        C3,

        /// <remarks/>
        C4,

        /// <remarks/>
        C5,

        /// <remarks/>
        C6,

        /// <remarks/>
        C7,

        /// <remarks/>
        C8,

        /// <remarks/>
        C9,

        /// <remarks/>
        CA,

        /// <remarks/>
        CB,

        /// <remarks/>
        CC,

        /// <remarks/>
        CD,

        /// <remarks/>
        CE,

        /// <remarks/>
        CF,

        /// <remarks/>
        CG,

        /// <remarks/>
        CH,

        /// <remarks/>
        CI,

        /// <remarks/>
        CJ,

        /// <remarks/>
        CK,

        /// <remarks/>
        CL,

        /// <remarks/>
        CM,

        /// <remarks/>
        CN,

        /// <remarks/>
        CO,

        /// <remarks/>
        CP,

        /// <remarks/>
        CQ,

        /// <remarks/>
        CR,

        /// <remarks/>
        CS,

        /// <remarks/>
        CT,

        /// <remarks/>
        CU,

        /// <remarks/>
        CV,

        /// <remarks/>
        CW,

        /// <remarks/>
        CX,

        /// <remarks/>
        CY,

        /// <remarks/>
        CZ,

        /// <remarks/>
        DA,

        /// <remarks/>
        DB,

        /// <remarks/>
        DC,

        /// <remarks/>
        DD,

        /// <remarks/>
        DE,

        /// <remarks/>
        DF,

        /// <remarks/>
        DG,

        /// <remarks/>
        DH,

        /// <remarks/>
        DI,

        /// <remarks/>
        DJ,

        /// <remarks/>
        DK,

        /// <remarks/>
        DL,

        /// <remarks/>
        DM,

        /// <remarks/>
        DP,

        /// <remarks/>
        DR,

        /// <remarks/>
        DS,

        /// <remarks/>
        DT,

        /// <remarks/>
        DZ,

        /// <remarks/>
        E3,

        /// <remarks/>
        E4,

        /// <remarks/>
        E5,

        /// <remarks/>
        E7,

        /// <remarks/>
        E8,

        /// <remarks/>
        E9,

        /// <remarks/>
        EA,

        /// <remarks/>
        ED,

        /// <remarks/>
        EF,

        /// <remarks/>
        EM,

        /// <remarks/>
        EP,

        /// <remarks/>
        EV,

        /// <remarks/>
        EX,

        /// <remarks/>
        EY,

        /// <remarks/>
        EZ,

        /// <remarks/>
        FA,

        /// <remarks/>
        FC,

        /// <remarks/>
        FM,

        /// <remarks/>
        FO,

        /// <remarks/>
        FP,

        /// <remarks/>
        FT,

        /// <remarks/>
        GA,

        /// <remarks/>
        GB,

        /// <remarks/>
        GD,

        /// <remarks/>
        GG,

        /// <remarks/>
        GH,

        /// <remarks/>
        GI,

        /// <remarks/>
        GL,

        /// <remarks/>
        GM,

        /// <remarks/>
        GN,

        /// <remarks/>
        GR,

        /// <remarks/>
        GS,

        /// <remarks/>
        GY,

        /// <remarks/>
        GZ,

        /// <remarks/>
        HA,

        /// <remarks/>
        HB,

        /// <remarks/>
        HC,

        /// <remarks/>
        HD,

        /// <remarks/>
        HE,

        /// <remarks/>
        HF,

        /// <remarks/>
        HG,

        /// <remarks/>
        HH,

        /// <remarks/>
        HI,

        /// <remarks/>
        HJ,

        /// <remarks/>
        HK,

        /// <remarks/>
        HL,

        /// <remarks/>
        HO,

        /// <remarks/>
        HP,

        /// <remarks/>
        HR,

        /// <remarks/>
        HS,

        /// <remarks/>
        HT,

        /// <remarks/>
        HU,

        /// <remarks/>
        HV,

        /// <remarks/>
        HW,

        /// <remarks/>
        HY,

        /// <remarks/>
        IC,

        /// <remarks/>
        IN,

        /// <remarks/>
        IT,

        /// <remarks/>
        JB,

        /// <remarks/>
        JO,

        /// <remarks/>
        JR,

        /// <remarks/>
        JU,

        /// <remarks/>
        KA,

        /// <remarks/>
        KD,

        /// <remarks/>
        KE,

        /// <remarks/>
        KG,

        /// <remarks/>
        KH,

        /// <remarks/>
        KI,

        /// <remarks/>
        KK,

        /// <remarks/>
        KL,

        /// <remarks/>
        KM,

        /// <remarks/>
        KN,

        /// <remarks/>
        KT,

        /// <remarks/>
        KV,

        /// <remarks/>
        KW,

        /// <remarks/>
        LA,

        /// <remarks/>
        LB,

        /// <remarks/>
        LC,

        /// <remarks/>
        LE,

        /// <remarks/>
        LF,

        /// <remarks/>
        LG,

        /// <remarks/>
        LH,

        /// <remarks/>
        LI,

        /// <remarks/>
        LJ,

        /// <remarks/>
        LK,

        /// <remarks/>
        LM,

        /// <remarks/>
        LN,

        /// <remarks/>
        LO,

        /// <remarks/>
        LP,

        /// <remarks/>
        LR,

        /// <remarks/>
        LS,

        /// <remarks/>
        LT,

        /// <remarks/>
        LY,

        /// <remarks/>
        M1,

        /// <remarks/>
        M2,

        /// <remarks/>
        M3,

        /// <remarks/>
        M4,

        /// <remarks/>
        M6,

        /// <remarks/>
        MA,

        /// <remarks/>
        MB,

        /// <remarks/>
        MC,

        /// <remarks/>
        ME,

        /// <remarks/>
        MF,

        /// <remarks/>
        MG,

        /// <remarks/>
        MH,

        /// <remarks/>
        MI,

        /// <remarks/>
        MJ,

        /// <remarks/>
        MK,

        /// <remarks/>
        ML,

        /// <remarks/>
        MM,

        /// <remarks/>
        MN,

        /// <remarks/>
        MO,

        /// <remarks/>
        MP,

        /// <remarks/>
        MQ,

        /// <remarks/>
        MR,

        /// <remarks/>
        MS,

        /// <remarks/>
        MT,

        /// <remarks/>
        MU,

        /// <remarks/>
        MV,

        /// <remarks/>
        MW,

        /// <remarks/>
        MX,

        /// <remarks/>
        MY,

        /// <remarks/>
        MZ,

        /// <remarks/>
        NB,

        /// <remarks/>
        NC,

        /// <remarks/>
        ND,

        /// <remarks/>
        NG,

        /// <remarks/>
        NL,

        /// <remarks/>
        NM,

        /// <remarks/>
        NN,

        /// <remarks/>
        NT,

        /// <remarks/>
        NV,

        /// <remarks/>
        ON,

        /// <remarks/>
        OP,

        /// <remarks/>
        OT,

        /// <remarks/>
        OZ,

        /// <remarks/>
        P1,

        /// <remarks/>
        P2,

        /// <remarks/>
        P3,

        /// <remarks/>
        P4,

        /// <remarks/>
        P5,

        /// <remarks/>
        P6,

        /// <remarks/>
        P7,

        /// <remarks/>
        P8,

        /// <remarks/>
        P9,

        /// <remarks/>
        PA,

        /// <remarks/>
        PB,

        /// <remarks/>
        PC,

        /// <remarks/>
        PD,

        /// <remarks/>
        PE,

        /// <remarks/>
        PF,

        /// <remarks/>
        PG,

        /// <remarks/>
        PH,

        /// <remarks/>
        PI,

        /// <remarks/>
        PJ,

        /// <remarks/>
        PK,

        /// <remarks/>
        PL,

        /// <remarks/>
        PM,

        /// <remarks/>
        PN,

        /// <remarks/>
        PO,

        /// <remarks/>
        PP,

        /// <remarks/>
        PQ,

        /// <remarks/>
        PR,

        /// <remarks/>
        PS,

        /// <remarks/>
        PT,

        /// <remarks/>
        PU,

        /// <remarks/>
        PV,

        /// <remarks/>
        PW,

        /// <remarks/>
        PX,

        /// <remarks/>
        PY,

        /// <remarks/>
        PZ,

        /// <remarks/>
        Q1,

        /// <remarks/>
        QD,

        /// <remarks/>
        QR,

        /// <remarks/>
        QS,

        /// <remarks/>
        QT,

        /// <remarks/>
        QU,

        /// <remarks/>
        RA,

        /// <remarks/>
        RD,

        /// <remarks/>
        RE,

        /// <remarks/>
        RG,

        /// <remarks/>
        RK,

        /// <remarks/>
        RL,

        /// <remarks/>
        RM,

        /// <remarks/>
        RN,

        /// <remarks/>
        RO,

        /// <remarks/>
        RP,

        /// <remarks/>
        RU,

        /// <remarks/>
        S2,

        /// <remarks/>
        SA,

        /// <remarks/>
        SB,

        /// <remarks/>
        SC,

        /// <remarks/>
        SD,

        /// <remarks/>
        SE,

        /// <remarks/>
        SF,

        /// <remarks/>
        SG,

        /// <remarks/>
        SH,

        /// <remarks/>
        SI,

        /// <remarks/>
        SJ,

        /// <remarks/>
        SK,

        /// <remarks/>
        SL,

        /// <remarks/>
        SM,

        /// <remarks/>
        SN,

        /// <remarks/>
        SO,

        /// <remarks/>
        SP,

        /// <remarks/>
        SQ,

        /// <remarks/>
        SR,

        /// <remarks/>
        SS,

        /// <remarks/>
        ST,

        /// <remarks/>
        SU,

        /// <remarks/>
        SV,

        /// <remarks/>
        SW,

        /// <remarks/>
        SX,

        /// <remarks/>
        SY,

        /// <remarks/>
        T1,

        /// <remarks/>
        T2,

        /// <remarks/>
        T3,

        /// <remarks/>
        TA,

        /// <remarks/>
        TB,

        /// <remarks/>
        TC,

        /// <remarks/>
        TD,

        /// <remarks/>
        TE,

        /// <remarks/>
        TF,

        /// <remarks/>
        TG,

        /// <remarks/>
        TH,

        /// <remarks/>
        TI,

        /// <remarks/>
        TJ,

        /// <remarks/>
        TK,

        /// <remarks/>
        TL,

        /// <remarks/>
        TM,

        /// <remarks/>
        TN,

        /// <remarks/>
        TO,

        /// <remarks/>
        TP,

        /// <remarks/>
        TQ,

        /// <remarks/>
        TR,

        /// <remarks/>
        TS,

        /// <remarks/>
        TT,

        /// <remarks/>
        TU,

        /// <remarks/>
        TV,

        /// <remarks/>
        TW,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("TW")]
        TW1,

        /// <remarks/>
        TX,

        /// <remarks/>
        TY,

        /// <remarks/>
        TZ,

        /// <remarks/>
        UN,

        /// <remarks/>
        VI,

        /// <remarks/>
        VT,

        /// <remarks/>
        WB,

        /// <remarks/>
        WE,

        /// <remarks/>
        WG,

        /// <remarks/>
        WH,

        /// <remarks/>
        WI,

        /// <remarks/>
        WK,

        /// <remarks/>
        WP,

        /// <remarks/>
        WR,

        /// <remarks/>
        WT,

        /// <remarks/>
        YD,

        /// <remarks/>
        YL,

        /// <remarks/>
        YR,

        /// <remarks/>
        YT,

        /// <remarks/>
        ZZ,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public enum X12_ID_935
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("01")]
        Item01,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("02")]
        Item02,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("03")]
        Item03,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04")]
        Item04,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("05")]
        Item05,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("06")]
        Item06,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("07")]
        Item07,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("08")]
        Item08,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("09")]
        Item09,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("10")]
        Item10,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public enum X12_ID_936
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("01")]
        Item01,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("02")]
        Item02,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("03")]
        Item03,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04")]
        Item04,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("05")]
        Item05,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("06")]
        Item06,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("07")]
        Item07,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("08")]
        Item08,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("09")]
        Item09,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("10")]
        Item10,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("11")]
        Item11,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12")]
        Item12,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("13")]
        Item13,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("14")]
        Item14,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("15")]
        Item15,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("16")]
        Item16,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("17")]
        Item17,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("18")]
        Item18,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("19")]
        Item19,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("20")]
        Item20,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("21")]
        Item21,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("22")]
        Item22,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("23")]
        Item23,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("24")]
        Item24,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("25")]
        Item25,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("26")]
        Item26,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("27")]
        Item27,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public partial class S_PWK
    {

        private X12_ID_755 d_755_1Field;

        private X12_ID_756 d_756_2Field;

        private string d_757_3Field;

        private X12_ID_98 d_98_4Field;

        private bool d_98_4FieldSpecified;

        private X12_ID_66 d_66_5Field;

        private bool d_66_5FieldSpecified;

        private string d_67_6Field;

        private string d_352_7Field;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public X12_ID_755 D_755_1
        {
            get
            {
                return this.d_755_1Field;
            }
            set
            {
                this.d_755_1Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public X12_ID_756 D_756_2
        {
            get
            {
                return this.d_756_2Field;
            }
            set
            {
                this.d_756_2Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string D_757_3
        {
            get
            {
                return this.d_757_3Field;
            }
            set
            {
                this.d_757_3Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public X12_ID_98 D_98_4
        {
            get
            {
                return this.d_98_4Field;
            }
            set
            {
                this.d_98_4Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_98_4Specified
        {
            get
            {
                return this.d_98_4FieldSpecified;
            }
            set
            {
                this.d_98_4FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public X12_ID_66 D_66_5
        {
            get
            {
                return this.d_66_5Field;
            }
            set
            {
                this.d_66_5Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_66_5Specified
        {
            get
            {
                return this.d_66_5FieldSpecified;
            }
            set
            {
                this.d_66_5FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string D_67_6
        {
            get
            {
                return this.d_67_6Field;
            }
            set
            {
                this.d_67_6Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string D_352_7
        {
            get
            {
                return this.d_352_7Field;
            }
            set
            {
                this.d_352_7Field = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public enum X12_ID_755
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("01")]
        Item01,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("02")]
        Item02,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("11")]
        Item11,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12")]
        Item12,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("13")]
        Item13,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("14")]
        Item14,

        /// <remarks/>
        AA,

        /// <remarks/>
        AD,

        /// <remarks/>
        AO,

        /// <remarks/>
        AP,

        /// <remarks/>
        BL,

        /// <remarks/>
        BT,

        /// <remarks/>
        CA,

        /// <remarks/>
        CC,

        /// <remarks/>
        CD,

        /// <remarks/>
        CI,

        /// <remarks/>
        CM,

        /// <remarks/>
        CP,

        /// <remarks/>
        CS,

        /// <remarks/>
        DC,

        /// <remarks/>
        DD,

        /// <remarks/>
        DM,

        /// <remarks/>
        DN,

        /// <remarks/>
        DR,

        /// <remarks/>
        EA,

        /// <remarks/>
        FD,

        /// <remarks/>
        FH,

        /// <remarks/>
        IP,

        /// <remarks/>
        IT,

        /// <remarks/>
        IV,

        /// <remarks/>
        LC,

        /// <remarks/>
        MA,

        /// <remarks/>
        MB,

        /// <remarks/>
        MC,

        /// <remarks/>
        MD,

        /// <remarks/>
        MM,

        /// <remarks/>
        MR,

        /// <remarks/>
        MS,

        /// <remarks/>
        PC,

        /// <remarks/>
        PD,

        /// <remarks/>
        PI,

        /// <remarks/>
        PT,

        /// <remarks/>
        RF,

        /// <remarks/>
        RT,

        /// <remarks/>
        SA,

        /// <remarks/>
        SE,

        /// <remarks/>
        SI,

        /// <remarks/>
        SL,

        /// <remarks/>
        SM,

        /// <remarks/>
        SN,

        /// <remarks/>
        SQ,

        /// <remarks/>
        SR,

        /// <remarks/>
        SS,

        /// <remarks/>
        US,

        /// <remarks/>
        VD,

        /// <remarks/>
        VM,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public enum X12_ID_756
    {

        /// <remarks/>
        AE,

        /// <remarks/>
        AM,

        /// <remarks/>
        BM,

        /// <remarks/>
        BW,

        /// <remarks/>
        EL,

        /// <remarks/>
        IE,

        /// <remarks/>
        IM,

        /// <remarks/>
        SE,

        /// <remarks/>
        SM,

        /// <remarks/>
        SN,

        /// <remarks/>
        TE,

        /// <remarks/>
        TM,

        /// <remarks/>
        WS,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public partial class S_PKG
    {

        private X12_ID_349 d_349_1Field;

        private X12_ID_753 d_753_2Field;

        private bool d_753_2FieldSpecified;

        private X12_ID_348 d_348_3Field;

        private bool d_348_3FieldSpecified;

        private string d_754_4Field;

        private string d_352_5Field;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public X12_ID_349 D_349_1
        {
            get
            {
                return this.d_349_1Field;
            }
            set
            {
                this.d_349_1Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public X12_ID_753 D_753_2
        {
            get
            {
                return this.d_753_2Field;
            }
            set
            {
                this.d_753_2Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_753_2Specified
        {
            get
            {
                return this.d_753_2FieldSpecified;
            }
            set
            {
                this.d_753_2FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public X12_ID_348 D_348_3
        {
            get
            {
                return this.d_348_3Field;
            }
            set
            {
                this.d_348_3Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_348_3Specified
        {
            get
            {
                return this.d_348_3FieldSpecified;
            }
            set
            {
                this.d_348_3FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string D_754_4
        {
            get
            {
                return this.d_754_4Field;
            }
            set
            {
                this.d_754_4Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string D_352_5
        {
            get
            {
                return this.d_352_5Field;
            }
            set
            {
                this.d_352_5Field = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public enum X12_ID_753
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("10")]
        Item10,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("11")]
        Item11,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("34")]
        Item34,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("35")]
        Item35,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("36")]
        Item36,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("37")]
        Item37,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("38")]
        Item38,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("39")]
        Item39,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("40")]
        Item40,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("42")]
        Item42,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("43")]
        Item43,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("44")]
        Item44,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("45")]
        Item45,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("60")]
        Item60,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("61")]
        Item61,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("62")]
        Item62,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("63")]
        Item63,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("65")]
        Item65,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("66")]
        Item66,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("67")]
        Item67,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("68")]
        Item68,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public partial class S_L7
    {

        private string d_213_1Field;

        private string d_168_2Field;

        private string d_171_3Field;

        private string d_172_4Field;

        private string d_169_5Field;

        private string d_170_6Field;

        private string d_59_7Field;

        private string d_173_8Field;

        private string d_46_9Field;

        private string d_37_10Field;

        private string d_119_11Field;

        private string d_227_12Field;

        private string d_294_13Field;

        private X12_ID_295 d_295_14Field;

        private bool d_295_14FieldSpecified;

        private string d_19_15Field;

        private string d_156_16Field;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string D_213_1
        {
            get
            {
                return this.d_213_1Field;
            }
            set
            {
                this.d_213_1Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string D_168_2
        {
            get
            {
                return this.d_168_2Field;
            }
            set
            {
                this.d_168_2Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string D_171_3
        {
            get
            {
                return this.d_171_3Field;
            }
            set
            {
                this.d_171_3Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string D_172_4
        {
            get
            {
                return this.d_172_4Field;
            }
            set
            {
                this.d_172_4Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string D_169_5
        {
            get
            {
                return this.d_169_5Field;
            }
            set
            {
                this.d_169_5Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string D_170_6
        {
            get
            {
                return this.d_170_6Field;
            }
            set
            {
                this.d_170_6Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string D_59_7
        {
            get
            {
                return this.d_59_7Field;
            }
            set
            {
                this.d_59_7Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string D_173_8
        {
            get
            {
                return this.d_173_8Field;
            }
            set
            {
                this.d_173_8Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string D_46_9
        {
            get
            {
                return this.d_46_9Field;
            }
            set
            {
                this.d_46_9Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string D_37_10
        {
            get
            {
                return this.d_37_10Field;
            }
            set
            {
                this.d_37_10Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public string D_119_11
        {
            get
            {
                return this.d_119_11Field;
            }
            set
            {
                this.d_119_11Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public string D_227_12
        {
            get
            {
                return this.d_227_12Field;
            }
            set
            {
                this.d_227_12Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public string D_294_13
        {
            get
            {
                return this.d_294_13Field;
            }
            set
            {
                this.d_294_13Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public X12_ID_295 D_295_14
        {
            get
            {
                return this.d_295_14Field;
            }
            set
            {
                this.d_295_14Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_295_14Specified
        {
            get
            {
                return this.d_295_14FieldSpecified;
            }
            set
            {
                this.d_295_14FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
        public string D_19_15
        {
            get
            {
                return this.d_19_15Field;
            }
            set
            {
                this.d_19_15Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 15)]
        public string D_156_16
        {
            get
            {
                return this.d_156_16Field;
            }
            set
            {
                this.d_156_16Field = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public enum X12_ID_295
    {

        /// <remarks/>
        A,

        /// <remarks/>
        B,

        /// <remarks/>
        D,

        /// <remarks/>
        F,

        /// <remarks/>
        K,

        /// <remarks/>
        L,

        /// <remarks/>
        M,

        /// <remarks/>
        T,

        /// <remarks/>
        X,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public partial class G_IT1
    {

        private S_IT1 s_IT1Field;

        private S_CUR_2 s_CUR_2Field;

        private List<S_IT3> s_IT3Field;

        private List<S_TXI> s_TXIField;

        private List<S_CTP> s_CTPField;

        private List<S_PID_2> s_PID_2Field;

        private List<S_MEA_2> s_MEA_2Field;

        private List<S_PWK_2> s_PWK_2Field;

        private List<S_PKG_2> s_PKG_2Field;

        private S_PO4 s_PO4Field;

        private List<S_ITD_2> s_ITD_2Field;

        private List<S_REF_3> s_REF_3Field;

        private List<S_PER_3> s_PER_3Field;

        private List<S_SDQ> s_SDQField;

        private List<S_DTM_2> s_DTM_2Field;

        private List<S_CAD> s_CADField;

        private List<S_L7_2> s_L7_2Field;

        private List<G_ITA> g_ITAField;

        private List<G_SLN> g_SLNField;

        private List<G_N1_2> g_N1_2Field;

        public G_IT1()
        {
            this.g_N1_2Field = new List<G_N1_2>();
            this.g_SLNField = new List<G_SLN>();
            this.g_ITAField = new List<G_ITA>();
            this.s_L7_2Field = new List<S_L7_2>();
            this.s_CADField = new List<S_CAD>();
            this.s_DTM_2Field = new List<S_DTM_2>();
            this.s_SDQField = new List<S_SDQ>();
            this.s_PER_3Field = new List<S_PER_3>();
            this.s_REF_3Field = new List<S_REF_3>();
            this.s_ITD_2Field = new List<S_ITD_2>();
            this.s_PO4Field = new S_PO4();
            this.s_PKG_2Field = new List<S_PKG_2>();
            this.s_PWK_2Field = new List<S_PWK_2>();
            this.s_MEA_2Field = new List<S_MEA_2>();
            this.s_PID_2Field = new List<S_PID_2>();
            this.s_CTPField = new List<S_CTP>();
            this.s_TXIField = new List<S_TXI>();
            this.s_IT3Field = new List<S_IT3>();
            this.s_CUR_2Field = new S_CUR_2();
            this.s_IT1Field = new S_IT1();
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public S_IT1 S_IT1
        {
            get
            {
                return this.s_IT1Field;
            }
            set
            {
                this.s_IT1Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public S_CUR_2 S_CUR_2
        {
            get
            {
                return this.s_CUR_2Field;
            }
            set
            {
                this.s_CUR_2Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("S_IT3", Order = 2)]
        public List<S_IT3> S_IT3
        {
            get
            {
                return this.s_IT3Field;
            }
            set
            {
                this.s_IT3Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("S_TXI", Order = 3)]
        public List<S_TXI> S_TXI
        {
            get
            {
                return this.s_TXIField;
            }
            set
            {
                this.s_TXIField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("S_CTP", Order = 4)]
        public List<S_CTP> S_CTP
        {
            get
            {
                return this.s_CTPField;
            }
            set
            {
                this.s_CTPField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("S_PID_2", Order = 5)]
        public List<S_PID_2> S_PID_2
        {
            get
            {
                return this.s_PID_2Field;
            }
            set
            {
                this.s_PID_2Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("S_MEA_2", Order = 6)]
        public List<S_MEA_2> S_MEA_2
        {
            get
            {
                return this.s_MEA_2Field;
            }
            set
            {
                this.s_MEA_2Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("S_PWK_2", Order = 7)]
        public List<S_PWK_2> S_PWK_2
        {
            get
            {
                return this.s_PWK_2Field;
            }
            set
            {
                this.s_PWK_2Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("S_PKG_2", Order = 8)]
        public List<S_PKG_2> S_PKG_2
        {
            get
            {
                return this.s_PKG_2Field;
            }
            set
            {
                this.s_PKG_2Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public S_PO4 S_PO4
        {
            get
            {
                return this.s_PO4Field;
            }
            set
            {
                this.s_PO4Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("S_ITD_2", Order = 10)]
        public List<S_ITD_2> S_ITD_2
        {
            get
            {
                return this.s_ITD_2Field;
            }
            set
            {
                this.s_ITD_2Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("S_REF_3", Order = 11)]
        public List<S_REF_3> S_REF_3
        {
            get
            {
                return this.s_REF_3Field;
            }
            set
            {
                this.s_REF_3Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("S_PER_3", Order = 12)]
        public List<S_PER_3> S_PER_3
        {
            get
            {
                return this.s_PER_3Field;
            }
            set
            {
                this.s_PER_3Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("S_SDQ", Order = 13)]
        public List<S_SDQ> S_SDQ
        {
            get
            {
                return this.s_SDQField;
            }
            set
            {
                this.s_SDQField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("S_DTM_2", Order = 14)]
        public List<S_DTM_2> S_DTM_2
        {
            get
            {
                return this.s_DTM_2Field;
            }
            set
            {
                this.s_DTM_2Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("S_CAD", Order = 15)]
        public List<S_CAD> S_CAD
        {
            get
            {
                return this.s_CADField;
            }
            set
            {
                this.s_CADField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("S_L7_2", Order = 16)]
        public List<S_L7_2> S_L7_2
        {
            get
            {
                return this.s_L7_2Field;
            }
            set
            {
                this.s_L7_2Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("G_ITA", Order = 17)]
        public List<G_ITA> G_ITA
        {
            get
            {
                return this.g_ITAField;
            }
            set
            {
                this.g_ITAField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("G_SLN", Order = 18)]
        public List<G_SLN> G_SLN
        {
            get
            {
                return this.g_SLNField;
            }
            set
            {
                this.g_SLNField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("G_N1_2", Order = 19)]
        public List<G_N1_2> G_N1_2
        {
            get
            {
                return this.g_N1_2Field;
            }
            set
            {
                this.g_N1_2Field = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public partial class S_IT1
    {

        private string d_350_1Field;

        private string d_358_2Field;

        private X12_ID_355 d_355_3Field;

        private string d_212_4Field;

        private X12_ID_639 d_639_5Field;

        private bool d_639_5FieldSpecified;

        private X12_ID_235 d_235_6Field;

        private bool d_235_6FieldSpecified;

        private string d_234_7Field;

        private X12_ID_235 d_235_8Field;

        private bool d_235_8FieldSpecified;

        private string d_234_9Field;

        private X12_ID_235 d_235_10Field;

        private bool d_235_10FieldSpecified;

        private string d_234_11Field;

        private X12_ID_235 d_235_12Field;

        private bool d_235_12FieldSpecified;

        private string d_234_13Field;

        private X12_ID_235 d_235_14Field;

        private bool d_235_14FieldSpecified;

        private string d_234_15Field;

        private X12_ID_235 d_235_16Field;

        private bool d_235_16FieldSpecified;

        private string d_234_17Field;

        private X12_ID_235 d_235_18Field;

        private bool d_235_18FieldSpecified;

        private string d_234_19Field;

        private X12_ID_235 d_235_20Field;

        private bool d_235_20FieldSpecified;

        private string d_234_21Field;

        private X12_ID_235 d_235_22Field;

        private bool d_235_22FieldSpecified;

        private string d_234_23Field;

        private X12_ID_235 d_235_24Field;

        private bool d_235_24FieldSpecified;

        private string d_234_25Field;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string D_350_1
        {
            get
            {
                return this.d_350_1Field;
            }
            set
            {
                this.d_350_1Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string D_358_2
        {
            get
            {
                return this.d_358_2Field;
            }
            set
            {
                this.d_358_2Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public X12_ID_355 D_355_3
        {
            get
            {
                return this.d_355_3Field;
            }
            set
            {
                this.d_355_3Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string D_212_4
        {
            get
            {
                return this.d_212_4Field;
            }
            set
            {
                this.d_212_4Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public X12_ID_639 D_639_5
        {
            get
            {
                return this.d_639_5Field;
            }
            set
            {
                this.d_639_5Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_639_5Specified
        {
            get
            {
                return this.d_639_5FieldSpecified;
            }
            set
            {
                this.d_639_5FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public X12_ID_235 D_235_6
        {
            get
            {
                return this.d_235_6Field;
            }
            set
            {
                this.d_235_6Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_235_6Specified
        {
            get
            {
                return this.d_235_6FieldSpecified;
            }
            set
            {
                this.d_235_6FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string D_234_7
        {
            get
            {
                return this.d_234_7Field;
            }
            set
            {
                this.d_234_7Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public X12_ID_235 D_235_8
        {
            get
            {
                return this.d_235_8Field;
            }
            set
            {
                this.d_235_8Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_235_8Specified
        {
            get
            {
                return this.d_235_8FieldSpecified;
            }
            set
            {
                this.d_235_8FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string D_234_9
        {
            get
            {
                return this.d_234_9Field;
            }
            set
            {
                this.d_234_9Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public X12_ID_235 D_235_10
        {
            get
            {
                return this.d_235_10Field;
            }
            set
            {
                this.d_235_10Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_235_10Specified
        {
            get
            {
                return this.d_235_10FieldSpecified;
            }
            set
            {
                this.d_235_10FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public string D_234_11
        {
            get
            {
                return this.d_234_11Field;
            }
            set
            {
                this.d_234_11Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public X12_ID_235 D_235_12
        {
            get
            {
                return this.d_235_12Field;
            }
            set
            {
                this.d_235_12Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_235_12Specified
        {
            get
            {
                return this.d_235_12FieldSpecified;
            }
            set
            {
                this.d_235_12FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public string D_234_13
        {
            get
            {
                return this.d_234_13Field;
            }
            set
            {
                this.d_234_13Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public X12_ID_235 D_235_14
        {
            get
            {
                return this.d_235_14Field;
            }
            set
            {
                this.d_235_14Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_235_14Specified
        {
            get
            {
                return this.d_235_14FieldSpecified;
            }
            set
            {
                this.d_235_14FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
        public string D_234_15
        {
            get
            {
                return this.d_234_15Field;
            }
            set
            {
                this.d_234_15Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 15)]
        public X12_ID_235 D_235_16
        {
            get
            {
                return this.d_235_16Field;
            }
            set
            {
                this.d_235_16Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_235_16Specified
        {
            get
            {
                return this.d_235_16FieldSpecified;
            }
            set
            {
                this.d_235_16FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 16)]
        public string D_234_17
        {
            get
            {
                return this.d_234_17Field;
            }
            set
            {
                this.d_234_17Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 17)]
        public X12_ID_235 D_235_18
        {
            get
            {
                return this.d_235_18Field;
            }
            set
            {
                this.d_235_18Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_235_18Specified
        {
            get
            {
                return this.d_235_18FieldSpecified;
            }
            set
            {
                this.d_235_18FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 18)]
        public string D_234_19
        {
            get
            {
                return this.d_234_19Field;
            }
            set
            {
                this.d_234_19Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 19)]
        public X12_ID_235 D_235_20
        {
            get
            {
                return this.d_235_20Field;
            }
            set
            {
                this.d_235_20Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_235_20Specified
        {
            get
            {
                return this.d_235_20FieldSpecified;
            }
            set
            {
                this.d_235_20FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 20)]
        public string D_234_21
        {
            get
            {
                return this.d_234_21Field;
            }
            set
            {
                this.d_234_21Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 21)]
        public X12_ID_235 D_235_22
        {
            get
            {
                return this.d_235_22Field;
            }
            set
            {
                this.d_235_22Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_235_22Specified
        {
            get
            {
                return this.d_235_22FieldSpecified;
            }
            set
            {
                this.d_235_22FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 22)]
        public string D_234_23
        {
            get
            {
                return this.d_234_23Field;
            }
            set
            {
                this.d_234_23Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 23)]
        public X12_ID_235 D_235_24
        {
            get
            {
                return this.d_235_24Field;
            }
            set
            {
                this.d_235_24Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_235_24Specified
        {
            get
            {
                return this.d_235_24FieldSpecified;
            }
            set
            {
                this.d_235_24FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 24)]
        public string D_234_25
        {
            get
            {
                return this.d_234_25Field;
            }
            set
            {
                this.d_234_25Field = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public enum X12_ID_639
    {

        /// <remarks/>
        AP,

        /// <remarks/>
        BR,

        /// <remarks/>
        CA,

        /// <remarks/>
        CP,

        /// <remarks/>
        CT,

        /// <remarks/>
        DI,

        /// <remarks/>
        DR,

        /// <remarks/>
        DS,

        /// <remarks/>
        ES,

        /// <remarks/>
        HF,

        /// <remarks/>
        HP,

        /// <remarks/>
        LC,

        /// <remarks/>
        LD,

        /// <remarks/>
        LE,

        /// <remarks/>
        LM,

        /// <remarks/>
        LR,

        /// <remarks/>
        NC,

        /// <remarks/>
        NE,

        /// <remarks/>
        NQ,

        /// <remarks/>
        PA,

        /// <remarks/>
        PB,

        /// <remarks/>
        PD,

        /// <remarks/>
        PE,

        /// <remarks/>
        PM,

        /// <remarks/>
        PO,

        /// <remarks/>
        PP,

        /// <remarks/>
        PR,

        /// <remarks/>
        PT,

        /// <remarks/>
        PY,

        /// <remarks/>
        QE,

        /// <remarks/>
        QH,

        /// <remarks/>
        QR,

        /// <remarks/>
        QS,

        /// <remarks/>
        QT,

        /// <remarks/>
        RC,

        /// <remarks/>
        RD,

        /// <remarks/>
        RE,

        /// <remarks/>
        RM,

        /// <remarks/>
        RS,

        /// <remarks/>
        RT,

        /// <remarks/>
        SR,

        /// <remarks/>
        TB,

        /// <remarks/>
        TC,

        /// <remarks/>
        TD,

        /// <remarks/>
        TE,

        /// <remarks/>
        TF,

        /// <remarks/>
        TM,

        /// <remarks/>
        TP,

        /// <remarks/>
        UM,

        /// <remarks/>
        WC,

        /// <remarks/>
        WD,

        /// <remarks/>
        WE,

        /// <remarks/>
        WH,

        /// <remarks/>
        WM,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public enum X12_ID_235
    {

        /// <remarks/>
        AB,

        /// <remarks/>
        AC,

        /// <remarks/>
        AI,

        /// <remarks/>
        AN,

        /// <remarks/>
        AR,

        /// <remarks/>
        AT,

        /// <remarks/>
        B1,

        /// <remarks/>
        B2,

        /// <remarks/>
        B3,

        /// <remarks/>
        B4,

        /// <remarks/>
        B5,

        /// <remarks/>
        B6,

        /// <remarks/>
        B7,

        /// <remarks/>
        BA,

        /// <remarks/>
        BC,

        /// <remarks/>
        BE,

        /// <remarks/>
        BL,

        /// <remarks/>
        BM,

        /// <remarks/>
        BN,

        /// <remarks/>
        BO,

        /// <remarks/>
        BP,

        /// <remarks/>
        CA,

        /// <remarks/>
        CB,

        /// <remarks/>
        CC,

        /// <remarks/>
        CD,

        /// <remarks/>
        CE,

        /// <remarks/>
        CG,

        /// <remarks/>
        CI,

        /// <remarks/>
        CL,

        /// <remarks/>
        CM,

        /// <remarks/>
        CN,

        /// <remarks/>
        CP,

        /// <remarks/>
        CQ,

        /// <remarks/>
        CR,

        /// <remarks/>
        CS,

        /// <remarks/>
        CT,

        /// <remarks/>
        CU,

        /// <remarks/>
        DC,

        /// <remarks/>
        DE,

        /// <remarks/>
        DG,

        /// <remarks/>
        DI,

        /// <remarks/>
        DL,

        /// <remarks/>
        DN,

        /// <remarks/>
        DP,

        /// <remarks/>
        DR,

        /// <remarks/>
        EC,

        /// <remarks/>
        ED,

        /// <remarks/>
        EN,

        /// <remarks/>
        EQ,

        /// <remarks/>
        FI,

        /// <remarks/>
        FL,

        /// <remarks/>
        FP,

        /// <remarks/>
        FS,

        /// <remarks/>
        GC,

        /// <remarks/>
        GD,

        /// <remarks/>
        GN,

        /// <remarks/>
        GR,

        /// <remarks/>
        GS,

        /// <remarks/>
        HI,

        /// <remarks/>
        HN,

        /// <remarks/>
        IA,

        /// <remarks/>
        IB,

        /// <remarks/>
        IM,

        /// <remarks/>
        IN,

        /// <remarks/>
        IS,

        /// <remarks/>
        IT,

        /// <remarks/>
        IZ,

        /// <remarks/>
        JS,

        /// <remarks/>
        KP,

        /// <remarks/>
        LT,

        /// <remarks/>
        LU,

        /// <remarks/>
        MA,

        /// <remarks/>
        MF,

        /// <remarks/>
        MG,

        /// <remarks/>
        MN,

        /// <remarks/>
        MS,

        /// <remarks/>
        MT,

        /// <remarks/>
        NC,

        /// <remarks/>
        ND,

        /// <remarks/>
        NH,

        /// <remarks/>
        NR,

        /// <remarks/>
        OA,

        /// <remarks/>
        OB,

        /// <remarks/>
        OC,

        /// <remarks/>
        OD,

        /// <remarks/>
        OE,

        /// <remarks/>
        OH,

        /// <remarks/>
        ON,

        /// <remarks/>
        OP,

        /// <remarks/>
        P1,

        /// <remarks/>
        P2,

        /// <remarks/>
        P3,

        /// <remarks/>
        P4,

        /// <remarks/>
        PA,

        /// <remarks/>
        PC,

        /// <remarks/>
        PD,

        /// <remarks/>
        PE,

        /// <remarks/>
        PG,

        /// <remarks/>
        PI,

        /// <remarks/>
        PJ,

        /// <remarks/>
        PK,

        /// <remarks/>
        PL,

        /// <remarks/>
        PM,

        /// <remarks/>
        PN,

        /// <remarks/>
        PO,

        /// <remarks/>
        PR,

        /// <remarks/>
        PS,

        /// <remarks/>
        PT,

        /// <remarks/>
        PW,

        /// <remarks/>
        RC,

        /// <remarks/>
        RD,

        /// <remarks/>
        RK,

        /// <remarks/>
        RN,

        /// <remarks/>
        RO,

        /// <remarks/>
        RP,

        /// <remarks/>
        RR,

        /// <remarks/>
        RS,

        /// <remarks/>
        RT,

        /// <remarks/>
        RU,

        /// <remarks/>
        RV,

        /// <remarks/>
        RY,

        /// <remarks/>
        SC,

        /// <remarks/>
        SE,

        /// <remarks/>
        SF,

        /// <remarks/>
        SK,

        /// <remarks/>
        SL,

        /// <remarks/>
        SM,

        /// <remarks/>
        SN,

        /// <remarks/>
        SQ,

        /// <remarks/>
        SR,

        /// <remarks/>
        SS,

        /// <remarks/>
        ST,

        /// <remarks/>
        SU,

        /// <remarks/>
        SV,

        /// <remarks/>
        SZ,

        /// <remarks/>
        TC,

        /// <remarks/>
        TM,

        /// <remarks/>
        TP,

        /// <remarks/>
        TY,

        /// <remarks/>
        UA,

        /// <remarks/>
        UB,

        /// <remarks/>
        UC,

        /// <remarks/>
        UD,

        /// <remarks/>
        UE,

        /// <remarks/>
        UI,

        /// <remarks/>
        UM,

        /// <remarks/>
        UN,

        /// <remarks/>
        UP,

        /// <remarks/>
        US,

        /// <remarks/>
        UV,

        /// <remarks/>
        VA,

        /// <remarks/>
        VB,

        /// <remarks/>
        VC,

        /// <remarks/>
        VE,

        /// <remarks/>
        VI,

        /// <remarks/>
        VN,

        /// <remarks/>
        VO,

        /// <remarks/>
        VP,

        /// <remarks/>
        VS,

        /// <remarks/>
        VU,

        /// <remarks/>
        VV,

        /// <remarks/>
        VX,

        /// <remarks/>
        ZZ,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public partial class S_CUR_2
    {

        private X12_ID_98 d_98_1Field;

        private string d_100_2Field;

        private string d_280_3Field;

        private X12_ID_98 d_98_4Field;

        private bool d_98_4FieldSpecified;

        private string d_100_5Field;

        private X12_ID_669 d_669_6Field;

        private bool d_669_6FieldSpecified;

        private X12_ID_374 d_374_7Field;

        private bool d_374_7FieldSpecified;

        private string d_373_8Field;

        private string d_337_9Field;

        private X12_ID_374 d_374_10Field;

        private bool d_374_10FieldSpecified;

        private string d_373_11Field;

        private string d_337_12Field;

        private X12_ID_374 d_374_13Field;

        private bool d_374_13FieldSpecified;

        private string d_373_14Field;

        private string d_337_15Field;

        private X12_ID_374 d_374_16Field;

        private bool d_374_16FieldSpecified;

        private string d_373_17Field;

        private string d_337_18Field;

        private X12_ID_374 d_374_19Field;

        private bool d_374_19FieldSpecified;

        private string d_373_20Field;

        private string d_337_21Field;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public X12_ID_98 D_98_1
        {
            get
            {
                return this.d_98_1Field;
            }
            set
            {
                this.d_98_1Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string D_100_2
        {
            get
            {
                return this.d_100_2Field;
            }
            set
            {
                this.d_100_2Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string D_280_3
        {
            get
            {
                return this.d_280_3Field;
            }
            set
            {
                this.d_280_3Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public X12_ID_98 D_98_4
        {
            get
            {
                return this.d_98_4Field;
            }
            set
            {
                this.d_98_4Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_98_4Specified
        {
            get
            {
                return this.d_98_4FieldSpecified;
            }
            set
            {
                this.d_98_4FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string D_100_5
        {
            get
            {
                return this.d_100_5Field;
            }
            set
            {
                this.d_100_5Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public X12_ID_669 D_669_6
        {
            get
            {
                return this.d_669_6Field;
            }
            set
            {
                this.d_669_6Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_669_6Specified
        {
            get
            {
                return this.d_669_6FieldSpecified;
            }
            set
            {
                this.d_669_6FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public X12_ID_374 D_374_7
        {
            get
            {
                return this.d_374_7Field;
            }
            set
            {
                this.d_374_7Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_374_7Specified
        {
            get
            {
                return this.d_374_7FieldSpecified;
            }
            set
            {
                this.d_374_7FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string D_373_8
        {
            get
            {
                return this.d_373_8Field;
            }
            set
            {
                this.d_373_8Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string D_337_9
        {
            get
            {
                return this.d_337_9Field;
            }
            set
            {
                this.d_337_9Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public X12_ID_374 D_374_10
        {
            get
            {
                return this.d_374_10Field;
            }
            set
            {
                this.d_374_10Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_374_10Specified
        {
            get
            {
                return this.d_374_10FieldSpecified;
            }
            set
            {
                this.d_374_10FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public string D_373_11
        {
            get
            {
                return this.d_373_11Field;
            }
            set
            {
                this.d_373_11Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public string D_337_12
        {
            get
            {
                return this.d_337_12Field;
            }
            set
            {
                this.d_337_12Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public X12_ID_374 D_374_13
        {
            get
            {
                return this.d_374_13Field;
            }
            set
            {
                this.d_374_13Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_374_13Specified
        {
            get
            {
                return this.d_374_13FieldSpecified;
            }
            set
            {
                this.d_374_13FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public string D_373_14
        {
            get
            {
                return this.d_373_14Field;
            }
            set
            {
                this.d_373_14Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
        public string D_337_15
        {
            get
            {
                return this.d_337_15Field;
            }
            set
            {
                this.d_337_15Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 15)]
        public X12_ID_374 D_374_16
        {
            get
            {
                return this.d_374_16Field;
            }
            set
            {
                this.d_374_16Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_374_16Specified
        {
            get
            {
                return this.d_374_16FieldSpecified;
            }
            set
            {
                this.d_374_16FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 16)]
        public string D_373_17
        {
            get
            {
                return this.d_373_17Field;
            }
            set
            {
                this.d_373_17Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 17)]
        public string D_337_18
        {
            get
            {
                return this.d_337_18Field;
            }
            set
            {
                this.d_337_18Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 18)]
        public X12_ID_374 D_374_19
        {
            get
            {
                return this.d_374_19Field;
            }
            set
            {
                this.d_374_19Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_374_19Specified
        {
            get
            {
                return this.d_374_19FieldSpecified;
            }
            set
            {
                this.d_374_19FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 19)]
        public string D_373_20
        {
            get
            {
                return this.d_373_20Field;
            }
            set
            {
                this.d_373_20Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 20)]
        public string D_337_21
        {
            get
            {
                return this.d_337_21Field;
            }
            set
            {
                this.d_337_21Field = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public partial class S_IT3
    {

        private string d_382_1Field;

        private X12_ID_355 d_355_2Field;

        private bool d_355_2FieldSpecified;

        private X12_ID_368 d_368_3Field;

        private bool d_368_3FieldSpecified;

        private string d_383_4Field;

        private X12_ID_371 d_371_5Field;

        private bool d_371_5FieldSpecified;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string D_382_1
        {
            get
            {
                return this.d_382_1Field;
            }
            set
            {
                this.d_382_1Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public X12_ID_355 D_355_2
        {
            get
            {
                return this.d_355_2Field;
            }
            set
            {
                this.d_355_2Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_355_2Specified
        {
            get
            {
                return this.d_355_2FieldSpecified;
            }
            set
            {
                this.d_355_2FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public X12_ID_368 D_368_3
        {
            get
            {
                return this.d_368_3Field;
            }
            set
            {
                this.d_368_3Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_368_3Specified
        {
            get
            {
                return this.d_368_3FieldSpecified;
            }
            set
            {
                this.d_368_3FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string D_383_4
        {
            get
            {
                return this.d_383_4Field;
            }
            set
            {
                this.d_383_4Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public X12_ID_371 D_371_5
        {
            get
            {
                return this.d_371_5Field;
            }
            set
            {
                this.d_371_5Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_371_5Specified
        {
            get
            {
                return this.d_371_5FieldSpecified;
            }
            set
            {
                this.d_371_5FieldSpecified = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public enum X12_ID_368
    {

        /// <remarks/>
        AB,

        /// <remarks/>
        AN,

        /// <remarks/>
        AS,

        /// <remarks/>
        AU,

        /// <remarks/>
        AV,

        /// <remarks/>
        BK,

        /// <remarks/>
        BP,

        /// <remarks/>
        BT,

        /// <remarks/>
        BW,

        /// <remarks/>
        CA,

        /// <remarks/>
        CC,

        /// <remarks/>
        CE,

        /// <remarks/>
        CI,

        /// <remarks/>
        CK,

        /// <remarks/>
        CM,

        /// <remarks/>
        CN,

        /// <remarks/>
        CO,

        /// <remarks/>
        CP,

        /// <remarks/>
        CS,

        /// <remarks/>
        DD,

        /// <remarks/>
        DE,

        /// <remarks/>
        DO,

        /// <remarks/>
        DS,

        /// <remarks/>
        EC,

        /// <remarks/>
        ED,

        /// <remarks/>
        EW,

        /// <remarks/>
        FS,

        /// <remarks/>
        HQ,

        /// <remarks/>
        IC,

        /// <remarks/>
        IN,

        /// <remarks/>
        IP,

        /// <remarks/>
        IS,

        /// <remarks/>
        LM,

        /// <remarks/>
        LS,

        /// <remarks/>
        LW,

        /// <remarks/>
        NF,

        /// <remarks/>
        NN,

        /// <remarks/>
        NS,

        /// <remarks/>
        OB,

        /// <remarks/>
        OF,

        /// <remarks/>
        OP,

        /// <remarks/>
        OR,

        /// <remarks/>
        PA,

        /// <remarks/>
        PD,

        /// <remarks/>
        PH,

        /// <remarks/>
        PI,

        /// <remarks/>
        PK,

        /// <remarks/>
        PN,

        /// <remarks/>
        PO,

        /// <remarks/>
        PP,

        /// <remarks/>
        PR,

        /// <remarks/>
        PS,

        /// <remarks/>
        RD,

        /// <remarks/>
        RW,

        /// <remarks/>
        SB,

        /// <remarks/>
        SD,

        /// <remarks/>
        SL,

        /// <remarks/>
        SP,

        /// <remarks/>
        SQ,

        /// <remarks/>
        SS,

        /// <remarks/>
        SU,

        /// <remarks/>
        UB,

        /// <remarks/>
        UN,

        /// <remarks/>
        UR,

        /// <remarks/>
        WS,

        /// <remarks/>
        ZZ,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public enum X12_ID_371
    {

        /// <remarks/>
        AQ,

        /// <remarks/>
        BB,

        /// <remarks/>
        BD,

        /// <remarks/>
        DC,

        /// <remarks/>
        EV,

        /// <remarks/>
        FE,

        /// <remarks/>
        GU,

        /// <remarks/>
        GW,

        /// <remarks/>
        LD,

        /// <remarks/>
        MC,

        /// <remarks/>
        PC,

        /// <remarks/>
        PQ,

        /// <remarks/>
        PS,

        /// <remarks/>
        QO,

        /// <remarks/>
        QP,

        /// <remarks/>
        QT,

        /// <remarks/>
        SC,

        /// <remarks/>
        UM,

        /// <remarks/>
        UP,

        /// <remarks/>
        WD,

        /// <remarks/>
        WO,

        /// <remarks/>
        ZZ,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public partial class S_TXI
    {

        private X12_ID_963 d_963_1Field;

        private string d_782_2Field;

        private string d_954_3Field;

        private X12_ID_955 d_955_4Field;

        private bool d_955_4FieldSpecified;

        private string d_956_5Field;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public X12_ID_963 D_963_1
        {
            get
            {
                return this.d_963_1Field;
            }
            set
            {
                this.d_963_1Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string D_782_2
        {
            get
            {
                return this.d_782_2Field;
            }
            set
            {
                this.d_782_2Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string D_954_3
        {
            get
            {
                return this.d_954_3Field;
            }
            set
            {
                this.d_954_3Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public X12_ID_955 D_955_4
        {
            get
            {
                return this.d_955_4Field;
            }
            set
            {
                this.d_955_4Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_955_4Specified
        {
            get
            {
                return this.d_955_4FieldSpecified;
            }
            set
            {
                this.d_955_4FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string D_956_5
        {
            get
            {
                return this.d_956_5Field;
            }
            set
            {
                this.d_956_5Field = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public enum X12_ID_963
    {

        /// <remarks/>
        CP,

        /// <remarks/>
        CS,

        /// <remarks/>
        CT,

        /// <remarks/>
        FT,

        /// <remarks/>
        LS,

        /// <remarks/>
        LT,

        /// <remarks/>
        MT,

        /// <remarks/>
        ST,

        /// <remarks/>
        VA,

        /// <remarks/>
        ZZ,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public enum X12_ID_955
    {

        /// <remarks/>
        CD,

        /// <remarks/>
        VD,

        /// <remarks/>
        VE,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public partial class S_CTP
    {

        private X12_ID_687 d_687_1Field;

        private bool d_687_1FieldSpecified;

        private X12_ID_236 d_236_2Field;

        private bool d_236_2FieldSpecified;

        private string d_212_3Field;

        private string d_380_4Field;

        private X12_ID_355 d_355_5Field;

        private bool d_355_5FieldSpecified;

        private X12_ID_648 d_648_6Field;

        private bool d_648_6FieldSpecified;

        private string d_649_7Field;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public X12_ID_687 D_687_1
        {
            get
            {
                return this.d_687_1Field;
            }
            set
            {
                this.d_687_1Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_687_1Specified
        {
            get
            {
                return this.d_687_1FieldSpecified;
            }
            set
            {
                this.d_687_1FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public X12_ID_236 D_236_2
        {
            get
            {
                return this.d_236_2Field;
            }
            set
            {
                this.d_236_2Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_236_2Specified
        {
            get
            {
                return this.d_236_2FieldSpecified;
            }
            set
            {
                this.d_236_2FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string D_212_3
        {
            get
            {
                return this.d_212_3Field;
            }
            set
            {
                this.d_212_3Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string D_380_4
        {
            get
            {
                return this.d_380_4Field;
            }
            set
            {
                this.d_380_4Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public X12_ID_355 D_355_5
        {
            get
            {
                return this.d_355_5Field;
            }
            set
            {
                this.d_355_5Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_355_5Specified
        {
            get
            {
                return this.d_355_5FieldSpecified;
            }
            set
            {
                this.d_355_5FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public X12_ID_648 D_648_6
        {
            get
            {
                return this.d_648_6Field;
            }
            set
            {
                this.d_648_6Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_648_6Specified
        {
            get
            {
                return this.d_648_6FieldSpecified;
            }
            set
            {
                this.d_648_6FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string D_649_7
        {
            get
            {
                return this.d_649_7Field;
            }
            set
            {
                this.d_649_7Field = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public enum X12_ID_687
    {

        /// <remarks/>
        AG,

        /// <remarks/>
        BG,

        /// <remarks/>
        BR,

        /// <remarks/>
        CN,

        /// <remarks/>
        CO,

        /// <remarks/>
        DE,

        /// <remarks/>
        DI,

        /// <remarks/>
        EX,

        /// <remarks/>
        GV,

        /// <remarks/>
        ID,

        /// <remarks/>
        IN,

        /// <remarks/>
        JB,

        /// <remarks/>
        MF,

        /// <remarks/>
        OE,

        /// <remarks/>
        PF,

        /// <remarks/>
        RS,

        /// <remarks/>
        ST,

        /// <remarks/>
        TR,

        /// <remarks/>
        WH,

        /// <remarks/>
        WS,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public enum X12_ID_236
    {

        /// <remarks/>
        ALT,

        /// <remarks/>
        AWP,

        /// <remarks/>
        CAT,

        /// <remarks/>
        CDV,

        /// <remarks/>
        CHG,

        /// <remarks/>
        CON,

        /// <remarks/>
        CUP,

        /// <remarks/>
        CUS,

        /// <remarks/>
        DAP,

        /// <remarks/>
        DIS,

        /// <remarks/>
        DPR,

        /// <remarks/>
        DSC,

        /// <remarks/>
        EUP,

        /// <remarks/>
        FET,

        /// <remarks/>
        FGP,

        /// <remarks/>
        GOV,

        /// <remarks/>
        ICL,

        /// <remarks/>
        IND,

        /// <remarks/>
        INS,

        /// <remarks/>
        INV,

        /// <remarks/>
        MAX,

        /// <remarks/>
        MIN,

        /// <remarks/>
        MNR,

        /// <remarks/>
        MSR,

        /// <remarks/>
        MXR,

        /// <remarks/>
        NET,

        /// <remarks/>
        PAQ,

        /// <remarks/>
        PBQ,

        /// <remarks/>
        PIE,

        /// <remarks/>
        PPD,

        /// <remarks/>
        PRF,

        /// <remarks/>
        PRO,

        /// <remarks/>
        PRP,

        /// <remarks/>
        QTE,

        /// <remarks/>
        RES,

        /// <remarks/>
        SHD,

        /// <remarks/>
        SPC,

        /// <remarks/>
        SUM,

        /// <remarks/>
        TOT,

        /// <remarks/>
        TRF,

        /// <remarks/>
        UCP,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public enum X12_ID_648
    {

        /// <remarks/>
        CSD,

        /// <remarks/>
        CSR,

        /// <remarks/>
        DIS,

        /// <remarks/>
        ILP,

        /// <remarks/>
        PSP,

        /// <remarks/>
        SEL,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public partial class S_PID_2
    {

        private X12_ID_349 d_349_1Field;

        private X12_ID_750 d_750_2Field;

        private bool d_750_2FieldSpecified;

        private X12_ID_348 d_348_3Field;

        private bool d_348_3FieldSpecified;

        private string d_751_4Field;

        private string d_352_5Field;

        private X12_ID_752 d_752_6Field;

        private bool d_752_6FieldSpecified;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public X12_ID_349 D_349_1
        {
            get
            {
                return this.d_349_1Field;
            }
            set
            {
                this.d_349_1Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public X12_ID_750 D_750_2
        {
            get
            {
                return this.d_750_2Field;
            }
            set
            {
                this.d_750_2Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_750_2Specified
        {
            get
            {
                return this.d_750_2FieldSpecified;
            }
            set
            {
                this.d_750_2FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public X12_ID_348 D_348_3
        {
            get
            {
                return this.d_348_3Field;
            }
            set
            {
                this.d_348_3Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_348_3Specified
        {
            get
            {
                return this.d_348_3FieldSpecified;
            }
            set
            {
                this.d_348_3FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string D_751_4
        {
            get
            {
                return this.d_751_4Field;
            }
            set
            {
                this.d_751_4Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string D_352_5
        {
            get
            {
                return this.d_352_5Field;
            }
            set
            {
                this.d_352_5Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public X12_ID_752 D_752_6
        {
            get
            {
                return this.d_752_6Field;
            }
            set
            {
                this.d_752_6Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_752_6Specified
        {
            get
            {
                return this.d_752_6FieldSpecified;
            }
            set
            {
                this.d_752_6FieldSpecified = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public partial class S_MEA_2
    {

        private X12_ID_737 d_737_1Field;

        private bool d_737_1FieldSpecified;

        private X12_ID_738 d_738_2Field;

        private bool d_738_2FieldSpecified;

        private string d_739_3Field;

        private X12_ID_355 d_355_4Field;

        private bool d_355_4FieldSpecified;

        private string d_740_5Field;

        private string d_741_6Field;

        private X12_ID_935 d_935_7Field;

        private bool d_935_7FieldSpecified;

        private X12_ID_936 d_936_8Field;

        private bool d_936_8FieldSpecified;

        private X12_ID_752 d_752_9Field;

        private bool d_752_9FieldSpecified;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public X12_ID_737 D_737_1
        {
            get
            {
                return this.d_737_1Field;
            }
            set
            {
                this.d_737_1Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_737_1Specified
        {
            get
            {
                return this.d_737_1FieldSpecified;
            }
            set
            {
                this.d_737_1FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public X12_ID_738 D_738_2
        {
            get
            {
                return this.d_738_2Field;
            }
            set
            {
                this.d_738_2Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_738_2Specified
        {
            get
            {
                return this.d_738_2FieldSpecified;
            }
            set
            {
                this.d_738_2FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string D_739_3
        {
            get
            {
                return this.d_739_3Field;
            }
            set
            {
                this.d_739_3Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public X12_ID_355 D_355_4
        {
            get
            {
                return this.d_355_4Field;
            }
            set
            {
                this.d_355_4Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_355_4Specified
        {
            get
            {
                return this.d_355_4FieldSpecified;
            }
            set
            {
                this.d_355_4FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string D_740_5
        {
            get
            {
                return this.d_740_5Field;
            }
            set
            {
                this.d_740_5Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string D_741_6
        {
            get
            {
                return this.d_741_6Field;
            }
            set
            {
                this.d_741_6Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public X12_ID_935 D_935_7
        {
            get
            {
                return this.d_935_7Field;
            }
            set
            {
                this.d_935_7Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_935_7Specified
        {
            get
            {
                return this.d_935_7FieldSpecified;
            }
            set
            {
                this.d_935_7FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public X12_ID_936 D_936_8
        {
            get
            {
                return this.d_936_8Field;
            }
            set
            {
                this.d_936_8Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_936_8Specified
        {
            get
            {
                return this.d_936_8FieldSpecified;
            }
            set
            {
                this.d_936_8FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public X12_ID_752 D_752_9
        {
            get
            {
                return this.d_752_9Field;
            }
            set
            {
                this.d_752_9Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_752_9Specified
        {
            get
            {
                return this.d_752_9FieldSpecified;
            }
            set
            {
                this.d_752_9FieldSpecified = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public partial class S_PWK_2
    {

        private X12_ID_755 d_755_1Field;

        private X12_ID_756 d_756_2Field;

        private string d_757_3Field;

        private X12_ID_98 d_98_4Field;

        private bool d_98_4FieldSpecified;

        private X12_ID_66 d_66_5Field;

        private bool d_66_5FieldSpecified;

        private string d_67_6Field;

        private string d_352_7Field;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public X12_ID_755 D_755_1
        {
            get
            {
                return this.d_755_1Field;
            }
            set
            {
                this.d_755_1Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public X12_ID_756 D_756_2
        {
            get
            {
                return this.d_756_2Field;
            }
            set
            {
                this.d_756_2Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string D_757_3
        {
            get
            {
                return this.d_757_3Field;
            }
            set
            {
                this.d_757_3Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public X12_ID_98 D_98_4
        {
            get
            {
                return this.d_98_4Field;
            }
            set
            {
                this.d_98_4Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_98_4Specified
        {
            get
            {
                return this.d_98_4FieldSpecified;
            }
            set
            {
                this.d_98_4FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public X12_ID_66 D_66_5
        {
            get
            {
                return this.d_66_5Field;
            }
            set
            {
                this.d_66_5Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_66_5Specified
        {
            get
            {
                return this.d_66_5FieldSpecified;
            }
            set
            {
                this.d_66_5FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string D_67_6
        {
            get
            {
                return this.d_67_6Field;
            }
            set
            {
                this.d_67_6Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string D_352_7
        {
            get
            {
                return this.d_352_7Field;
            }
            set
            {
                this.d_352_7Field = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public partial class S_PKG_2
    {

        private X12_ID_349 d_349_1Field;

        private X12_ID_753 d_753_2Field;

        private bool d_753_2FieldSpecified;

        private X12_ID_348 d_348_3Field;

        private bool d_348_3FieldSpecified;

        private string d_754_4Field;

        private string d_352_5Field;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public X12_ID_349 D_349_1
        {
            get
            {
                return this.d_349_1Field;
            }
            set
            {
                this.d_349_1Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public X12_ID_753 D_753_2
        {
            get
            {
                return this.d_753_2Field;
            }
            set
            {
                this.d_753_2Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_753_2Specified
        {
            get
            {
                return this.d_753_2FieldSpecified;
            }
            set
            {
                this.d_753_2FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public X12_ID_348 D_348_3
        {
            get
            {
                return this.d_348_3Field;
            }
            set
            {
                this.d_348_3Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_348_3Specified
        {
            get
            {
                return this.d_348_3FieldSpecified;
            }
            set
            {
                this.d_348_3FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string D_754_4
        {
            get
            {
                return this.d_754_4Field;
            }
            set
            {
                this.d_754_4Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string D_352_5
        {
            get
            {
                return this.d_352_5Field;
            }
            set
            {
                this.d_352_5Field = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public partial class S_PO4
    {

        private string d_356_1Field;

        private string d_357_2Field;

        private X12_ID_355 d_355_3Field;

        private bool d_355_3FieldSpecified;

        private string d_103_4Field;

        private X12_ID_187 d_187_5Field;

        private bool d_187_5FieldSpecified;

        private string d_384_6Field;

        private X12_ID_355 d_355_7Field;

        private bool d_355_7FieldSpecified;

        private string d_385_8Field;

        private X12_ID_355 d_355_9Field;

        private bool d_355_9FieldSpecified;

        private string d_82_10Field;

        private string d_189_11Field;

        private string d_65_12Field;

        private X12_ID_355 d_355_13Field;

        private bool d_355_13FieldSpecified;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string D_356_1
        {
            get
            {
                return this.d_356_1Field;
            }
            set
            {
                this.d_356_1Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string D_357_2
        {
            get
            {
                return this.d_357_2Field;
            }
            set
            {
                this.d_357_2Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public X12_ID_355 D_355_3
        {
            get
            {
                return this.d_355_3Field;
            }
            set
            {
                this.d_355_3Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_355_3Specified
        {
            get
            {
                return this.d_355_3FieldSpecified;
            }
            set
            {
                this.d_355_3FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string D_103_4
        {
            get
            {
                return this.d_103_4Field;
            }
            set
            {
                this.d_103_4Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public X12_ID_187 D_187_5
        {
            get
            {
                return this.d_187_5Field;
            }
            set
            {
                this.d_187_5Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_187_5Specified
        {
            get
            {
                return this.d_187_5FieldSpecified;
            }
            set
            {
                this.d_187_5FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string D_384_6
        {
            get
            {
                return this.d_384_6Field;
            }
            set
            {
                this.d_384_6Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public X12_ID_355 D_355_7
        {
            get
            {
                return this.d_355_7Field;
            }
            set
            {
                this.d_355_7Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_355_7Specified
        {
            get
            {
                return this.d_355_7FieldSpecified;
            }
            set
            {
                this.d_355_7FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string D_385_8
        {
            get
            {
                return this.d_385_8Field;
            }
            set
            {
                this.d_385_8Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public X12_ID_355 D_355_9
        {
            get
            {
                return this.d_355_9Field;
            }
            set
            {
                this.d_355_9Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_355_9Specified
        {
            get
            {
                return this.d_355_9FieldSpecified;
            }
            set
            {
                this.d_355_9FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string D_82_10
        {
            get
            {
                return this.d_82_10Field;
            }
            set
            {
                this.d_82_10Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public string D_189_11
        {
            get
            {
                return this.d_189_11Field;
            }
            set
            {
                this.d_189_11Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public string D_65_12
        {
            get
            {
                return this.d_65_12Field;
            }
            set
            {
                this.d_65_12Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public X12_ID_355 D_355_13
        {
            get
            {
                return this.d_355_13Field;
            }
            set
            {
                this.d_355_13Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_355_13Specified
        {
            get
            {
                return this.d_355_13FieldSpecified;
            }
            set
            {
                this.d_355_13FieldSpecified = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public enum X12_ID_187
    {

        /// <remarks/>
        A,

        /// <remarks/>
        A1,

        /// <remarks/>
        A2,

        /// <remarks/>
        A3,

        /// <remarks/>
        B,

        /// <remarks/>
        C,

        /// <remarks/>
        D,

        /// <remarks/>
        DR,

        /// <remarks/>
        E,

        /// <remarks/>
        F,

        /// <remarks/>
        G,

        /// <remarks/>
        H,

        /// <remarks/>
        I,

        /// <remarks/>
        J,

        /// <remarks/>
        K,

        /// <remarks/>
        L,

        /// <remarks/>
        M,

        /// <remarks/>
        N,

        /// <remarks/>
        O,

        /// <remarks/>
        P,

        /// <remarks/>
        Q,

        /// <remarks/>
        R,

        /// <remarks/>
        S,

        /// <remarks/>
        T,

        /// <remarks/>
        U,

        /// <remarks/>
        V,

        /// <remarks/>
        W,

        /// <remarks/>
        X,

        /// <remarks/>
        Y,

        /// <remarks/>
        Z,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public partial class S_ITD_2
    {

        private X12_ID_336 d_336_1Field;

        private bool d_336_1FieldSpecified;

        private X12_ID_333 d_333_2Field;

        private string d_338_3Field;

        private string d_370_4Field;

        private string d_351_5Field;

        private string d_446_6Field;

        private string d_386_7Field;

        private string d_362_8Field;

        private string d_388_9Field;

        private string d_389_10Field;

        private string d_342_11Field;

        private string d_352_12Field;

        private string d_765_13Field;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public X12_ID_336 D_336_1
        {
            get
            {
                return this.d_336_1Field;
            }
            set
            {
                this.d_336_1Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_336_1Specified
        {
            get
            {
                return this.d_336_1FieldSpecified;
            }
            set
            {
                this.d_336_1FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public X12_ID_333 D_333_2
        {
            get
            {
                return this.d_333_2Field;
            }
            set
            {
                this.d_333_2Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string D_338_3
        {
            get
            {
                return this.d_338_3Field;
            }
            set
            {
                this.d_338_3Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string D_370_4
        {
            get
            {
                return this.d_370_4Field;
            }
            set
            {
                this.d_370_4Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string D_351_5
        {
            get
            {
                return this.d_351_5Field;
            }
            set
            {
                this.d_351_5Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string D_446_6
        {
            get
            {
                return this.d_446_6Field;
            }
            set
            {
                this.d_446_6Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string D_386_7
        {
            get
            {
                return this.d_386_7Field;
            }
            set
            {
                this.d_386_7Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string D_362_8
        {
            get
            {
                return this.d_362_8Field;
            }
            set
            {
                this.d_362_8Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string D_388_9
        {
            get
            {
                return this.d_388_9Field;
            }
            set
            {
                this.d_388_9Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string D_389_10
        {
            get
            {
                return this.d_389_10Field;
            }
            set
            {
                this.d_389_10Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public string D_342_11
        {
            get
            {
                return this.d_342_11Field;
            }
            set
            {
                this.d_342_11Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public string D_352_12
        {
            get
            {
                return this.d_352_12Field;
            }
            set
            {
                this.d_352_12Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public string D_765_13
        {
            get
            {
                return this.d_765_13Field;
            }
            set
            {
                this.d_765_13Field = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public partial class S_REF_3
    {

        private X12_ID_128 d_128_1Field;

        private string d_127_2Field;

        private string d_352_3Field;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public X12_ID_128 D_128_1
        {
            get
            {
                return this.d_128_1Field;
            }
            set
            {
                this.d_128_1Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string D_127_2
        {
            get
            {
                return this.d_127_2Field;
            }
            set
            {
                this.d_127_2Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string D_352_3
        {
            get
            {
                return this.d_352_3Field;
            }
            set
            {
                this.d_352_3Field = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public partial class S_PER_3
    {

        private X12_ID_366 d_366_1Field;

        private string d_93_2Field;

        private X12_ID_365 d_365_3Field;

        private bool d_365_3FieldSpecified;

        private string d_364_4Field;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public X12_ID_366 D_366_1
        {
            get
            {
                return this.d_366_1Field;
            }
            set
            {
                this.d_366_1Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string D_93_2
        {
            get
            {
                return this.d_93_2Field;
            }
            set
            {
                this.d_93_2Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public X12_ID_365 D_365_3
        {
            get
            {
                return this.d_365_3Field;
            }
            set
            {
                this.d_365_3Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_365_3Specified
        {
            get
            {
                return this.d_365_3FieldSpecified;
            }
            set
            {
                this.d_365_3FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string D_364_4
        {
            get
            {
                return this.d_364_4Field;
            }
            set
            {
                this.d_364_4Field = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public partial class S_SDQ
    {

        private X12_ID_355 d_355_1Field;

        private X12_ID_66 d_66_2Field;

        private bool d_66_2FieldSpecified;

        private string d_67_3Field;

        private string d_380_4Field;

        private string d_67_5Field;

        private string d_380_6Field;

        private string d_67_7Field;

        private string d_380_8Field;

        private string d_67_9Field;

        private string d_380_10Field;

        private string d_67_11Field;

        private string d_380_12Field;

        private string d_67_13Field;

        private string d_380_14Field;

        private string d_67_15Field;

        private string d_380_16Field;

        private string d_67_17Field;

        private string d_380_18Field;

        private string d_67_19Field;

        private string d_380_20Field;

        private string d_67_21Field;

        private string d_380_22Field;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public X12_ID_355 D_355_1
        {
            get
            {
                return this.d_355_1Field;
            }
            set
            {
                this.d_355_1Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public X12_ID_66 D_66_2
        {
            get
            {
                return this.d_66_2Field;
            }
            set
            {
                this.d_66_2Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_66_2Specified
        {
            get
            {
                return this.d_66_2FieldSpecified;
            }
            set
            {
                this.d_66_2FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string D_67_3
        {
            get
            {
                return this.d_67_3Field;
            }
            set
            {
                this.d_67_3Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string D_380_4
        {
            get
            {
                return this.d_380_4Field;
            }
            set
            {
                this.d_380_4Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string D_67_5
        {
            get
            {
                return this.d_67_5Field;
            }
            set
            {
                this.d_67_5Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string D_380_6
        {
            get
            {
                return this.d_380_6Field;
            }
            set
            {
                this.d_380_6Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string D_67_7
        {
            get
            {
                return this.d_67_7Field;
            }
            set
            {
                this.d_67_7Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string D_380_8
        {
            get
            {
                return this.d_380_8Field;
            }
            set
            {
                this.d_380_8Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string D_67_9
        {
            get
            {
                return this.d_67_9Field;
            }
            set
            {
                this.d_67_9Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string D_380_10
        {
            get
            {
                return this.d_380_10Field;
            }
            set
            {
                this.d_380_10Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public string D_67_11
        {
            get
            {
                return this.d_67_11Field;
            }
            set
            {
                this.d_67_11Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public string D_380_12
        {
            get
            {
                return this.d_380_12Field;
            }
            set
            {
                this.d_380_12Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public string D_67_13
        {
            get
            {
                return this.d_67_13Field;
            }
            set
            {
                this.d_67_13Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public string D_380_14
        {
            get
            {
                return this.d_380_14Field;
            }
            set
            {
                this.d_380_14Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
        public string D_67_15
        {
            get
            {
                return this.d_67_15Field;
            }
            set
            {
                this.d_67_15Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 15)]
        public string D_380_16
        {
            get
            {
                return this.d_380_16Field;
            }
            set
            {
                this.d_380_16Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 16)]
        public string D_67_17
        {
            get
            {
                return this.d_67_17Field;
            }
            set
            {
                this.d_67_17Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 17)]
        public string D_380_18
        {
            get
            {
                return this.d_380_18Field;
            }
            set
            {
                this.d_380_18Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 18)]
        public string D_67_19
        {
            get
            {
                return this.d_67_19Field;
            }
            set
            {
                this.d_67_19Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 19)]
        public string D_380_20
        {
            get
            {
                return this.d_380_20Field;
            }
            set
            {
                this.d_380_20Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 20)]
        public string D_67_21
        {
            get
            {
                return this.d_67_21Field;
            }
            set
            {
                this.d_67_21Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 21)]
        public string D_380_22
        {
            get
            {
                return this.d_380_22Field;
            }
            set
            {
                this.d_380_22Field = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public partial class S_DTM_2
    {

        private X12_ID_374 d_374_1Field;

        private string d_373_2Field;

        private string d_337_3Field;

        private X12_ID_623 d_623_4Field;

        private bool d_623_4FieldSpecified;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public X12_ID_374 D_374_1
        {
            get
            {
                return this.d_374_1Field;
            }
            set
            {
                this.d_374_1Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string D_373_2
        {
            get
            {
                return this.d_373_2Field;
            }
            set
            {
                this.d_373_2Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string D_337_3
        {
            get
            {
                return this.d_337_3Field;
            }
            set
            {
                this.d_337_3Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public X12_ID_623 D_623_4
        {
            get
            {
                return this.d_623_4Field;
            }
            set
            {
                this.d_623_4Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_623_4Specified
        {
            get
            {
                return this.d_623_4FieldSpecified;
            }
            set
            {
                this.d_623_4FieldSpecified = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public partial class S_CAD
    {

        private X12_ID_91 d_91_1Field;

        private bool d_91_1FieldSpecified;

        private string d_206_2Field;

        private string d_207_3Field;

        private string d_140_4Field;

        private string d_387_5Field;

        private X12_ID_368 d_368_6Field;

        private bool d_368_6FieldSpecified;

        private X12_ID_128 d_128_7Field;

        private bool d_128_7FieldSpecified;

        private string d_127_8Field;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public X12_ID_91 D_91_1
        {
            get
            {
                return this.d_91_1Field;
            }
            set
            {
                this.d_91_1Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_91_1Specified
        {
            get
            {
                return this.d_91_1FieldSpecified;
            }
            set
            {
                this.d_91_1FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string D_206_2
        {
            get
            {
                return this.d_206_2Field;
            }
            set
            {
                this.d_206_2Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string D_207_3
        {
            get
            {
                return this.d_207_3Field;
            }
            set
            {
                this.d_207_3Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string D_140_4
        {
            get
            {
                return this.d_140_4Field;
            }
            set
            {
                this.d_140_4Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string D_387_5
        {
            get
            {
                return this.d_387_5Field;
            }
            set
            {
                this.d_387_5Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public X12_ID_368 D_368_6
        {
            get
            {
                return this.d_368_6Field;
            }
            set
            {
                this.d_368_6Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_368_6Specified
        {
            get
            {
                return this.d_368_6FieldSpecified;
            }
            set
            {
                this.d_368_6FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public X12_ID_128 D_128_7
        {
            get
            {
                return this.d_128_7Field;
            }
            set
            {
                this.d_128_7Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_128_7Specified
        {
            get
            {
                return this.d_128_7FieldSpecified;
            }
            set
            {
                this.d_128_7FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string D_127_8
        {
            get
            {
                return this.d_127_8Field;
            }
            set
            {
                this.d_127_8Field = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public enum X12_ID_91
    {

        /// <remarks/>
        A,

        /// <remarks/>
        AC,

        /// <remarks/>
        AE,

        /// <remarks/>
        B,

        /// <remarks/>
        BP,

        /// <remarks/>
        BU,

        /// <remarks/>
        C,

        /// <remarks/>
        CE,

        /// <remarks/>
        D,

        /// <remarks/>
        E,

        /// <remarks/>
        G,

        /// <remarks/>
        H,

        /// <remarks/>
        I,

        /// <remarks/>
        J,

        /// <remarks/>
        K,

        /// <remarks/>
        L,

        /// <remarks/>
        LT,

        /// <remarks/>
        M,

        /// <remarks/>
        N,

        /// <remarks/>
        O,

        /// <remarks/>
        P,

        /// <remarks/>
        PC,

        /// <remarks/>
        PL,

        /// <remarks/>
        PT,

        /// <remarks/>
        Q,

        /// <remarks/>
        R,

        /// <remarks/>
        S,

        /// <remarks/>
        SE,

        /// <remarks/>
        SR,

        /// <remarks/>
        SS,

        /// <remarks/>
        T,

        /// <remarks/>
        TC,

        /// <remarks/>
        U,

        /// <remarks/>
        VE,

        /// <remarks/>
        W,

        /// <remarks/>
        X,

        /// <remarks/>
        ZZ,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public partial class S_L7_2
    {

        private string d_213_1Field;

        private string d_168_2Field;

        private string d_171_3Field;

        private string d_172_4Field;

        private string d_169_5Field;

        private string d_170_6Field;

        private string d_59_7Field;

        private string d_173_8Field;

        private string d_46_9Field;

        private string d_37_10Field;

        private string d_119_11Field;

        private string d_227_12Field;

        private string d_294_13Field;

        private X12_ID_295 d_295_14Field;

        private bool d_295_14FieldSpecified;

        private string d_19_15Field;

        private string d_156_16Field;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string D_213_1
        {
            get
            {
                return this.d_213_1Field;
            }
            set
            {
                this.d_213_1Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string D_168_2
        {
            get
            {
                return this.d_168_2Field;
            }
            set
            {
                this.d_168_2Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string D_171_3
        {
            get
            {
                return this.d_171_3Field;
            }
            set
            {
                this.d_171_3Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string D_172_4
        {
            get
            {
                return this.d_172_4Field;
            }
            set
            {
                this.d_172_4Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string D_169_5
        {
            get
            {
                return this.d_169_5Field;
            }
            set
            {
                this.d_169_5Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string D_170_6
        {
            get
            {
                return this.d_170_6Field;
            }
            set
            {
                this.d_170_6Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string D_59_7
        {
            get
            {
                return this.d_59_7Field;
            }
            set
            {
                this.d_59_7Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string D_173_8
        {
            get
            {
                return this.d_173_8Field;
            }
            set
            {
                this.d_173_8Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string D_46_9
        {
            get
            {
                return this.d_46_9Field;
            }
            set
            {
                this.d_46_9Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string D_37_10
        {
            get
            {
                return this.d_37_10Field;
            }
            set
            {
                this.d_37_10Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public string D_119_11
        {
            get
            {
                return this.d_119_11Field;
            }
            set
            {
                this.d_119_11Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public string D_227_12
        {
            get
            {
                return this.d_227_12Field;
            }
            set
            {
                this.d_227_12Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public string D_294_13
        {
            get
            {
                return this.d_294_13Field;
            }
            set
            {
                this.d_294_13Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public X12_ID_295 D_295_14
        {
            get
            {
                return this.d_295_14Field;
            }
            set
            {
                this.d_295_14Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_295_14Specified
        {
            get
            {
                return this.d_295_14FieldSpecified;
            }
            set
            {
                this.d_295_14FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
        public string D_19_15
        {
            get
            {
                return this.d_19_15Field;
            }
            set
            {
                this.d_19_15Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 15)]
        public string D_156_16
        {
            get
            {
                return this.d_156_16Field;
            }
            set
            {
                this.d_156_16Field = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public partial class G_ITA
    {

        private S_ITA s_ITAField;

        private List<S_TXI_2> s_TXI_2Field;

        public G_ITA()
        {
            this.s_TXI_2Field = new List<S_TXI_2>();
            this.s_ITAField = new S_ITA();
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public S_ITA S_ITA
        {
            get
            {
                return this.s_ITAField;
            }
            set
            {
                this.s_ITAField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("S_TXI_2", Order = 1)]
        public List<S_TXI_2> S_TXI_2
        {
            get
            {
                return this.s_TXI_2Field;
            }
            set
            {
                this.s_TXI_2Field = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public partial class S_ITA
    {

        private X12_ID_248 d_248_1Field;

        private X12_ID_559 d_559_2Field;

        private bool d_559_2FieldSpecified;

        private X12_ID_560 d_560_3Field;

        private bool d_560_3FieldSpecified;

        private X12_ID_331 d_331_4Field;

        private string d_341_5Field;

        private string d_359_6Field;

        private string d_360_7Field;

        private X12_ID_378 d_378_8Field;

        private bool d_378_8FieldSpecified;

        private string d_332_9Field;

        private string d_339_10Field;

        private X12_ID_355 d_355_11Field;

        private bool d_355_11FieldSpecified;

        private string d_380_12Field;

        private string d_352_13Field;

        private X12_ID_150 d_150_14Field;

        private bool d_150_14FieldSpecified;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public X12_ID_248 D_248_1
        {
            get
            {
                return this.d_248_1Field;
            }
            set
            {
                this.d_248_1Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public X12_ID_559 D_559_2
        {
            get
            {
                return this.d_559_2Field;
            }
            set
            {
                this.d_559_2Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_559_2Specified
        {
            get
            {
                return this.d_559_2FieldSpecified;
            }
            set
            {
                this.d_559_2FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public X12_ID_560 D_560_3
        {
            get
            {
                return this.d_560_3Field;
            }
            set
            {
                this.d_560_3Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_560_3Specified
        {
            get
            {
                return this.d_560_3FieldSpecified;
            }
            set
            {
                this.d_560_3FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public X12_ID_331 D_331_4
        {
            get
            {
                return this.d_331_4Field;
            }
            set
            {
                this.d_331_4Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string D_341_5
        {
            get
            {
                return this.d_341_5Field;
            }
            set
            {
                this.d_341_5Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string D_359_6
        {
            get
            {
                return this.d_359_6Field;
            }
            set
            {
                this.d_359_6Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string D_360_7
        {
            get
            {
                return this.d_360_7Field;
            }
            set
            {
                this.d_360_7Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public X12_ID_378 D_378_8
        {
            get
            {
                return this.d_378_8Field;
            }
            set
            {
                this.d_378_8Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_378_8Specified
        {
            get
            {
                return this.d_378_8FieldSpecified;
            }
            set
            {
                this.d_378_8FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string D_332_9
        {
            get
            {
                return this.d_332_9Field;
            }
            set
            {
                this.d_332_9Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string D_339_10
        {
            get
            {
                return this.d_339_10Field;
            }
            set
            {
                this.d_339_10Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public X12_ID_355 D_355_11
        {
            get
            {
                return this.d_355_11Field;
            }
            set
            {
                this.d_355_11Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_355_11Specified
        {
            get
            {
                return this.d_355_11FieldSpecified;
            }
            set
            {
                this.d_355_11FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public string D_380_12
        {
            get
            {
                return this.d_380_12Field;
            }
            set
            {
                this.d_380_12Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public string D_352_13
        {
            get
            {
                return this.d_352_13Field;
            }
            set
            {
                this.d_352_13Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public X12_ID_150 D_150_14
        {
            get
            {
                return this.d_150_14Field;
            }
            set
            {
                this.d_150_14Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_150_14Specified
        {
            get
            {
                return this.d_150_14FieldSpecified;
            }
            set
            {
                this.d_150_14FieldSpecified = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public enum X12_ID_248
    {

        /// <remarks/>
        A,

        /// <remarks/>
        C,

        /// <remarks/>
        N,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public enum X12_ID_559
    {

        /// <remarks/>
        AA,

        /// <remarks/>
        AI,

        /// <remarks/>
        AX,

        /// <remarks/>
        BI,

        /// <remarks/>
        CM,

        /// <remarks/>
        EU,

        /// <remarks/>
        GU,

        /// <remarks/>
        NE,

        /// <remarks/>
        NR,

        /// <remarks/>
        OP,

        /// <remarks/>
        PI,

        /// <remarks/>
        ST,

        /// <remarks/>
        TD,

        /// <remarks/>
        TI,

        /// <remarks/>
        VI,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public enum X12_ID_560
    {

        /// <remarks/>
        A0010,

        /// <remarks/>
        A0020,

        /// <remarks/>
        A0030,

        /// <remarks/>
        AC,

        /// <remarks/>
        AF,

        /// <remarks/>
        B0020,

        /// <remarks/>
        B0040,

        /// <remarks/>
        BH,

        /// <remarks/>
        BI,

        /// <remarks/>
        C0012,

        /// <remarks/>
        C0032,

        /// <remarks/>
        C0036,

        /// <remarks/>
        C0038,

        /// <remarks/>
        C1,

        /// <remarks/>
        CA,

        /// <remarks/>
        CH,

        /// <remarks/>
        CI,

        /// <remarks/>
        CN,

        /// <remarks/>
        CS,

        /// <remarks/>
        CT,

        /// <remarks/>
        CU,

        /// <remarks/>
        CZ,

        /// <remarks/>
        D0020,

        /// <remarks/>
        D0024,

        /// <remarks/>
        D0031,

        /// <remarks/>
        D1,

        /// <remarks/>
        D2,

        /// <remarks/>
        DL,

        /// <remarks/>
        DS,

        /// <remarks/>
        E0030,

        /// <remarks/>
        EG,

        /// <remarks/>
        EN,

        /// <remarks/>
        EU,

        /// <remarks/>
        F1,

        /// <remarks/>
        FG,

        /// <remarks/>
        FS,

        /// <remarks/>
        G0010,

        /// <remarks/>
        G0052,

        /// <remarks/>
        GI,

        /// <remarks/>
        GP,

        /// <remarks/>
        GU,

        /// <remarks/>
        H1,

        /// <remarks/>
        HC,

        /// <remarks/>
        HH,

        /// <remarks/>
        HS,

        /// <remarks/>
        I0012,

        /// <remarks/>
        I0013,

        /// <remarks/>
        I0021,

        /// <remarks/>
        I0022,

        /// <remarks/>
        IC,

        /// <remarks/>
        ID,

        /// <remarks/>
        IG,

        /// <remarks/>
        IM,

        /// <remarks/>
        IN,

        /// <remarks/>
        IO,

        /// <remarks/>
        IR,

        /// <remarks/>
        IS,

        /// <remarks/>
        IT,

        /// <remarks/>
        KO,

        /// <remarks/>
        L1,

        /// <remarks/>
        LA,

        /// <remarks/>
        M0010,

        /// <remarks/>
        M0042,

        /// <remarks/>
        MI,

        /// <remarks/>
        ML,

        /// <remarks/>
        N0020,

        /// <remarks/>
        N0032,

        /// <remarks/>
        NC,

        /// <remarks/>
        OA,

        /// <remarks/>
        P0012,

        /// <remarks/>
        P0014,

        /// <remarks/>
        P0016,

        /// <remarks/>
        P0018,

        /// <remarks/>
        P0022,

        /// <remarks/>
        PA,

        /// <remarks/>
        PB,

        /// <remarks/>
        PC,

        /// <remarks/>
        PE,

        /// <remarks/>
        PF,

        /// <remarks/>
        PL,

        /// <remarks/>
        R0072,

        /// <remarks/>
        R0076,

        /// <remarks/>
        R0110,

        /// <remarks/>
        S0014,

        /// <remarks/>
        S0016,

        /// <remarks/>
        S0022,

        /// <remarks/>
        S0024,

        /// <remarks/>
        S0050,

        /// <remarks/>
        S0052,

        /// <remarks/>
        S0054,

        /// <remarks/>
        S0056,

        /// <remarks/>
        S0080,

        /// <remarks/>
        S1,

        /// <remarks/>
        S2,

        /// <remarks/>
        S3,

        /// <remarks/>
        SD,

        /// <remarks/>
        SG,

        /// <remarks/>
        SH,

        /// <remarks/>
        SJ,

        /// <remarks/>
        SR,

        /// <remarks/>
        SU,

        /// <remarks/>
        SW,

        /// <remarks/>
        T0070,

        /// <remarks/>
        T1,

        /// <remarks/>
        TC,

        /// <remarks/>
        TE,

        /// <remarks/>
        TO,

        /// <remarks/>
        UN,

        /// <remarks/>
        US,

        /// <remarks/>
        V1,

        /// <remarks/>
        V2,

        /// <remarks/>
        W0010,

        /// <remarks/>
        WH,

        /// <remarks/>
        X0010,

        /// <remarks/>
        XP,

        /// <remarks/>
        YY,

        /// <remarks/>
        ZZ,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public enum X12_ID_331
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("01")]
        Item01,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("02")]
        Item02,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("03")]
        Item03,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("04")]
        Item04,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("05")]
        Item05,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("06")]
        Item06,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("07")]
        Item07,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("08")]
        Item08,

        /// <remarks/>
        ZZ,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public enum X12_ID_378
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6")]
        Item6,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7")]
        Item7,

        /// <remarks/>
        Z,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public enum X12_ID_150
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("005")]
        Item005,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("010")]
        Item010,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("015")]
        Item015,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("020")]
        Item020,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("025")]
        Item025,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("030")]
        Item030,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("035")]
        Item035,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("040")]
        Item040,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("045")]
        Item045,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("050")]
        Item050,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("055")]
        Item055,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("060")]
        Item060,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("065")]
        Item065,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("070")]
        Item070,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("075")]
        Item075,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("080")]
        Item080,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("085")]
        Item085,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("090")]
        Item090,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("095")]
        Item095,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("100")]
        Item100,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("105")]
        Item105,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("110")]
        Item110,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("115")]
        Item115,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("120")]
        Item120,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("130")]
        Item130,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("135")]
        Item135,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("140")]
        Item140,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("145")]
        Item145,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("150")]
        Item150,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("155")]
        Item155,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("160")]
        Item160,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("165")]
        Item165,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("170")]
        Item170,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("175")]
        Item175,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("180")]
        Item180,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("185")]
        Item185,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("186")]
        Item186,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("190")]
        Item190,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("205")]
        Item205,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("210")]
        Item210,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("215")]
        Item215,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("220")]
        Item220,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("225")]
        Item225,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("230")]
        Item230,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("235")]
        Item235,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("240")]
        Item240,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("245")]
        Item245,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("250")]
        Item250,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("255")]
        Item255,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("260")]
        Item260,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("265")]
        Item265,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("270")]
        Item270,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("275")]
        Item275,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("280")]
        Item280,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("285")]
        Item285,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("290")]
        Item290,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("295")]
        Item295,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("300")]
        Item300,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("310")]
        Item310,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("315")]
        Item315,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("320")]
        Item320,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("325")]
        Item325,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("330")]
        Item330,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("335")]
        Item335,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("340")]
        Item340,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("345")]
        Item345,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("350")]
        Item350,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("355")]
        Item355,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("360")]
        Item360,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("365")]
        Item365,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("370")]
        Item370,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("375")]
        Item375,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("380")]
        Item380,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("385")]
        Item385,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("390")]
        Item390,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("392")]
        Item392,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("393")]
        Item393,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("395")]
        Item395,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("400")]
        Item400,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("405")]
        Item405,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("410")]
        Item410,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("415")]
        Item415,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("416")]
        Item416,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("420")]
        Item420,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("425")]
        Item425,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("426")]
        Item426,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("430")]
        Item430,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("435")]
        Item435,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("440")]
        Item440,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("445")]
        Item445,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("450")]
        Item450,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("455")]
        Item455,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("460")]
        Item460,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("465")]
        Item465,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("470")]
        Item470,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("475")]
        Item475,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("480")]
        Item480,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("485")]
        Item485,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("490")]
        Item490,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("495")]
        Item495,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("500")]
        Item500,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("505")]
        Item505,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("510")]
        Item510,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("515")]
        Item515,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("520")]
        Item520,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("525")]
        Item525,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("535")]
        Item535,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("540")]
        Item540,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("545")]
        Item545,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("550")]
        Item550,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("555")]
        Item555,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("560")]
        Item560,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("565")]
        Item565,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("570")]
        Item570,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("580")]
        Item580,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("585")]
        Item585,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("586")]
        Item586,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("590")]
        Item590,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("595")]
        Item595,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("600")]
        Item600,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("605")]
        Item605,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("610")]
        Item610,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("615")]
        Item615,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("620")]
        Item620,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("625")]
        Item625,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("635")]
        Item635,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("640")]
        Item640,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("641")]
        Item641,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("645")]
        Item645,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("650")]
        Item650,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("665")]
        Item665,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("670")]
        Item670,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("675")]
        Item675,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("680")]
        Item680,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("685")]
        Item685,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("690")]
        Item690,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("695")]
        Item695,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("696")]
        Item696,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("697")]
        Item697,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("700")]
        Item700,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("705")]
        Item705,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("706")]
        Item706,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("720")]
        Item720,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("725")]
        Item725,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("730")]
        Item730,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("731")]
        Item731,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("732")]
        Item732,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("735")]
        Item735,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("736")]
        Item736,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("740")]
        Item740,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("745")]
        Item745,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("750")]
        Item750,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("755")]
        Item755,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("760")]
        Item760,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("761")]
        Item761,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("762")]
        Item762,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("999")]
        Item999,

        /// <remarks/>
        AAA,

        /// <remarks/>
        AAJ,

        /// <remarks/>
        AAM,

        /// <remarks/>
        AAN,

        /// <remarks/>
        AAO,

        /// <remarks/>
        AAT,

        /// <remarks/>
        ADH,

        /// <remarks/>
        ADV,

        /// <remarks/>
        AFB,

        /// <remarks/>
        ALC,

        /// <remarks/>
        ANS,

        /// <remarks/>
        APT,

        /// <remarks/>
        ARB,

        /// <remarks/>
        ASC,

        /// <remarks/>
        BAA,

        /// <remarks/>
        BAB,

        /// <remarks/>
        BAC,

        /// <remarks/>
        BAD,

        /// <remarks/>
        BAF,

        /// <remarks/>
        BAP,

        /// <remarks/>
        BAS,

        /// <remarks/>
        BBK,

        /// <remarks/>
        BDX,

        /// <remarks/>
        BEY,

        /// <remarks/>
        BFD,

        /// <remarks/>
        BLA,

        /// <remarks/>
        BLC,

        /// <remarks/>
        BLD,

        /// <remarks/>
        BLK,

        /// <remarks/>
        BLW,

        /// <remarks/>
        BND,

        /// <remarks/>
        BOB,

        /// <remarks/>
        BRA,

        /// <remarks/>
        BRD,

        /// <remarks/>
        CAA,

        /// <remarks/>
        CAB,

        /// <remarks/>
        CAC,

        /// <remarks/>
        CAD,

        /// <remarks/>
        CAE,

        /// <remarks/>
        CAF,

        /// <remarks/>
        CAG,

        /// <remarks/>
        CAH,

        /// <remarks/>
        CAJ,

        /// <remarks/>
        CAK,

        /// <remarks/>
        CAL,

        /// <remarks/>
        CAO,

        /// <remarks/>
        CAP,

        /// <remarks/>
        CAQ,

        /// <remarks/>
        CAR,

        /// <remarks/>
        CAS,

        /// <remarks/>
        CAT,

        /// <remarks/>
        CAU,

        /// <remarks/>
        CAV,

        /// <remarks/>
        CAW,

        /// <remarks/>
        CBO,

        /// <remarks/>
        CBP,

        /// <remarks/>
        CBR,

        /// <remarks/>
        CBW,

        /// <remarks/>
        CBX,

        /// <remarks/>
        CCA,

        /// <remarks/>
        CCH,

        /// <remarks/>
        CDA,

        /// <remarks/>
        CDF,

        /// <remarks/>
        CER,

        /// <remarks/>
        CGL,

        /// <remarks/>
        CHG,

        /// <remarks/>
        CHN,

        /// <remarks/>
        CIR,

        /// <remarks/>
        CLN,

        /// <remarks/>
        CLS,

        /// <remarks/>
        CMF,

        /// <remarks/>
        CMI,

        /// <remarks/>
        CMP,

        /// <remarks/>
        CNS,

        /// <remarks/>
        CNV,

        /// <remarks/>
        COA,

        /// <remarks/>
        COD,

        /// <remarks/>
        COF,

        /// <remarks/>
        COL,

        /// <remarks/>
        COM,

        /// <remarks/>
        CON,

        /// <remarks/>
        COU,

        /// <remarks/>
        CRA,

        /// <remarks/>
        CRC,

        /// <remarks/>
        CRF,

        /// <remarks/>
        CSA,

        /// <remarks/>
        CSC,

        /// <remarks/>
        CSE,

        /// <remarks/>
        CSF,

        /// <remarks/>
        CSR,

        /// <remarks/>
        CTA,

        /// <remarks/>
        CTC,

        /// <remarks/>
        CTF,

        /// <remarks/>
        CTG,

        /// <remarks/>
        CTL,

        /// <remarks/>
        CUA,

        /// <remarks/>
        CUD,

        /// <remarks/>
        CUS,

        /// <remarks/>
        DAA,

        /// <remarks/>
        DAB,

        /// <remarks/>
        DAC,

        /// <remarks/>
        DAD,

        /// <remarks/>
        DBD,

        /// <remarks/>
        DCS,

        /// <remarks/>
        DCT,

        /// <remarks/>
        DDA,

        /// <remarks/>
        DDC,

        /// <remarks/>
        DDD,

        /// <remarks/>
        DDF,

        /// <remarks/>
        DEA,

        /// <remarks/>
        DEL,

        /// <remarks/>
        DEM,

        /// <remarks/>
        DEP,

        /// <remarks/>
        DER,

        /// <remarks/>
        DES,

        /// <remarks/>
        DET,

        /// <remarks/>
        DFW,

        /// <remarks/>
        DIS,

        /// <remarks/>
        DIV,

        /// <remarks/>
        DLH,

        /// <remarks/>
        DMC,

        /// <remarks/>
        DMD,

        /// <remarks/>
        DOC,

        /// <remarks/>
        DON,

        /// <remarks/>
        DRC,

        /// <remarks/>
        DRP,

        /// <remarks/>
        DRY,

        /// <remarks/>
        DSC,

        /// <remarks/>
        DSF,

        /// <remarks/>
        DST,

        /// <remarks/>
        DTL,

        /// <remarks/>
        DTU,

        /// <remarks/>
        DWC,

        /// <remarks/>
        EEA,

        /// <remarks/>
        EEB,

        /// <remarks/>
        EEC,

        /// <remarks/>
        EED,

        /// <remarks/>
        EEF,

        /// <remarks/>
        EEG,

        /// <remarks/>
        EEH,

        /// <remarks/>
        EEP,

        /// <remarks/>
        EEX,

        /// <remarks/>
        EIC,

        /// <remarks/>
        EMS,

        /// <remarks/>
        ENC,

        /// <remarks/>
        ENS,

        /// <remarks/>
        EPC,

        /// <remarks/>
        EPS,

        /// <remarks/>
        ESC,

        /// <remarks/>
        EUC,

        /// <remarks/>
        EVC,

        /// <remarks/>
        EXC,

        /// <remarks/>
        EXL,

        /// <remarks/>
        EXM,

        /// <remarks/>
        EXP,

        /// <remarks/>
        EXS,

        /// <remarks/>
        FAB,

        /// <remarks/>
        FAC,

        /// <remarks/>
        FAD,

        /// <remarks/>
        FAE,

        /// <remarks/>
        FAF,

        /// <remarks/>
        FAG,

        /// <remarks/>
        FAH,

        /// <remarks/>
        FBD,

        /// <remarks/>
        FCB,

        /// <remarks/>
        FCD,

        /// <remarks/>
        FDL,

        /// <remarks/>
        FFA,

        /// <remarks/>
        FFC,

        /// <remarks/>
        FFI,

        /// <remarks/>
        FFL,

        /// <remarks/>
        FFN,

        /// <remarks/>
        FFP,

        /// <remarks/>
        FFR,

        /// <remarks/>
        FRC,

        /// <remarks/>
        FUE,

        /// <remarks/>
        FWA,

        /// <remarks/>
        GAR,

        /// <remarks/>
        GDR,

        /// <remarks/>
        GGA,

        /// <remarks/>
        GGF,

        /// <remarks/>
        GRD,

        /// <remarks/>
        HAN,

        /// <remarks/>
        HAZ,

        /// <remarks/>
        HDF,

        /// <remarks/>
        HDG,

        /// <remarks/>
        HET,

        /// <remarks/>
        HHA,

        /// <remarks/>
        HHB,

        /// <remarks/>
        HHG,

        /// <remarks/>
        HIC,

        /// <remarks/>
        HOC,

        /// <remarks/>
        HOL,

        /// <remarks/>
        HOS,

        /// <remarks/>
        HOX,

        /// <remarks/>
        HUL,

        /// <remarks/>
        HZS,

        /// <remarks/>
        IAA,

        /// <remarks/>
        IAB,

        /// <remarks/>
        IAC,

        /// <remarks/>
        IDL,

        /// <remarks/>
        IIA,

        /// <remarks/>
        IIP,

        /// <remarks/>
        IIU,

        /// <remarks/>
        INC,

        /// <remarks/>
        INP,

        /// <remarks/>
        INR,

        /// <remarks/>
        INS,

        /// <remarks/>
        IPC,

        /// <remarks/>
        IPU,

        /// <remarks/>
        IRA,

        /// <remarks/>
        ISD,

        /// <remarks/>
        ITC,

        /// <remarks/>
        LAA,

        /// <remarks/>
        LAB,

        /// <remarks/>
        LAC,

        /// <remarks/>
        LAD,

        /// <remarks/>
        LAE,

        /// <remarks/>
        LAY,

        /// <remarks/>
        LCG,

        /// <remarks/>
        LCR,

        /// <remarks/>
        LDG,

        /// <remarks/>
        LDS,

        /// <remarks/>
        LFT,

        /// <remarks/>
        LID,

        /// <remarks/>
        LLC,

        /// <remarks/>
        LLD,

        /// <remarks/>
        LLF,

        /// <remarks/>
        LLS,

        /// <remarks/>
        LMC,

        /// <remarks/>
        LNT,

        /// <remarks/>
        LOA,

        /// <remarks/>
        LOC,

        /// <remarks/>
        LPC,

        /// <remarks/>
        LSC,

        /// <remarks/>
        LSH,

        /// <remarks/>
        LTC,

        /// <remarks/>
        LUP,

        /// <remarks/>
        LUS,

        /// <remarks/>
        MAA,

        /// <remarks/>
        MAB,

        /// <remarks/>
        MAC,

        /// <remarks/>
        MAD,

        /// <remarks/>
        MAE,

        /// <remarks/>
        MAR,

        /// <remarks/>
        MDM,

        /// <remarks/>
        MES,

        /// <remarks/>
        MFG,

        /// <remarks/>
        MIL,

        /// <remarks/>
        MIN,

        /// <remarks/>
        MMC,

        /// <remarks/>
        MMF,

        /// <remarks/>
        MMS,

        /// <remarks/>
        MMT,

        /// <remarks/>
        MNC,

        /// <remarks/>
        MRK,

        /// <remarks/>
        MSC,

        /// <remarks/>
        MSG,

        /// <remarks/>
        MTR,

        /// <remarks/>
        MVT,

        /// <remarks/>
        NAA,

        /// <remarks/>
        NAB,

        /// <remarks/>
        NAL,

        /// <remarks/>
        NFY,

        /// <remarks/>
        NHB,

        /// <remarks/>
        NSD,

        /// <remarks/>
        NWD,

        /// <remarks/>
        NYD,

        /// <remarks/>
        NYP,

        /// <remarks/>
        OAA,

        /// <remarks/>
        OAB,

        /// <remarks/>
        OAC,

        /// <remarks/>
        ONC,

        /// <remarks/>
        OOC,

        /// <remarks/>
        OOF,

        /// <remarks/>
        OPC,

        /// <remarks/>
        ORM,

        /// <remarks/>
        OSO,

        /// <remarks/>
        OSS,

        /// <remarks/>
        OUT,

        /// <remarks/>
        OVR,

        /// <remarks/>
        PAA,

        /// <remarks/>
        PAB,

        /// <remarks/>
        PAC,

        /// <remarks/>
        PAD,

        /// <remarks/>
        PAE,

        /// <remarks/>
        PAF,

        /// <remarks/>
        PAG,

        /// <remarks/>
        PAH,

        /// <remarks/>
        PAI,

        /// <remarks/>
        PAJ,

        /// <remarks/>
        PBA,

        /// <remarks/>
        PBE,

        /// <remarks/>
        PBL,

        /// <remarks/>
        PCT,

        /// <remarks/>
        PEN,

        /// <remarks/>
        PER,

        /// <remarks/>
        PIR,

        /// <remarks/>
        PMU,

        /// <remarks/>
        PMX,

        /// <remarks/>
        POD,

        /// <remarks/>
        POS,

        /// <remarks/>
        PPC,

        /// <remarks/>
        PPH,

        /// <remarks/>
        PPI,

        /// <remarks/>
        PPM,

        /// <remarks/>
        PPN,

        /// <remarks/>
        PPO,

        /// <remarks/>
        PPR,

        /// <remarks/>
        PPS,

        /// <remarks/>
        PPT,

        /// <remarks/>
        PRB,

        /// <remarks/>
        PRC,

        /// <remarks/>
        PRE,

        /// <remarks/>
        PRM,

        /// <remarks/>
        PRO,

        /// <remarks/>
        PSC,

        /// <remarks/>
        PSH,

        /// <remarks/>
        PST,

        /// <remarks/>
        PUC,

        /// <remarks/>
        PUD,

        /// <remarks/>
        PWH,

        /// <remarks/>
        PWT,

        /// <remarks/>
        QAA,

        /// <remarks/>
        QQD,

        /// <remarks/>
        RAA,

        /// <remarks/>
        RAB,

        /// <remarks/>
        RAC,

        /// <remarks/>
        RAD,

        /// <remarks/>
        RAE,

        /// <remarks/>
        RAF,

        /// <remarks/>
        RAG,

        /// <remarks/>
        RAH,

        /// <remarks/>
        RAI,

        /// <remarks/>
        RAJ,

        /// <remarks/>
        RAK,

        /// <remarks/>
        RAL,

        /// <remarks/>
        RAM,

        /// <remarks/>
        RCA,

        /// <remarks/>
        RCB,

        /// <remarks/>
        RCE,

        /// <remarks/>
        RCG,

        /// <remarks/>
        RCL,

        /// <remarks/>
        RCP,

        /// <remarks/>
        RCS,

        /// <remarks/>
        RDF,

        /// <remarks/>
        REF,

        /// <remarks/>
        REG,

        /// <remarks/>
        REP,

        /// <remarks/>
        REQ,

        /// <remarks/>
        RES,

        /// <remarks/>
        RET,

        /// <remarks/>
        RGA,

        /// <remarks/>
        RGC,

        /// <remarks/>
        RID,

        /// <remarks/>
        RLC,

        /// <remarks/>
        RMD,

        /// <remarks/>
        RPC,

        /// <remarks/>
        RRC,

        /// <remarks/>
        RRD,

        /// <remarks/>
        RRF,

        /// <remarks/>
        RRN,

        /// <remarks/>
        RRP,

        /// <remarks/>
        RRR,

        /// <remarks/>
        RTC,

        /// <remarks/>
        SAA,

        /// <remarks/>
        SAB,

        /// <remarks/>
        SAC,

        /// <remarks/>
        SAD,

        /// <remarks/>
        SAE,

        /// <remarks/>
        SAF,

        /// <remarks/>
        SAG,

        /// <remarks/>
        SAH,

        /// <remarks/>
        SAI,

        /// <remarks/>
        SAJ,

        /// <remarks/>
        SAK,

        /// <remarks/>
        SAM,

        /// <remarks/>
        SAN,

        /// <remarks/>
        SAT,

        /// <remarks/>
        SBC,

        /// <remarks/>
        SCC,

        /// <remarks/>
        SCG,

        /// <remarks/>
        SCL,

        /// <remarks/>
        SCU,

        /// <remarks/>
        SDC,

        /// <remarks/>
        SDL,

        /// <remarks/>
        SEC,

        /// <remarks/>
        SEG,

        /// <remarks/>
        SEL,

        /// <remarks/>
        SER,

        /// <remarks/>
        SFT,

        /// <remarks/>
        SGL,

        /// <remarks/>
        SHL,

        /// <remarks/>
        SLC,

        /// <remarks/>
        SOC,

        /// <remarks/>
        SPA,

        /// <remarks/>
        SPB,

        /// <remarks/>
        SPC,

        /// <remarks/>
        SPD,

        /// <remarks/>
        SPL,

        /// <remarks/>
        SPS,

        /// <remarks/>
        SPT,

        /// <remarks/>
        SPU,

        /// <remarks/>
        SRG,

        /// <remarks/>
        SSA,

        /// <remarks/>
        SSB,

        /// <remarks/>
        SSC,

        /// <remarks/>
        SSF,

        /// <remarks/>
        SSL,

        /// <remarks/>
        SSO,

        /// <remarks/>
        SSP,

        /// <remarks/>
        SSS,

        /// <remarks/>
        SST,

        /// <remarks/>
        SSX,

        /// <remarks/>
        STF,

        /// <remarks/>
        STM,

        /// <remarks/>
        STP,

        /// <remarks/>
        STR,

        /// <remarks/>
        STW,

        /// <remarks/>
        SUC,

        /// <remarks/>
        SUF,

        /// <remarks/>
        SUP,

        /// <remarks/>
        SUR,

        /// <remarks/>
        SVA,

        /// <remarks/>
        SWC,

        /// <remarks/>
        TAA,

        /// <remarks/>
        TAB,

        /// <remarks/>
        TAC,

        /// <remarks/>
        TAD,

        /// <remarks/>
        TAE,

        /// <remarks/>
        TAF,

        /// <remarks/>
        TAG,

        /// <remarks/>
        TAH,

        /// <remarks/>
        TAI,

        /// <remarks/>
        TAJ,

        /// <remarks/>
        TAK,

        /// <remarks/>
        TAL,

        /// <remarks/>
        TAX,

        /// <remarks/>
        TAY,

        /// <remarks/>
        TCM,

        /// <remarks/>
        TDT,

        /// <remarks/>
        TER,

        /// <remarks/>
        TLC,

        /// <remarks/>
        TOC,

        /// <remarks/>
        TRC,

        /// <remarks/>
        TRF,

        /// <remarks/>
        TRN,

        /// <remarks/>
        TRP,

        /// <remarks/>
        TRU,

        /// <remarks/>
        TSC,

        /// <remarks/>
        TST,

        /// <remarks/>
        TTA,

        /// <remarks/>
        TTB,

        /// <remarks/>
        TTD,

        /// <remarks/>
        TTL,

        /// <remarks/>
        TTM,

        /// <remarks/>
        TTP,

        /// <remarks/>
        TTR,

        /// <remarks/>
        TTS,

        /// <remarks/>
        TTT,

        /// <remarks/>
        TTV,

        /// <remarks/>
        TUR,

        /// <remarks/>
        TWO,

        /// <remarks/>
        UND,

        /// <remarks/>
        UNL,

        /// <remarks/>
        USF,

        /// <remarks/>
        USV,

        /// <remarks/>
        USW,

        /// <remarks/>
        UTP,

        /// <remarks/>
        UUC,

        /// <remarks/>
        UUM,

        /// <remarks/>
        UUT,

        /// <remarks/>
        VAA,

        /// <remarks/>
        VAB,

        /// <remarks/>
        VCR,

        /// <remarks/>
        VOR,

        /// <remarks/>
        VVL,

        /// <remarks/>
        VVP,

        /// <remarks/>
        WAR,

        /// <remarks/>
        WEA,

        /// <remarks/>
        WFH,

        /// <remarks/>
        WRC,

        /// <remarks/>
        WRE,

        /// <remarks/>
        WSA,

        /// <remarks/>
        WTG,

        /// <remarks/>
        WWC,

        /// <remarks/>
        ZFF,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public partial class S_TXI_2
    {

        private X12_ID_963 d_963_1Field;

        private string d_782_2Field;

        private string d_954_3Field;

        private X12_ID_955 d_955_4Field;

        private bool d_955_4FieldSpecified;

        private string d_956_5Field;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public X12_ID_963 D_963_1
        {
            get
            {
                return this.d_963_1Field;
            }
            set
            {
                this.d_963_1Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string D_782_2
        {
            get
            {
                return this.d_782_2Field;
            }
            set
            {
                this.d_782_2Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string D_954_3
        {
            get
            {
                return this.d_954_3Field;
            }
            set
            {
                this.d_954_3Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public X12_ID_955 D_955_4
        {
            get
            {
                return this.d_955_4Field;
            }
            set
            {
                this.d_955_4Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_955_4Specified
        {
            get
            {
                return this.d_955_4FieldSpecified;
            }
            set
            {
                this.d_955_4FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string D_956_5
        {
            get
            {
                return this.d_956_5Field;
            }
            set
            {
                this.d_956_5Field = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public partial class G_SLN
    {

        private S_SLN s_SLNField;

        private List<S_REF_4> s_REF_4Field;

        private List<S_PID_3> s_PID_3Field;

        private List<S_ITA_2> s_ITA_2Field;

        public G_SLN()
        {
            this.s_ITA_2Field = new List<S_ITA_2>();
            this.s_PID_3Field = new List<S_PID_3>();
            this.s_REF_4Field = new List<S_REF_4>();
            this.s_SLNField = new S_SLN();
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public S_SLN S_SLN
        {
            get
            {
                return this.s_SLNField;
            }
            set
            {
                this.s_SLNField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("S_REF_4", Order = 1)]
        public List<S_REF_4> S_REF_4
        {
            get
            {
                return this.s_REF_4Field;
            }
            set
            {
                this.s_REF_4Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("S_PID_3", Order = 2)]
        public List<S_PID_3> S_PID_3
        {
            get
            {
                return this.s_PID_3Field;
            }
            set
            {
                this.s_PID_3Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("S_ITA_2", Order = 3)]
        public List<S_ITA_2> S_ITA_2
        {
            get
            {
                return this.s_ITA_2Field;
            }
            set
            {
                this.s_ITA_2Field = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public partial class S_SLN
    {

        private string d_350_1Field;

        private string d_350_2Field;

        private X12_ID_661 d_661_3Field;

        private string d_380_4Field;

        private X12_ID_355 d_355_5Field;

        private string d_212_6Field;

        private X12_ID_639 d_639_7Field;

        private bool d_639_7FieldSpecified;

        private X12_ID_662 d_662_8Field;

        private bool d_662_8FieldSpecified;

        private X12_ID_235 d_235_9Field;

        private bool d_235_9FieldSpecified;

        private string d_234_10Field;

        private X12_ID_235 d_235_11Field;

        private bool d_235_11FieldSpecified;

        private string d_234_12Field;

        private X12_ID_235 d_235_13Field;

        private bool d_235_13FieldSpecified;

        private string d_234_14Field;

        private X12_ID_235 d_235_15Field;

        private bool d_235_15FieldSpecified;

        private string d_234_16Field;

        private X12_ID_235 d_235_17Field;

        private bool d_235_17FieldSpecified;

        private string d_234_18Field;

        private X12_ID_235 d_235_19Field;

        private bool d_235_19FieldSpecified;

        private string d_234_20Field;

        private X12_ID_235 d_235_21Field;

        private bool d_235_21FieldSpecified;

        private string d_234_22Field;

        private X12_ID_235 d_235_23Field;

        private bool d_235_23FieldSpecified;

        private string d_234_24Field;

        private X12_ID_235 d_235_25Field;

        private bool d_235_25FieldSpecified;

        private string d_234_26Field;

        private X12_ID_235 d_235_27Field;

        private bool d_235_27FieldSpecified;

        private string d_234_28Field;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string D_350_1
        {
            get
            {
                return this.d_350_1Field;
            }
            set
            {
                this.d_350_1Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string D_350_2
        {
            get
            {
                return this.d_350_2Field;
            }
            set
            {
                this.d_350_2Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public X12_ID_661 D_661_3
        {
            get
            {
                return this.d_661_3Field;
            }
            set
            {
                this.d_661_3Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string D_380_4
        {
            get
            {
                return this.d_380_4Field;
            }
            set
            {
                this.d_380_4Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public X12_ID_355 D_355_5
        {
            get
            {
                return this.d_355_5Field;
            }
            set
            {
                this.d_355_5Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string D_212_6
        {
            get
            {
                return this.d_212_6Field;
            }
            set
            {
                this.d_212_6Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public X12_ID_639 D_639_7
        {
            get
            {
                return this.d_639_7Field;
            }
            set
            {
                this.d_639_7Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_639_7Specified
        {
            get
            {
                return this.d_639_7FieldSpecified;
            }
            set
            {
                this.d_639_7FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public X12_ID_662 D_662_8
        {
            get
            {
                return this.d_662_8Field;
            }
            set
            {
                this.d_662_8Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_662_8Specified
        {
            get
            {
                return this.d_662_8FieldSpecified;
            }
            set
            {
                this.d_662_8FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public X12_ID_235 D_235_9
        {
            get
            {
                return this.d_235_9Field;
            }
            set
            {
                this.d_235_9Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_235_9Specified
        {
            get
            {
                return this.d_235_9FieldSpecified;
            }
            set
            {
                this.d_235_9FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string D_234_10
        {
            get
            {
                return this.d_234_10Field;
            }
            set
            {
                this.d_234_10Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public X12_ID_235 D_235_11
        {
            get
            {
                return this.d_235_11Field;
            }
            set
            {
                this.d_235_11Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_235_11Specified
        {
            get
            {
                return this.d_235_11FieldSpecified;
            }
            set
            {
                this.d_235_11FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public string D_234_12
        {
            get
            {
                return this.d_234_12Field;
            }
            set
            {
                this.d_234_12Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public X12_ID_235 D_235_13
        {
            get
            {
                return this.d_235_13Field;
            }
            set
            {
                this.d_235_13Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_235_13Specified
        {
            get
            {
                return this.d_235_13FieldSpecified;
            }
            set
            {
                this.d_235_13FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public string D_234_14
        {
            get
            {
                return this.d_234_14Field;
            }
            set
            {
                this.d_234_14Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 14)]
        public X12_ID_235 D_235_15
        {
            get
            {
                return this.d_235_15Field;
            }
            set
            {
                this.d_235_15Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_235_15Specified
        {
            get
            {
                return this.d_235_15FieldSpecified;
            }
            set
            {
                this.d_235_15FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 15)]
        public string D_234_16
        {
            get
            {
                return this.d_234_16Field;
            }
            set
            {
                this.d_234_16Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 16)]
        public X12_ID_235 D_235_17
        {
            get
            {
                return this.d_235_17Field;
            }
            set
            {
                this.d_235_17Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_235_17Specified
        {
            get
            {
                return this.d_235_17FieldSpecified;
            }
            set
            {
                this.d_235_17FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 17)]
        public string D_234_18
        {
            get
            {
                return this.d_234_18Field;
            }
            set
            {
                this.d_234_18Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 18)]
        public X12_ID_235 D_235_19
        {
            get
            {
                return this.d_235_19Field;
            }
            set
            {
                this.d_235_19Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_235_19Specified
        {
            get
            {
                return this.d_235_19FieldSpecified;
            }
            set
            {
                this.d_235_19FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 19)]
        public string D_234_20
        {
            get
            {
                return this.d_234_20Field;
            }
            set
            {
                this.d_234_20Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 20)]
        public X12_ID_235 D_235_21
        {
            get
            {
                return this.d_235_21Field;
            }
            set
            {
                this.d_235_21Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_235_21Specified
        {
            get
            {
                return this.d_235_21FieldSpecified;
            }
            set
            {
                this.d_235_21FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 21)]
        public string D_234_22
        {
            get
            {
                return this.d_234_22Field;
            }
            set
            {
                this.d_234_22Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 22)]
        public X12_ID_235 D_235_23
        {
            get
            {
                return this.d_235_23Field;
            }
            set
            {
                this.d_235_23Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_235_23Specified
        {
            get
            {
                return this.d_235_23FieldSpecified;
            }
            set
            {
                this.d_235_23FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 23)]
        public string D_234_24
        {
            get
            {
                return this.d_234_24Field;
            }
            set
            {
                this.d_234_24Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 24)]
        public X12_ID_235 D_235_25
        {
            get
            {
                return this.d_235_25Field;
            }
            set
            {
                this.d_235_25Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_235_25Specified
        {
            get
            {
                return this.d_235_25FieldSpecified;
            }
            set
            {
                this.d_235_25FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 25)]
        public string D_234_26
        {
            get
            {
                return this.d_234_26Field;
            }
            set
            {
                this.d_234_26Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 26)]
        public X12_ID_235 D_235_27
        {
            get
            {
                return this.d_235_27Field;
            }
            set
            {
                this.d_235_27Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_235_27Specified
        {
            get
            {
                return this.d_235_27FieldSpecified;
            }
            set
            {
                this.d_235_27FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 27)]
        public string D_234_28
        {
            get
            {
                return this.d_234_28Field;
            }
            set
            {
                this.d_234_28Field = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public enum X12_ID_661
    {

        /// <remarks/>
        A,

        /// <remarks/>
        D,

        /// <remarks/>
        I,

        /// <remarks/>
        S,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public enum X12_ID_662
    {

        /// <remarks/>
        A,

        /// <remarks/>
        D,

        /// <remarks/>
        I,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public partial class S_REF_4
    {

        private X12_ID_128 d_128_1Field;

        private string d_127_2Field;

        private string d_352_3Field;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public X12_ID_128 D_128_1
        {
            get
            {
                return this.d_128_1Field;
            }
            set
            {
                this.d_128_1Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string D_127_2
        {
            get
            {
                return this.d_127_2Field;
            }
            set
            {
                this.d_127_2Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string D_352_3
        {
            get
            {
                return this.d_352_3Field;
            }
            set
            {
                this.d_352_3Field = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public partial class S_PID_3
    {

        private X12_ID_349 d_349_1Field;

        private X12_ID_750 d_750_2Field;

        private bool d_750_2FieldSpecified;

        private X12_ID_348 d_348_3Field;

        private bool d_348_3FieldSpecified;

        private string d_751_4Field;

        private string d_352_5Field;

        private X12_ID_752 d_752_6Field;

        private bool d_752_6FieldSpecified;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public X12_ID_349 D_349_1
        {
            get
            {
                return this.d_349_1Field;
            }
            set
            {
                this.d_349_1Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public X12_ID_750 D_750_2
        {
            get
            {
                return this.d_750_2Field;
            }
            set
            {
                this.d_750_2Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_750_2Specified
        {
            get
            {
                return this.d_750_2FieldSpecified;
            }
            set
            {
                this.d_750_2FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public X12_ID_348 D_348_3
        {
            get
            {
                return this.d_348_3Field;
            }
            set
            {
                this.d_348_3Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_348_3Specified
        {
            get
            {
                return this.d_348_3FieldSpecified;
            }
            set
            {
                this.d_348_3FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string D_751_4
        {
            get
            {
                return this.d_751_4Field;
            }
            set
            {
                this.d_751_4Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string D_352_5
        {
            get
            {
                return this.d_352_5Field;
            }
            set
            {
                this.d_352_5Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public X12_ID_752 D_752_6
        {
            get
            {
                return this.d_752_6Field;
            }
            set
            {
                this.d_752_6Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_752_6Specified
        {
            get
            {
                return this.d_752_6FieldSpecified;
            }
            set
            {
                this.d_752_6FieldSpecified = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public partial class S_ITA_2
    {

        private X12_ID_248 d_248_1Field;

        private X12_ID_559 d_559_2Field;

        private bool d_559_2FieldSpecified;

        private X12_ID_560 d_560_3Field;

        private bool d_560_3FieldSpecified;

        private X12_ID_331 d_331_4Field;

        private string d_341_5Field;

        private string d_359_6Field;

        private string d_360_7Field;

        private X12_ID_378 d_378_8Field;

        private bool d_378_8FieldSpecified;

        private string d_332_9Field;

        private string d_339_10Field;

        private X12_ID_355 d_355_11Field;

        private bool d_355_11FieldSpecified;

        private string d_380_12Field;

        private string d_352_13Field;

        private X12_ID_150 d_150_14Field;

        private bool d_150_14FieldSpecified;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public X12_ID_248 D_248_1
        {
            get
            {
                return this.d_248_1Field;
            }
            set
            {
                this.d_248_1Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public X12_ID_559 D_559_2
        {
            get
            {
                return this.d_559_2Field;
            }
            set
            {
                this.d_559_2Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_559_2Specified
        {
            get
            {
                return this.d_559_2FieldSpecified;
            }
            set
            {
                this.d_559_2FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public X12_ID_560 D_560_3
        {
            get
            {
                return this.d_560_3Field;
            }
            set
            {
                this.d_560_3Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_560_3Specified
        {
            get
            {
                return this.d_560_3FieldSpecified;
            }
            set
            {
                this.d_560_3FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public X12_ID_331 D_331_4
        {
            get
            {
                return this.d_331_4Field;
            }
            set
            {
                this.d_331_4Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string D_341_5
        {
            get
            {
                return this.d_341_5Field;
            }
            set
            {
                this.d_341_5Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string D_359_6
        {
            get
            {
                return this.d_359_6Field;
            }
            set
            {
                this.d_359_6Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string D_360_7
        {
            get
            {
                return this.d_360_7Field;
            }
            set
            {
                this.d_360_7Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public X12_ID_378 D_378_8
        {
            get
            {
                return this.d_378_8Field;
            }
            set
            {
                this.d_378_8Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_378_8Specified
        {
            get
            {
                return this.d_378_8FieldSpecified;
            }
            set
            {
                this.d_378_8FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string D_332_9
        {
            get
            {
                return this.d_332_9Field;
            }
            set
            {
                this.d_332_9Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string D_339_10
        {
            get
            {
                return this.d_339_10Field;
            }
            set
            {
                this.d_339_10Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public X12_ID_355 D_355_11
        {
            get
            {
                return this.d_355_11Field;
            }
            set
            {
                this.d_355_11Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_355_11Specified
        {
            get
            {
                return this.d_355_11FieldSpecified;
            }
            set
            {
                this.d_355_11FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public string D_380_12
        {
            get
            {
                return this.d_380_12Field;
            }
            set
            {
                this.d_380_12Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public string D_352_13
        {
            get
            {
                return this.d_352_13Field;
            }
            set
            {
                this.d_352_13Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public X12_ID_150 D_150_14
        {
            get
            {
                return this.d_150_14Field;
            }
            set
            {
                this.d_150_14Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_150_14Specified
        {
            get
            {
                return this.d_150_14FieldSpecified;
            }
            set
            {
                this.d_150_14FieldSpecified = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public partial class G_N1_2
    {

        private S_N1_2 s_N1_2Field;

        private List<S_N2_2> s_N2_2Field;

        private List<S_N3_2> s_N3_2Field;

        private S_N4_2 s_N4_2Field;

        private List<S_REF_5> s_REF_5Field;

        private List<S_PER_4> s_PER_4Field;

        public G_N1_2()
        {
            this.s_PER_4Field = new List<S_PER_4>();
            this.s_REF_5Field = new List<S_REF_5>();
            this.s_N4_2Field = new S_N4_2();
            this.s_N3_2Field = new List<S_N3_2>();
            this.s_N2_2Field = new List<S_N2_2>();
            this.s_N1_2Field = new S_N1_2();
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public S_N1_2 S_N1_2
        {
            get
            {
                return this.s_N1_2Field;
            }
            set
            {
                this.s_N1_2Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("S_N2_2", Order = 1)]
        public List<S_N2_2> S_N2_2
        {
            get
            {
                return this.s_N2_2Field;
            }
            set
            {
                this.s_N2_2Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("S_N3_2", Order = 2)]
        public List<S_N3_2> S_N3_2
        {
            get
            {
                return this.s_N3_2Field;
            }
            set
            {
                this.s_N3_2Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public S_N4_2 S_N4_2
        {
            get
            {
                return this.s_N4_2Field;
            }
            set
            {
                this.s_N4_2Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("S_REF_5", Order = 4)]
        public List<S_REF_5> S_REF_5
        {
            get
            {
                return this.s_REF_5Field;
            }
            set
            {
                this.s_REF_5Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("S_PER_4", Order = 5)]
        public List<S_PER_4> S_PER_4
        {
            get
            {
                return this.s_PER_4Field;
            }
            set
            {
                this.s_PER_4Field = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public partial class S_N1_2
    {

        private X12_ID_98 d_98_1Field;

        private string d_93_2Field;

        private X12_ID_66 d_66_3Field;

        private bool d_66_3FieldSpecified;

        private string d_67_4Field;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public X12_ID_98 D_98_1
        {
            get
            {
                return this.d_98_1Field;
            }
            set
            {
                this.d_98_1Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string D_93_2
        {
            get
            {
                return this.d_93_2Field;
            }
            set
            {
                this.d_93_2Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public X12_ID_66 D_66_3
        {
            get
            {
                return this.d_66_3Field;
            }
            set
            {
                this.d_66_3Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_66_3Specified
        {
            get
            {
                return this.d_66_3FieldSpecified;
            }
            set
            {
                this.d_66_3FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string D_67_4
        {
            get
            {
                return this.d_67_4Field;
            }
            set
            {
                this.d_67_4Field = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public partial class S_N2_2
    {

        private string d_93_1Field;

        private string d_93_2Field;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string D_93_1
        {
            get
            {
                return this.d_93_1Field;
            }
            set
            {
                this.d_93_1Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string D_93_2
        {
            get
            {
                return this.d_93_2Field;
            }
            set
            {
                this.d_93_2Field = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public partial class S_N3_2
    {

        private string d_166_1Field;

        private string d_166_2Field;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string D_166_1
        {
            get
            {
                return this.d_166_1Field;
            }
            set
            {
                this.d_166_1Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string D_166_2
        {
            get
            {
                return this.d_166_2Field;
            }
            set
            {
                this.d_166_2Field = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public partial class S_N4_2
    {

        private string d_19_1Field;

        private string d_156_2Field;

        private string d_116_3Field;

        private string d_26_4Field;

        private X12_ID_309 d_309_5Field;

        private bool d_309_5FieldSpecified;

        private string d_310_6Field;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string D_19_1
        {
            get
            {
                return this.d_19_1Field;
            }
            set
            {
                this.d_19_1Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string D_156_2
        {
            get
            {
                return this.d_156_2Field;
            }
            set
            {
                this.d_156_2Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string D_116_3
        {
            get
            {
                return this.d_116_3Field;
            }
            set
            {
                this.d_116_3Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string D_26_4
        {
            get
            {
                return this.d_26_4Field;
            }
            set
            {
                this.d_26_4Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public X12_ID_309 D_309_5
        {
            get
            {
                return this.d_309_5Field;
            }
            set
            {
                this.d_309_5Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_309_5Specified
        {
            get
            {
                return this.d_309_5FieldSpecified;
            }
            set
            {
                this.d_309_5FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string D_310_6
        {
            get
            {
                return this.d_310_6Field;
            }
            set
            {
                this.d_310_6Field = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public partial class S_REF_5
    {

        private X12_ID_128 d_128_1Field;

        private string d_127_2Field;

        private string d_352_3Field;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public X12_ID_128 D_128_1
        {
            get
            {
                return this.d_128_1Field;
            }
            set
            {
                this.d_128_1Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string D_127_2
        {
            get
            {
                return this.d_127_2Field;
            }
            set
            {
                this.d_127_2Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string D_352_3
        {
            get
            {
                return this.d_352_3Field;
            }
            set
            {
                this.d_352_3Field = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public partial class S_PER_4
    {

        private X12_ID_366 d_366_1Field;

        private string d_93_2Field;

        private X12_ID_365 d_365_3Field;

        private bool d_365_3FieldSpecified;

        private string d_364_4Field;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public X12_ID_366 D_366_1
        {
            get
            {
                return this.d_366_1Field;
            }
            set
            {
                this.d_366_1Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string D_93_2
        {
            get
            {
                return this.d_93_2Field;
            }
            set
            {
                this.d_93_2Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public X12_ID_365 D_365_3
        {
            get
            {
                return this.d_365_3Field;
            }
            set
            {
                this.d_365_3Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_365_3Specified
        {
            get
            {
                return this.d_365_3FieldSpecified;
            }
            set
            {
                this.d_365_3FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string D_364_4
        {
            get
            {
                return this.d_364_4Field;
            }
            set
            {
                this.d_364_4Field = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public partial class S_TDS
    {

        private string d_361_1Field;

        private string d_390_2Field;

        private string d_391_3Field;

        private string d_362_4Field;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string D_361_1
        {
            get
            {
                return this.d_361_1Field;
            }
            set
            {
                this.d_361_1Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string D_390_2
        {
            get
            {
                return this.d_390_2Field;
            }
            set
            {
                this.d_390_2Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string D_391_3
        {
            get
            {
                return this.d_391_3Field;
            }
            set
            {
                this.d_391_3Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string D_362_4
        {
            get
            {
                return this.d_362_4Field;
            }
            set
            {
                this.d_362_4Field = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public partial class S_TXI_3
    {

        private X12_ID_963 d_963_1Field;

        private string d_782_2Field;

        private string d_954_3Field;

        private X12_ID_955 d_955_4Field;

        private bool d_955_4FieldSpecified;

        private string d_956_5Field;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public X12_ID_963 D_963_1
        {
            get
            {
                return this.d_963_1Field;
            }
            set
            {
                this.d_963_1Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string D_782_2
        {
            get
            {
                return this.d_782_2Field;
            }
            set
            {
                this.d_782_2Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string D_954_3
        {
            get
            {
                return this.d_954_3Field;
            }
            set
            {
                this.d_954_3Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public X12_ID_955 D_955_4
        {
            get
            {
                return this.d_955_4Field;
            }
            set
            {
                this.d_955_4Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_955_4Specified
        {
            get
            {
                return this.d_955_4FieldSpecified;
            }
            set
            {
                this.d_955_4FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string D_956_5
        {
            get
            {
                return this.d_956_5Field;
            }
            set
            {
                this.d_956_5Field = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public partial class S_CAD_2
    {

        private X12_ID_91 d_91_1Field;

        private bool d_91_1FieldSpecified;

        private string d_206_2Field;

        private string d_207_3Field;

        private string d_140_4Field;

        private string d_387_5Field;

        private X12_ID_368 d_368_6Field;

        private bool d_368_6FieldSpecified;

        private X12_ID_128 d_128_7Field;

        private bool d_128_7FieldSpecified;

        private string d_127_8Field;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public X12_ID_91 D_91_1
        {
            get
            {
                return this.d_91_1Field;
            }
            set
            {
                this.d_91_1Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_91_1Specified
        {
            get
            {
                return this.d_91_1FieldSpecified;
            }
            set
            {
                this.d_91_1FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string D_206_2
        {
            get
            {
                return this.d_206_2Field;
            }
            set
            {
                this.d_206_2Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string D_207_3
        {
            get
            {
                return this.d_207_3Field;
            }
            set
            {
                this.d_207_3Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public string D_140_4
        {
            get
            {
                return this.d_140_4Field;
            }
            set
            {
                this.d_140_4Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string D_387_5
        {
            get
            {
                return this.d_387_5Field;
            }
            set
            {
                this.d_387_5Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public X12_ID_368 D_368_6
        {
            get
            {
                return this.d_368_6Field;
            }
            set
            {
                this.d_368_6Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_368_6Specified
        {
            get
            {
                return this.d_368_6FieldSpecified;
            }
            set
            {
                this.d_368_6FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public X12_ID_128 D_128_7
        {
            get
            {
                return this.d_128_7Field;
            }
            set
            {
                this.d_128_7Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_128_7Specified
        {
            get
            {
                return this.d_128_7FieldSpecified;
            }
            set
            {
                this.d_128_7FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public string D_127_8
        {
            get
            {
                return this.d_127_8Field;
            }
            set
            {
                this.d_127_8Field = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public partial class G_ITA_2
    {

        private S_ITA_3 s_ITA_3Field;

        private List<S_TXI_4> s_TXI_4Field;

        public G_ITA_2()
        {
            this.s_TXI_4Field = new List<S_TXI_4>();
            this.s_ITA_3Field = new S_ITA_3();
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public S_ITA_3 S_ITA_3
        {
            get
            {
                return this.s_ITA_3Field;
            }
            set
            {
                this.s_ITA_3Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("S_TXI_4", Order = 1)]
        public List<S_TXI_4> S_TXI_4
        {
            get
            {
                return this.s_TXI_4Field;
            }
            set
            {
                this.s_TXI_4Field = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public partial class S_ITA_3
    {

        private X12_ID_248 d_248_1Field;

        private X12_ID_559 d_559_2Field;

        private bool d_559_2FieldSpecified;

        private X12_ID_560 d_560_3Field;

        private bool d_560_3FieldSpecified;

        private X12_ID_331 d_331_4Field;

        private string d_341_5Field;

        private string d_359_6Field;

        private string d_360_7Field;

        private X12_ID_378 d_378_8Field;

        private bool d_378_8FieldSpecified;

        private string d_332_9Field;

        private string d_339_10Field;

        private X12_ID_355 d_355_11Field;

        private bool d_355_11FieldSpecified;

        private string d_380_12Field;

        private string d_352_13Field;

        private X12_ID_150 d_150_14Field;

        private bool d_150_14FieldSpecified;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public X12_ID_248 D_248_1
        {
            get
            {
                return this.d_248_1Field;
            }
            set
            {
                this.d_248_1Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public X12_ID_559 D_559_2
        {
            get
            {
                return this.d_559_2Field;
            }
            set
            {
                this.d_559_2Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_559_2Specified
        {
            get
            {
                return this.d_559_2FieldSpecified;
            }
            set
            {
                this.d_559_2FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public X12_ID_560 D_560_3
        {
            get
            {
                return this.d_560_3Field;
            }
            set
            {
                this.d_560_3Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_560_3Specified
        {
            get
            {
                return this.d_560_3FieldSpecified;
            }
            set
            {
                this.d_560_3FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public X12_ID_331 D_331_4
        {
            get
            {
                return this.d_331_4Field;
            }
            set
            {
                this.d_331_4Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string D_341_5
        {
            get
            {
                return this.d_341_5Field;
            }
            set
            {
                this.d_341_5Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public string D_359_6
        {
            get
            {
                return this.d_359_6Field;
            }
            set
            {
                this.d_359_6Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string D_360_7
        {
            get
            {
                return this.d_360_7Field;
            }
            set
            {
                this.d_360_7Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public X12_ID_378 D_378_8
        {
            get
            {
                return this.d_378_8Field;
            }
            set
            {
                this.d_378_8Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_378_8Specified
        {
            get
            {
                return this.d_378_8FieldSpecified;
            }
            set
            {
                this.d_378_8FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 8)]
        public string D_332_9
        {
            get
            {
                return this.d_332_9Field;
            }
            set
            {
                this.d_332_9Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public string D_339_10
        {
            get
            {
                return this.d_339_10Field;
            }
            set
            {
                this.d_339_10Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public X12_ID_355 D_355_11
        {
            get
            {
                return this.d_355_11Field;
            }
            set
            {
                this.d_355_11Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_355_11Specified
        {
            get
            {
                return this.d_355_11FieldSpecified;
            }
            set
            {
                this.d_355_11FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public string D_380_12
        {
            get
            {
                return this.d_380_12Field;
            }
            set
            {
                this.d_380_12Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 12)]
        public string D_352_13
        {
            get
            {
                return this.d_352_13Field;
            }
            set
            {
                this.d_352_13Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 13)]
        public X12_ID_150 D_150_14
        {
            get
            {
                return this.d_150_14Field;
            }
            set
            {
                this.d_150_14Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_150_14Specified
        {
            get
            {
                return this.d_150_14FieldSpecified;
            }
            set
            {
                this.d_150_14FieldSpecified = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public partial class S_TXI_4
    {

        private X12_ID_963 d_963_1Field;

        private string d_782_2Field;

        private string d_954_3Field;

        private X12_ID_955 d_955_4Field;

        private bool d_955_4FieldSpecified;

        private string d_956_5Field;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public X12_ID_963 D_963_1
        {
            get
            {
                return this.d_963_1Field;
            }
            set
            {
                this.d_963_1Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string D_782_2
        {
            get
            {
                return this.d_782_2Field;
            }
            set
            {
                this.d_782_2Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string D_954_3
        {
            get
            {
                return this.d_954_3Field;
            }
            set
            {
                this.d_954_3Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public X12_ID_955 D_955_4
        {
            get
            {
                return this.d_955_4Field;
            }
            set
            {
                this.d_955_4Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_955_4Specified
        {
            get
            {
                return this.d_955_4FieldSpecified;
            }
            set
            {
                this.d_955_4FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string D_956_5
        {
            get
            {
                return this.d_956_5Field;
            }
            set
            {
                this.d_956_5Field = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public partial class S_ISS
    {

        private string d_382_1Field;

        private X12_ID_355 d_355_2Field;

        private bool d_355_2FieldSpecified;

        private string d_81_3Field;

        private X12_ID_355 d_355_4Field;

        private bool d_355_4FieldSpecified;

        private string d_183_5Field;

        private X12_ID_355 d_355_6Field;

        private bool d_355_6FieldSpecified;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string D_382_1
        {
            get
            {
                return this.d_382_1Field;
            }
            set
            {
                this.d_382_1Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public X12_ID_355 D_355_2
        {
            get
            {
                return this.d_355_2Field;
            }
            set
            {
                this.d_355_2Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_355_2Specified
        {
            get
            {
                return this.d_355_2FieldSpecified;
            }
            set
            {
                this.d_355_2FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string D_81_3
        {
            get
            {
                return this.d_81_3Field;
            }
            set
            {
                this.d_81_3Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public X12_ID_355 D_355_4
        {
            get
            {
                return this.d_355_4Field;
            }
            set
            {
                this.d_355_4Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_355_4Specified
        {
            get
            {
                return this.d_355_4FieldSpecified;
            }
            set
            {
                this.d_355_4FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string D_183_5
        {
            get
            {
                return this.d_183_5Field;
            }
            set
            {
                this.d_183_5Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public X12_ID_355 D_355_6
        {
            get
            {
                return this.d_355_6Field;
            }
            set
            {
                this.d_355_6Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_355_6Specified
        {
            get
            {
                return this.d_355_6FieldSpecified;
            }
            set
            {
                this.d_355_6FieldSpecified = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public partial class S_CTT
    {

        private string d_354_1Field;

        private string d_347_2Field;

        private string d_81_3Field;

        private X12_ID_355 d_355_4Field;

        private bool d_355_4FieldSpecified;

        private string d_183_5Field;

        private X12_ID_355 d_355_6Field;

        private bool d_355_6FieldSpecified;

        private string d_352_7Field;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string D_354_1
        {
            get
            {
                return this.d_354_1Field;
            }
            set
            {
                this.d_354_1Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string D_347_2
        {
            get
            {
                return this.d_347_2Field;
            }
            set
            {
                this.d_347_2Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public string D_81_3
        {
            get
            {
                return this.d_81_3Field;
            }
            set
            {
                this.d_81_3Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public X12_ID_355 D_355_4
        {
            get
            {
                return this.d_355_4Field;
            }
            set
            {
                this.d_355_4Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_355_4Specified
        {
            get
            {
                return this.d_355_4FieldSpecified;
            }
            set
            {
                this.d_355_4FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public string D_183_5
        {
            get
            {
                return this.d_183_5Field;
            }
            set
            {
                this.d_183_5Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public X12_ID_355 D_355_6
        {
            get
            {
                return this.d_355_6Field;
            }
            set
            {
                this.d_355_6Field = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool D_355_6Specified
        {
            get
            {
                return this.d_355_6FieldSpecified;
            }
            set
            {
                this.d_355_6FieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public string D_352_7
        {
            get
            {
                return this.d_352_7Field;
            }
            set
            {
                this.d_352_7Field = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.23514")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "customx12")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "customx12", IsNullable = false)]
    public partial class S_SE
    {

        private string d_96_1Field;

        private string d_329_2Field;

        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string D_96_1
        {
            get
            {
                return this.d_96_1Field;
            }
            set
            {
                this.d_96_1Field = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public string D_329_2
        {
            get
            {
                return this.d_329_2Field;
            }
            set
            {
                this.d_329_2Field = value;
            }
        }
    }
}
