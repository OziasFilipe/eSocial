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

namespace BibliotecaEsocial.Model.S5501 
{
/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.esocial.gov.br/schema/evt/evtTribProcTrab/v_S_01_01_00")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.esocial.gov.br/schema/evt/evtTribProcTrab/v_S_01_01_00", IsNullable=false)]
public partial class eSocial {
    
    private eSocialEvtTribProcTrab evtTribProcTrabField;
    
    /// <remarks/>
    public eSocialEvtTribProcTrab evtTribProcTrab {
        get {
            return this.evtTribProcTrabField;
        }
        set {
            this.evtTribProcTrabField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.esocial.gov.br/schema/evt/evtTribProcTrab/v_S_01_01_00")]
public partial class eSocialEvtTribProcTrab {
    
    private eSocialEvtTribProcTrabIdeEvento ideEventoField;
    
    private eSocialEvtTribProcTrabIdeEmpregador ideEmpregadorField;
    
    private eSocialEvtTribProcTrabIdeProc ideProcField;
    
    private string idField;
    
    /// <remarks/>
    public eSocialEvtTribProcTrabIdeEvento ideEvento {
        get {
            return this.ideEventoField;
        }
        set {
            this.ideEventoField = value;
        }
    }
    
    /// <remarks/>
    public eSocialEvtTribProcTrabIdeEmpregador ideEmpregador {
        get {
            return this.ideEmpregadorField;
        }
        set {
            this.ideEmpregadorField = value;
        }
    }
    
    /// <remarks/>
    public eSocialEvtTribProcTrabIdeProc ideProc {
        get {
            return this.ideProcField;
        }
        set {
            this.ideProcField = value;
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
public partial class eSocialEvtTribProcTrabIdeEvento {
    
    private string nrRecArqBaseField;
    
    /// <remarks/>
    public string nrRecArqBase {
        get {
            return this.nrRecArqBaseField;
        }
        set {
            this.nrRecArqBaseField = value;
        }
    }
}

/// <remarks/>
public partial class eSocialEvtTribProcTrabIdeEmpregador {
    
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
public partial class eSocialEvtTribProcTrabIdeProc {
    
    private string nrProcTrabField;
    
    private string perApurField;
    
    private eSocialEvtTribProcTrabIdeProcInfoTributos[] infoTributosField;
    
    private eSocialEvtTribProcTrabIdeProcInfoCRIRRF[] infoCRIRRFField;
    
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
    public string perApur {
        get {
            return this.perApurField;
        }
        set {
            this.perApurField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("infoTributos")]
    public eSocialEvtTribProcTrabIdeProcInfoTributos[] infoTributos {
        get {
            return this.infoTributosField;
        }
        set {
            this.infoTributosField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("infoCRIRRF")]
    public eSocialEvtTribProcTrabIdeProcInfoCRIRRF[] infoCRIRRF {
        get {
            return this.infoCRIRRFField;
        }
        set {
            this.infoCRIRRFField = value;
        }
    }
}

/// <remarks/>
public partial class eSocialEvtTribProcTrabIdeProcInfoTributos {
    
    private string perRefField;
    
    private eSocialEvtTribProcTrabIdeProcInfoTributosInfoCRContrib[] infoCRContribField;
    
    /// <remarks/>
    public string perRef {
        get {
            return this.perRefField;
        }
        set {
            this.perRefField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("infoCRContrib")]
    public eSocialEvtTribProcTrabIdeProcInfoTributosInfoCRContrib[] infoCRContrib {
        get {
            return this.infoCRContribField;
        }
        set {
            this.infoCRContribField = value;
        }
    }
}

/// <remarks/>
public partial class eSocialEvtTribProcTrabIdeProcInfoTributosInfoCRContrib {
    
    private string tpCRField;
    
    private decimal vrCRField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string tpCR {
        get {
            return this.tpCRField;
        }
        set {
            this.tpCRField = value;
        }
    }
    
    /// <remarks/>
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
public partial class eSocialEvtTribProcTrabIdeProcInfoCRIRRF {
    
    private string tpCRField;
    
    private decimal vrCRField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string tpCR {
        get {
            return this.tpCRField;
        }
        set {
            this.tpCRField = value;
        }
    }
    
    /// <remarks/>
    public decimal vrCR {
        get {
            return this.vrCRField;
        }
        set {
            this.vrCRField = value;
        }
    }
}
}