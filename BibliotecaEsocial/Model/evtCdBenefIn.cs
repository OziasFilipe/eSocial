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
// This source code was auto-generated by xsd, Version=4.8.3928.0.
// 
namespace BibliotecaEsocial.Model.S2400
{


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true,
        Namespace = "http://www.esocial.gov.br/schema/evt/evtCdBenefIn/v_S_01_00_00")]
    [System.Xml.Serialization.XmlRootAttribute(
        Namespace = "http://www.esocial.gov.br/schema/evt/evtCdBenefIn/v_S_01_00_00", IsNullable = false)]
    public partial class eSocial
    {

        private eSocialEvtCdBenefIn evtCdBenefInField;

        /// <remarks/>
        public eSocialEvtCdBenefIn evtCdBenefIn
        {
            get { return this.evtCdBenefInField; }
            set { this.evtCdBenefInField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true,
        Namespace = "http://www.esocial.gov.br/schema/evt/evtCdBenefIn/v_S_01_00_00")]
    public partial class eSocialEvtCdBenefIn
    {

        private T_ideEvento_trab_PJ ideEventoField;

        private eSocialEvtCdBenefInIdeEmpregador ideEmpregadorField;

        private eSocialEvtCdBenefInBeneficiario beneficiarioField;

        private string idField;

        /// <remarks/>
        public T_ideEvento_trab_PJ ideEvento
        {
            get { return this.ideEventoField; }
            set { this.ideEventoField = value; }
        }

        /// <remarks/>
        public eSocialEvtCdBenefInIdeEmpregador ideEmpregador
        {
            get { return this.ideEmpregadorField; }
            set { this.ideEmpregadorField = value; }
        }

        /// <remarks/>
        public eSocialEvtCdBenefInBeneficiario beneficiario
        {
            get { return this.beneficiarioField; }
            set { this.beneficiarioField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get { return this.idField; }
            set { this.idField = value; }
        }
    }


    public partial class T_ideEvento_trab_PJ
    {

        private sbyte indRetifField;

        private string nrReciboField;

        private sbyte tpAmbField;

        private sbyte procEmiField;

        private string verProcField;

        /// <remarks/>
        public sbyte indRetif
        {
            get { return this.indRetifField; }
            set { this.indRetifField = value; }
        }

        /// <remarks/>
        public string nrRecibo
        {
            get { return this.nrReciboField; }
            set { this.nrReciboField = value; }
        }

        /// <remarks/>
        public sbyte tpAmb
        {
            get { return this.tpAmbField; }
            set { this.tpAmbField = value; }
        }

        /// <remarks/>
        public sbyte procEmi
        {
            get { return this.procEmiField; }
            set { this.procEmiField = value; }
        }

        /// <remarks/>
        public string verProc
        {
            get { return this.verProcField; }
            set { this.verProcField = value; }
        }
    }


    public partial class T_endereco_exterior
    {

        private string paisResidField;

        private string dscLogradField;

        private string nrLogradField;

        private string complementoField;

        private string bairroField;

        private string nmCidField;

        private string codPostalField;

        /// <remarks/>
        public string paisResid
        {
            get { return this.paisResidField; }
            set { this.paisResidField = value; }
        }

        /// <remarks/>
        public string dscLograd
        {
            get { return this.dscLogradField; }
            set { this.dscLogradField = value; }
        }

        /// <remarks/>
        public string nrLograd
        {
            get { return this.nrLogradField; }
            set { this.nrLogradField = value; }
        }

        /// <remarks/>
        public string complemento
        {
            get { return this.complementoField; }
            set { this.complementoField = value; }
        }

        /// <remarks/>
        public string bairro
        {
            get { return this.bairroField; }
            set { this.bairroField = value; }
        }

        /// <remarks/>
        public string nmCid
        {
            get { return this.nmCidField; }
            set { this.nmCidField = value; }
        }

        /// <remarks/>
        public string codPostal
        {
            get { return this.codPostalField; }
            set { this.codPostalField = value; }
        }
    }


    public partial class T_endereco_brasil
    {

        private string tpLogradField;

        private string dscLogradField;

        private string nrLogradField;

        private string complementoField;

        private string bairroField;

        private string cepField;

        private string codMunicField;

        private TS_uf ufField;

        /// <remarks/>
        public string tpLograd
        {
            get { return this.tpLogradField; }
            set { this.tpLogradField = value; }
        }

        /// <remarks/>
        public string dscLograd
        {
            get { return this.dscLogradField; }
            set { this.dscLogradField = value; }
        }

        /// <remarks/>
        public string nrLograd
        {
            get { return this.nrLogradField; }
            set { this.nrLogradField = value; }
        }

        /// <remarks/>
        public string complemento
        {
            get { return this.complementoField; }
            set { this.complementoField = value; }
        }

        /// <remarks/>
        public string bairro
        {
            get { return this.bairroField; }
            set { this.bairroField = value; }
        }

        /// <remarks/>
        public string cep
        {
            get { return this.cepField; }
            set { this.cepField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string codMunic
        {
            get { return this.codMunicField; }
            set { this.codMunicField = value; }
        }

        /// <remarks/>
        public TS_uf uf
        {
            get { return this.ufField; }
            set { this.ufField = value; }
        }
    }


    public enum TS_uf
    {

        /// <remarks/>
        AC,

        /// <remarks/>
        AL,

        /// <remarks/>
        AP,

        /// <remarks/>
        AM,

        /// <remarks/>
        BA,

        /// <remarks/>
        CE,

        /// <remarks/>
        DF,

        /// <remarks/>
        ES,

        /// <remarks/>
        GO,

        /// <remarks/>
        MA,

        /// <remarks/>
        MT,

        /// <remarks/>
        MS,

        /// <remarks/>
        MG,

        /// <remarks/>
        PA,

        /// <remarks/>
        PB,

        /// <remarks/>
        PR,

        /// <remarks/>
        PE,

        /// <remarks/>
        PI,

        /// <remarks/>
        RJ,

        /// <remarks/>
        RN,

        /// <remarks/>
        RS,

        /// <remarks/>
        RO,

        /// <remarks/>
        RR,

        /// <remarks/>
        SC,

        /// <remarks/>
        SP,

        /// <remarks/>
        SE,

        /// <remarks/>
        TO,
    }


    public partial class eSocialEvtCdBenefInIdeEmpregador
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


    public partial class eSocialEvtCdBenefInBeneficiario
    {

        private string cpfBenefField;

        private string nmBeneficField;

        private System.DateTime dtNasctoField;

        private System.DateTime dtInicioField;

        private TS_sexo sexoField;

        private bool sexoFieldSpecified;

        private sbyte racaCorField;

        private sbyte estCivField;

        private bool estCivFieldSpecified;

        private TS_incFisMen incFisMenField;

        private System.DateTime dtIncFisMenField;

        private bool dtIncFisMenFieldSpecified;

        private eSocialEvtCdBenefInBeneficiarioEndereco enderecoField;

        private eSocialEvtCdBenefInBeneficiarioDependente[] dependenteField;

        /// <remarks/>
        public string cpfBenef
        {
            get { return this.cpfBenefField; }
            set { this.cpfBenefField = value; }
        }

        /// <remarks/>
        public string nmBenefic
        {
            get { return this.nmBeneficField; }
            set { this.nmBeneficField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime dtNascto
        {
            get { return this.dtNasctoField; }
            set { this.dtNasctoField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime dtInicio
        {
            get { return this.dtInicioField; }
            set { this.dtInicioField = value; }
        }

        /// <remarks/>
        public TS_sexo sexo
        {
            get { return this.sexoField; }
            set { this.sexoField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool sexoSpecified
        {
            get { return this.sexoFieldSpecified; }
            set { this.sexoFieldSpecified = value; }
        }

        /// <remarks/>
        public sbyte racaCor
        {
            get { return this.racaCorField; }
            set { this.racaCorField = value; }
        }

        /// <remarks/>
        public sbyte estCiv
        {
            get { return this.estCivField; }
            set { this.estCivField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool estCivSpecified
        {
            get { return this.estCivFieldSpecified; }
            set { this.estCivFieldSpecified = value; }
        }

        /// <remarks/>
        public TS_incFisMen incFisMen
        {
            get { return this.incFisMenField; }
            set { this.incFisMenField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime dtIncFisMen
        {
            get { return this.dtIncFisMenField; }
            set { this.dtIncFisMenField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dtIncFisMenSpecified
        {
            get { return this.dtIncFisMenFieldSpecified; }
            set { this.dtIncFisMenFieldSpecified = value; }
        }

        /// <remarks/>
        public eSocialEvtCdBenefInBeneficiarioEndereco endereco
        {
            get { return this.enderecoField; }
            set { this.enderecoField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("dependente")]
        public eSocialEvtCdBenefInBeneficiarioDependente[] dependente
        {
            get { return this.dependenteField; }
            set { this.dependenteField = value; }
        }
    }


    public enum TS_sexo
    {

        /// <remarks/>
        M,

        /// <remarks/>
        F,
    }


    public enum TS_incFisMen
    {

        /// <remarks/>
        S,

        /// <remarks/>
        N,
    }


    public partial class eSocialEvtCdBenefInBeneficiarioEndereco
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("brasil", typeof(T_endereco_brasil))]
        [System.Xml.Serialization.XmlElementAttribute("exterior", typeof(T_endereco_exterior))]
        public object Item
        {
            get { return this.itemField; }
            set { this.itemField = value; }
        }
    }


    public partial class eSocialEvtCdBenefInBeneficiarioDependente
    {

        private string tpDepField;

        private string nmDepField;

        private System.DateTime dtNasctoField;

        private string cpfDepField;

        private TS_sexo sexoDepField;

        private bool sexoDepFieldSpecified;

        private TS_incFisMen depIRRFField;

        private TS_incFisMen incFisMenField;

        /// <remarks/>
        public string tpDep
        {
            get { return this.tpDepField; }
            set { this.tpDepField = value; }
        }

        /// <remarks/>
        public string nmDep
        {
            get { return this.nmDepField; }
            set { this.nmDepField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime dtNascto
        {
            get { return this.dtNasctoField; }
            set { this.dtNasctoField = value; }
        }

        /// <remarks/>
        public string cpfDep
        {
            get { return this.cpfDepField; }
            set { this.cpfDepField = value; }
        }

        /// <remarks/>
        public TS_sexo sexoDep
        {
            get { return this.sexoDepField; }
            set { this.sexoDepField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool sexoDepSpecified
        {
            get { return this.sexoDepFieldSpecified; }
            set { this.sexoDepFieldSpecified = value; }
        }

        /// <remarks/>
        public TS_incFisMen depIRRF
        {
            get { return this.depIRRFField; }
            set { this.depIRRFField = value; }
        }

        /// <remarks/>
        public TS_incFisMen incFisMen
        {
            get { return this.incFisMenField; }
            set { this.incFisMenField = value; }
        }
    }
}