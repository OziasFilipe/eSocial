﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.6.1055.0.
// 
namespace BibliotecaEsocial.Model.S5002
{


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true,
        Namespace = "http://www.esocial.gov.br/schema/evt/evtIrrfBenef/v_S_01_00_00")]
    [System.Xml.Serialization.XmlRootAttribute(
        Namespace = "http://www.esocial.gov.br/schema/evt/evtIrrfBenef/v_S_01_00_00", IsNullable = false)]
    public partial class eSocial
    {
        private eSocialEvtIrrfBenef evtIrrfBenefField;
        /// <remarks/>
        public eSocialEvtIrrfBenef evtIrrfBenef
        {
            get { return this.evtIrrfBenefField; }
            set { this.evtIrrfBenefField = value; }
        }
       
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true,
        Namespace = "http://www.esocial.gov.br/schema/evt/evtIrrfBenef/v_S_01_00_00")]
    public partial class eSocialEvtIrrfBenef
    {

        private eSocialEvtIrrfBenefIdeEvento ideEventoField;

        private T_ideEmpregador ideEmpregadorField;

        private eSocialEvtIrrfBenefIdeTrabalhador ideTrabalhadorField;

        private string idField;

        /// <remarks/>
        public eSocialEvtIrrfBenefIdeEvento ideEvento
        {
            get { return this.ideEventoField; }
            set { this.ideEventoField = value; }
        }

        /// <remarks/>
        public T_ideEmpregador ideEmpregador
        {
            get { return this.ideEmpregadorField; }
            set { this.ideEmpregadorField = value; }
        }

        /// <remarks/>
        public eSocialEvtIrrfBenefIdeTrabalhador ideTrabalhador
        {
            get { return this.ideTrabalhadorField; }
            set { this.ideTrabalhadorField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get { return this.idField; }
            set { this.idField = value; }
        }
    }


    public partial class eSocialEvtIrrfBenefIdeEvento
    {

        private string nrRecArqBaseField;

        private string perApurField;

        /// <remarks/>
        public string nrRecArqBase
        {
            get { return this.nrRecArqBaseField; }
            set { this.nrRecArqBaseField = value; }
        }

        /// <remarks/>
        public string perApur
        {
            get { return this.perApurField; }
            set { this.perApurField = value; }
        }
    }


    public partial class T_ideEmpregador
    {

        private sbyte tpInscField;

        private string nrInscField;

        /// <remarks/>
        public sbyte tpInsc
        {
            get { return this.tpInscField; }
            set { this.tpInscField = value; }
        }

        /// <remarks/>
        public string nrInsc
        {
            get { return this.nrInscField; }
            set { this.nrInscField = value; }
        }
    }


    public partial class eSocialEvtIrrfBenefIdeTrabalhador
    {

        private string cpfBenefField;

        private eSocialEvtIrrfBenefIdeTrabalhadorDmDev[] dmDevField;

        /// <remarks/>
        public string cpfBenef
        {
            get { return this.cpfBenefField; }
            set { this.cpfBenefField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("dmDev")]
        public eSocialEvtIrrfBenefIdeTrabalhadorDmDev[] dmDev
        {
            get { return this.dmDevField; }
            set { this.dmDevField = value; }
        }
    }


    public partial class eSocialEvtIrrfBenefIdeTrabalhadorDmDev
    {

        private string perRefField;

        private string ideDmDevField;

        private sbyte tpPgtoField;

        private System.DateTime dtPgtoField;

        private string codCategField;

        private eSocialEvtIrrfBenefIdeTrabalhadorDmDevInfoIR[] infoIRField;

        private eSocialEvtIrrfBenefIdeTrabalhadorDmDevTotApurMen[] totApurMenField;

        private eSocialEvtIrrfBenefIdeTrabalhadorDmDevTotApurDia[] totApurDiaField;

        /// <remarks/>
        public string perRef
        {
            get { return this.perRefField; }
            set { this.perRefField = value; }
        }

        /// <remarks/>
        public string ideDmDev
        {
            get { return this.ideDmDevField; }
            set { this.ideDmDevField = value; }
        }

        /// <remarks/>
        public sbyte tpPgto
        {
            get { return this.tpPgtoField; }
            set { this.tpPgtoField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime dtPgto
        {
            get { return this.dtPgtoField; }
            set { this.dtPgtoField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string codCateg
        {
            get { return this.codCategField; }
            set { this.codCategField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("infoIR")]
        public eSocialEvtIrrfBenefIdeTrabalhadorDmDevInfoIR[] infoIR
        {
            get { return this.infoIRField; }
            set { this.infoIRField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("totApurMen")]
        public eSocialEvtIrrfBenefIdeTrabalhadorDmDevTotApurMen[] totApurMen
        {
            get { return this.totApurMenField; }
            set { this.totApurMenField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("totApurDia")]
        public eSocialEvtIrrfBenefIdeTrabalhadorDmDevTotApurDia[] totApurDia
        {
            get { return this.totApurDiaField; }
            set { this.totApurDiaField = value; }
        }
    }


    public partial class eSocialEvtIrrfBenefIdeTrabalhadorDmDevInfoIR
    {

        private eSocialEvtIrrfBenefIdeTrabalhadorDmDevInfoIRTpInfoIR tpInfoIRField;

        private decimal valorField;

        /// <remarks/>
        public eSocialEvtIrrfBenefIdeTrabalhadorDmDevInfoIRTpInfoIR tpInfoIR
        {
            get { return this.tpInfoIRField; }
            set { this.tpInfoIRField = value; }
        }

        /// <remarks/>
        public decimal valor
        {
            get { return this.valorField; }
            set { this.valorField = value; }
        }
    }


    public enum eSocialEvtIrrfBenefIdeTrabalhadorDmDevInfoIRTpInfoIR
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("11")]
        Item11,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12")]
        Item12,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("14")]
        Item14,

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
        [System.Xml.Serialization.XmlEnumAttribute("41")]
        Item41,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("42")]
        Item42,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("46")]
        Item46,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("47")]
        Item47,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("51")]
        Item51,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("52")]
        Item52,

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
        [System.Xml.Serialization.XmlEnumAttribute("67")]
        Item67,

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
        [System.Xml.Serialization.XmlEnumAttribute("700")]
        Item700,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("701")]
        Item701,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("79")]
        Item79,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7900")]
        Item7900,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7950")]
        Item7950,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7951")]
        Item7951,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7952")]
        Item7952,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7953")]
        Item7953,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7954")]
        Item7954,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7955")]
        Item7955,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7956")]
        Item7956,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7957")]
        Item7957,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7958")]
        Item7958,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7959")]
        Item7959,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7960")]
        Item7960,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7961")]
        Item7961,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7962")]
        Item7962,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7963")]
        Item7963,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7964")]
        Item7964,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9011")]
        Item9011,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9012")]
        Item9012,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9014")]
        Item9014,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9031")]
        Item9031,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9032")]
        Item9032,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9034")]
        Item9034,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9831")]
        Item9831,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9832")]
        Item9832,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9834")]
        Item9834,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9041")]
        Item9041,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9042")]
        Item9042,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9046")]
        Item9046,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9047")]
        Item9047,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9051")]
        Item9051,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9052")]
        Item9052,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9054")]
        Item9054,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9061")]
        Item9061,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9062")]
        Item9062,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9063")]
        Item9063,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9064")]
        Item9064,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9067")]
        Item9067,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9082")]
        Item9082,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9083")]
        Item9083,
    }


    public partial class eSocialEvtIrrfBenefIdeTrabalhadorDmDevTotApurMen
    {

        private TS_CRMen cRMenField;

        private decimal vlrCRMenField;

        private decimal vlrCRMenSuspField;

        private bool vlrCRMenSuspFieldSpecified;

        /// <remarks/>
        public TS_CRMen CRMen
        {
            get { return this.cRMenField; }
            set { this.cRMenField = value; }
        }

        /// <remarks/>
        public decimal vlrCRMen
        {
            get { return this.vlrCRMenField; }
            set { this.vlrCRMenField = value; }
        }

        /// <remarks/>
        public decimal vlrCRMenSusp
        {
            get { return this.vlrCRMenSuspField; }
            set { this.vlrCRMenSuspField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool vlrCRMenSuspSpecified
        {
            get { return this.vlrCRMenSuspFieldSpecified; }
            set { this.vlrCRMenSuspFieldSpecified = value; }
        }
    }


    public enum TS_CRMen
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("056107")]
        Item056107,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("056108")]
        Item056108,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("056109")]
        Item056109,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("056110")]
        Item056110,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("056111")]
        Item056111,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("056112")]
        Item056112,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("056113")]
        Item056113,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("058806")]
        Item058806,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("061001")]
        Item061001,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("353301")]
        Item353301,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("356201")]
        Item356201,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("188901")]
        Item188901,
    }


    public partial class eSocialEvtIrrfBenefIdeTrabalhadorDmDevTotApurDia
    {

        private sbyte perApurDiaField;

        private TS_CRDia cRDiaField;

        private decimal vlrCRDiaField;

        private decimal vlrCRDiaSuspField;

        private bool vlrCRDiaSuspFieldSpecified;

        /// <remarks/>
        public sbyte perApurDia
        {
            get { return this.perApurDiaField; }
            set { this.perApurDiaField = value; }
        }

        /// <remarks/>
        public TS_CRDia CRDia
        {
            get { return this.cRDiaField; }
            set { this.cRDiaField = value; }
        }

        /// <remarks/>
        public decimal vlrCRDia
        {
            get { return this.vlrCRDiaField; }
            set { this.vlrCRDiaField = value; }
        }

        /// <remarks/>
        public decimal vlrCRDiaSusp
        {
            get { return this.vlrCRDiaSuspField; }
            set { this.vlrCRDiaSuspField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool vlrCRDiaSuspSpecified
        {
            get { return this.vlrCRDiaSuspFieldSpecified; }
            set { this.vlrCRDiaSuspFieldSpecified = value; }
        }
    }


    public enum TS_CRDia
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("047301")]
        Item047301,
    }
}