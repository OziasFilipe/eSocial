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
namespace BibliotecaEsocial.Model.S1000
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true,
        Namespace = "http://www.esocial.gov.br/schema/evt/evtInfoEmpregador/v_S_01_00_00")]
    [System.Xml.Serialization.XmlRootAttribute(
        Namespace = "http://www.esocial.gov.br/schema/evt/evtInfoEmpregador/v_S_01_00_00", IsNullable = false)]
    public partial class eSocial
    {

        private eSocialEvtInfoEmpregador evtInfoEmpregadorField;

        /// <remarks/>
        public eSocialEvtInfoEmpregador evtInfoEmpregador
        {
            get { return this.evtInfoEmpregadorField; }
            set { this.evtInfoEmpregadorField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true,
        Namespace = "http://www.esocial.gov.br/schema/evt/evtInfoEmpregador/v_S_01_00_00")]
    public partial class eSocialEvtInfoEmpregador
    {

        private T_ideEvento_evtTab_inicial ideEventoField;

        private eSocialEvtInfoEmpregadorIdeEmpregador ideEmpregadorField;

        private eSocialEvtInfoEmpregadorInfoEmpregador infoEmpregadorField;

        private string idField;

        /// <remarks/>
        public T_ideEvento_evtTab_inicial ideEvento
        {
            get { return this.ideEventoField; }
            set { this.ideEventoField = value; }
        }

        /// <remarks/>
        public eSocialEvtInfoEmpregadorIdeEmpregador ideEmpregador
        {
            get { return this.ideEmpregadorField; }
            set { this.ideEmpregadorField = value; }
        }

        /// <remarks/>
        public eSocialEvtInfoEmpregadorInfoEmpregador infoEmpregador
        {
            get { return this.infoEmpregadorField; }
            set { this.infoEmpregadorField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get { return this.idField; }
            set { this.idField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace =
        "http://www.esocial.gov.br/schema/evt/evtInfoEmpregador/v_S_01_00_00")]
    public partial class T_ideEvento_evtTab_inicial
    {

        private sbyte tpAmbField;

        private sbyte procEmiField;

        private string verProcField;

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

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace =
        "http://www.esocial.gov.br/schema/evt/evtInfoEmpregador/v_S_01_00_00")]
    public partial class T_infoCadastro
    {

        private string classTribField;

        private sbyte indCoopField;

        private bool indCoopFieldSpecified;

        private sbyte indConstrField;

        private bool indConstrFieldSpecified;

        private sbyte indDesFolhaField;

        private sbyte indOpcCPField;

        private bool indOpcCPFieldSpecified;

        private T_infoCadastroIndPorte indPorteField;

        private bool indPorteFieldSpecified;

        private sbyte indOptRegEletronField;

        private string cnpjEFRField;

        private System.DateTime dtTrans11096Field;

        private bool dtTrans11096FieldSpecified;

        private T_infoCadastroDadosIsencao dadosIsencaoField;

        private T_infoCadastroInfoOrgInternacional infoOrgInternacionalField;

        /// <remarks/>
        public string classTrib
        {
            get { return this.classTribField; }
            set { this.classTribField = value; }
        }

        /// <remarks/>
        public sbyte indCoop
        {
            get { return this.indCoopField; }
            set { this.indCoopField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool indCoopSpecified
        {
            get { return this.indCoopFieldSpecified; }
            set { this.indCoopFieldSpecified = value; }
        }

        /// <remarks/>
        public sbyte indConstr
        {
            get { return this.indConstrField; }
            set { this.indConstrField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool indConstrSpecified
        {
            get { return this.indConstrFieldSpecified; }
            set { this.indConstrFieldSpecified = value; }
        }

        /// <remarks/>
        public sbyte indDesFolha
        {
            get { return this.indDesFolhaField; }
            set { this.indDesFolhaField = value; }
        }

        /// <remarks/>
        public sbyte indOpcCP
        {
            get { return this.indOpcCPField; }
            set { this.indOpcCPField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool indOpcCPSpecified
        {
            get { return this.indOpcCPFieldSpecified; }
            set { this.indOpcCPFieldSpecified = value; }
        }

        /// <remarks/>
        public T_infoCadastroIndPorte indPorte
        {
            get { return this.indPorteField; }
            set { this.indPorteField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool indPorteSpecified
        {
            get { return this.indPorteFieldSpecified; }
            set { this.indPorteFieldSpecified = value; }
        }

        /// <remarks/>
        public sbyte indOptRegEletron
        {
            get { return this.indOptRegEletronField; }
            set { this.indOptRegEletronField = value; }
        }

        /// <remarks/>
        public string cnpjEFR
        {
            get { return this.cnpjEFRField; }
            set { this.cnpjEFRField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime dtTrans11096
        {
            get { return this.dtTrans11096Field; }
            set { this.dtTrans11096Field = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dtTrans11096Specified
        {
            get { return this.dtTrans11096FieldSpecified; }
            set { this.dtTrans11096FieldSpecified = value; }
        }

        /// <remarks/>
        public T_infoCadastroDadosIsencao dadosIsencao
        {
            get { return this.dadosIsencaoField; }
            set { this.dadosIsencaoField = value; }
        }

        /// <remarks/>
        public T_infoCadastroInfoOrgInternacional infoOrgInternacional
        {
            get { return this.infoOrgInternacionalField; }
            set { this.infoOrgInternacionalField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true,
        Namespace = "http://www.esocial.gov.br/schema/evt/evtInfoEmpregador/v_S_01_00_00")]
    public enum T_infoCadastroIndPorte
    {

        /// <remarks/>
        S,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true,
        Namespace = "http://www.esocial.gov.br/schema/evt/evtInfoEmpregador/v_S_01_00_00")]
    public partial class T_infoCadastroDadosIsencao
    {

        private string ideMinLeiField;

        private string nrCertifField;

        private System.DateTime dtEmisCertifField;

        private System.DateTime dtVencCertifField;

        private string nrProtRenovField;

        private System.DateTime dtProtRenovField;

        private bool dtProtRenovFieldSpecified;

        private System.DateTime dtDouField;

        private bool dtDouFieldSpecified;

        private string pagDouField;

        /// <remarks/>
        public string ideMinLei
        {
            get { return this.ideMinLeiField; }
            set { this.ideMinLeiField = value; }
        }

        /// <remarks/>
        public string nrCertif
        {
            get { return this.nrCertifField; }
            set { this.nrCertifField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime dtEmisCertif
        {
            get { return this.dtEmisCertifField; }
            set { this.dtEmisCertifField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime dtVencCertif
        {
            get { return this.dtVencCertifField; }
            set { this.dtVencCertifField = value; }
        }

        /// <remarks/>
        public string nrProtRenov
        {
            get { return this.nrProtRenovField; }
            set { this.nrProtRenovField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime dtProtRenov
        {
            get { return this.dtProtRenovField; }
            set { this.dtProtRenovField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dtProtRenovSpecified
        {
            get { return this.dtProtRenovFieldSpecified; }
            set { this.dtProtRenovFieldSpecified = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime dtDou
        {
            get { return this.dtDouField; }
            set { this.dtDouField = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dtDouSpecified
        {
            get { return this.dtDouFieldSpecified; }
            set { this.dtDouFieldSpecified = value; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string pagDou
        {
            get { return this.pagDouField; }
            set { this.pagDouField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true,
        Namespace = "http://www.esocial.gov.br/schema/evt/evtInfoEmpregador/v_S_01_00_00")]
    public partial class T_infoCadastroInfoOrgInternacional
    {

        private sbyte indAcordoIsenMultaField;

        /// <remarks/>
        public sbyte indAcordoIsenMulta
        {
            get { return this.indAcordoIsenMultaField; }
            set { this.indAcordoIsenMultaField = value; }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace =
        "http://www.esocial.gov.br/schema/evt/evtInfoEmpregador/v_S_01_00_00")]
    public partial class T_idePeriodo
    {

        private string iniValidField;

        private string fimValidField;

        /// <remarks/>
        public string iniValid
        {
            get { return this.iniValidField; }
            set { this.iniValidField = value; }
        }

        /// <remarks/>
        public string fimValid
        {
            get { return this.fimValidField; }
            set { this.fimValidField = value; }
        }
    }

    public partial class T_novaValidade
    {

        private string iniValidField;

        private string fimValidField;

        /// <remarks/>
        public string iniValid
        {
            get
            {
                return this.iniValidField;
            }
            set
            {
                this.iniValidField = value;
            }
        }

        /// <remarks/>
        public string fimValid
        {
            get
            {
                return this.fimValidField;
            }
            set
            {
                this.fimValidField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true,
        Namespace = "http://www.esocial.gov.br/schema/evt/evtInfoEmpregador/v_S_01_00_00")]
    public partial class eSocialEvtInfoEmpregadorIdeEmpregador
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

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true,
        Namespace = "http://www.esocial.gov.br/schema/evt/evtInfoEmpregador/v_S_01_00_00")]
    public partial class eSocialEvtInfoEmpregadorInfoEmpregador
    {

        private object itemField;
        private object Alteracao;
        private object Exclusao;
        private object Inclusao;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("myAlteracao",
            typeof(eSocialEvtInfoEmpregadorInfoEmpregadorAlteracao))]
        [System.Xml.Serialization.XmlElementAttribute("myExclusao",
            typeof(eSocialEvtInfoEmpregadorInfoEmpregadorExclusao))]
        [System.Xml.Serialization.XmlElementAttribute("myInclusao",
            typeof(eSocialEvtInfoEmpregadorInfoEmpregadorInclusao))]
        public object Item
        {
            get { return this.itemField; }
            set { this.itemField = value; }
        }
        public object alteracao
        {
            get { return this.Alteracao; }
            set { this.Alteracao = value; }
        }
        public object exclusao
        {
            get { return this.Exclusao; }
            set { this.Exclusao = value; }
        }
        public object inclusao
        {
            get { return this.Inclusao; }
            set { this.Inclusao = value; }
        }
    }

    /// <remarks/>

    public partial class eSocialEvtInfoEmpregadorInfoEmpregadorAlteracao
    {

        private T_idePeriodo idePeriodoField;

        private T_infoCadastro infoCadastroField;

        private T_novaValidade novaValidadeField;

        /// <remarks/>
        public T_idePeriodo idePeriodo
        {
            get { return this.idePeriodoField; }
            set { this.idePeriodoField = value; }
        }

        /// <remarks/>
        public T_infoCadastro infoCadastro
        {
            get { return this.infoCadastroField; }
            set { this.infoCadastroField = value; }
        }

        /// <remarks/>
        public T_novaValidade novaValidade
        {
            get { return this.novaValidadeField; }
            set { this.novaValidadeField = value; }
        }
    }

    /// <remarks/>
 
    public partial class eSocialEvtInfoEmpregadorInfoEmpregadorExclusao
    {

        private T_idePeriodo idePeriodoField;

        /// <remarks/>
        public T_idePeriodo idePeriodo
        {
            get { return this.idePeriodoField; }
            set { this.idePeriodoField = value; }
        }
    }

    /// <remarks/>
    
    public partial class eSocialEvtInfoEmpregadorInfoEmpregadorInclusao
    {

        private T_idePeriodo idePeriodoField;

        private T_infoCadastro infoCadastroField;

        /// <remarks/>
        public T_idePeriodo idePeriodo
        {
            get { return this.idePeriodoField; }
            set { this.idePeriodoField = value; }
        }

        /// <remarks/>
        public T_infoCadastro infoCadastro
        {
            get { return this.infoCadastroField; }
            set { this.infoCadastroField = value; }
        }
    }
}