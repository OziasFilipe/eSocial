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
// This source code was auto-generated by xsd, Version=4.8.9037.0.
// 
namespace BibliotecaEsocial.Model.S2501
{ 



/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.esocial.gov.br/schema/evt/evtContProc/v_S_01_01_00")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.esocial.gov.br/schema/evt/evtContProc/v_S_01_01_00", IsNullable=false)]
public partial class eSocial {
    
    private eSocialEvtContProc evtContProcField;
    
    /// <remarks/>
    public eSocialEvtContProc evtContProc {
        get {
            return this.evtContProcField;
        }
        set {
            this.evtContProcField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.esocial.gov.br/schema/evt/evtContProc/v_S_01_01_00")]
public partial class eSocialEvtContProc {
    
    private T_ideEvento_trab ideEventoField;
    
    private eSocialEvtContProcIdeEmpregador ideEmpregadorField;
    
    private eSocialEvtContProcIdeProc ideProcField;
    
    private eSocialEvtContProcIdeTrab[] ideTrabField;
    
    private string idField;
    
    /// <remarks/>
    public T_ideEvento_trab ideEvento {
        get {
            return this.ideEventoField;
        }
        set {
            this.ideEventoField = value;
        }
    }
    
    /// <remarks/>
    public eSocialEvtContProcIdeEmpregador ideEmpregador {
        get {
            return this.ideEmpregadorField;
        }
        set {
            this.ideEmpregadorField = value;
        }
    }
    
    /// <remarks/>
    public eSocialEvtContProcIdeProc ideProc {
        get {
            return this.ideProcField;
        }
        set {
            this.ideProcField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ideTrab")]
    public eSocialEvtContProcIdeTrab[] ideTrab {
        get {
            return this.ideTrabField;
        }
        set {
            this.ideTrabField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
    public string Id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.esocial.gov.br/schema/evt/evtContProc/v_S_01_01_00")]
public partial class T_ideEvento_trab {
    
    private sbyte indRetifField;
    
    private string nrReciboField;
    
    private sbyte tpAmbField;
    
    private sbyte procEmiField;
    
    private string verProcField;
    
    /// <remarks/>
    public sbyte indRetif {
        get {
            return this.indRetifField;
        }
        set {
            this.indRetifField = value;
        }
    }
    
    /// <remarks/>
    public string nrRecibo {
        get {
            return this.nrReciboField;
        }
        set {
            this.nrReciboField = value;
        }
    }
    
    /// <remarks/>
    public sbyte tpAmb {
        get {
            return this.tpAmbField;
        }
        set {
            this.tpAmbField = value;
        }
    }
    
    /// <remarks/>
    public sbyte procEmi {
        get {
            return this.procEmiField;
        }
        set {
            this.procEmiField = value;
        }
    }
    
    /// <remarks/>
    public string verProc {
        get {
            return this.verProcField;
        }
        set {
            this.verProcField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.esocial.gov.br/schema/evt/evtContProc/v_S_01_01_00")]
public partial class eSocialEvtContProcIdeEmpregador {
    
    private sbyte tpInscField;
    
    private string nrInscField;
    
    /// <remarks/>
    public sbyte tpInsc {
        get {
            return this.tpInscField;
        }
        set {
            this.tpInscField = value;
        }
    }
    
    /// <remarks/>
    public string nrInsc {
        get {
            return this.nrInscField;
        }
        set {
            this.nrInscField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.esocial.gov.br/schema/evt/evtContProc/v_S_01_01_00")]
public partial class eSocialEvtContProcIdeProc {
    
    private string nrProcTrabField;
    
    private string perApurPgtoField;
    
    private string obsField;
    
    /// <remarks/>
    public string nrProcTrab {
        get {
            return this.nrProcTrabField;
        }
        set {
            this.nrProcTrabField = value;
        }
    }
    
    /// <remarks/>
    public string perApurPgto {
        get {
            return this.perApurPgtoField;
        }
        set {
            this.perApurPgtoField = value;
        }
    }
    
    /// <remarks/>
    public string obs {
        get {
            return this.obsField;
        }
        set {
            this.obsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.esocial.gov.br/schema/evt/evtContProc/v_S_01_01_00")]
public partial class eSocialEvtContProcIdeTrab {
    
    private eSocialEvtContProcIdeTrabCalcTrib[] calcTribField;
    
    private eSocialEvtContProcIdeTrabInfoCRIRRF[] infoCRIRRFField;
    
    private string cpfTrabField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("calcTrib")]
    public eSocialEvtContProcIdeTrabCalcTrib[] calcTrib {
        get {
            return this.calcTribField;
        }
        set {
            this.calcTribField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("infoCRIRRF")]
    public eSocialEvtContProcIdeTrabInfoCRIRRF[] infoCRIRRF {
        get {
            return this.infoCRIRRFField;
        }
        set {
            this.infoCRIRRFField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string cpfTrab {
        get {
            return this.cpfTrabField;
        }
        set {
            this.cpfTrabField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.esocial.gov.br/schema/evt/evtContProc/v_S_01_01_00")]
public partial class eSocialEvtContProcIdeTrabCalcTrib {
    
    private eSocialEvtContProcIdeTrabCalcTribInfoCRContrib[] infoCRContribField;
    
    private string perRefField;
    
    private decimal vrBcCpMensalField;
    
    private decimal vrBcCp13Field;
    
    private decimal vrRendIRRFField;
    
    private decimal vrRendIRRF13Field;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("infoCRContrib")]
    public eSocialEvtContProcIdeTrabCalcTribInfoCRContrib[] infoCRContrib {
        get {
            return this.infoCRContribField;
        }
        set {
            this.infoCRContribField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string perRef {
        get {
            return this.perRefField;
        }
        set {
            this.perRefField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal vrBcCpMensal {
        get {
            return this.vrBcCpMensalField;
        }
        set {
            this.vrBcCpMensalField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal vrBcCp13 {
        get {
            return this.vrBcCp13Field;
        }
        set {
            this.vrBcCp13Field = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal vrRendIRRF {
        get {
            return this.vrRendIRRFField;
        }
        set {
            this.vrRendIRRFField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal vrRendIRRF13 {
        get {
            return this.vrRendIRRF13Field;
        }
        set {
            this.vrRendIRRF13Field = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.esocial.gov.br/schema/evt/evtContProc/v_S_01_01_00")]
public partial class eSocialEvtContProcIdeTrabCalcTribInfoCRContrib {
    
    private string tpCRField;
    
    private decimal vrCRField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string tpCR {
        get {
            return this.tpCRField;
        }
        set {
            this.tpCRField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal vrCR {
        get {
            return this.vrCRField;
        }
        set {
            this.vrCRField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.esocial.gov.br/schema/evt/evtContProc/v_S_01_01_00")]
public partial class eSocialEvtContProcIdeTrabInfoCRIRRF {
    
    private eSocialEvtContProcIdeTrabInfoCRIRRFTpCR tpCRField;
    
    private decimal vrCRField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public eSocialEvtContProcIdeTrabInfoCRIRRFTpCR tpCR {
        get {
            return this.tpCRField;
        }
        set {
            this.tpCRField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal vrCR {
        get {
            return this.vrCRField;
        }
        set {
            this.vrCRField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.esocial.gov.br/schema/evt/evtContProc/v_S_01_01_00")]
public enum eSocialEvtContProcIdeTrabInfoCRIRRFTpCR {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("593656")]
    Item593656,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("188951")]
    Item188951,
}
}