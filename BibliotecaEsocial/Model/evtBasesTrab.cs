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

namespace BibliotecaEsocial.Model.S5001
{
    /// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.esocial.gov.br/schema/evt/evtBasesTrab/v_S_01_00_00")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.esocial.gov.br/schema/evt/evtBasesTrab/v_S_01_00_00", IsNullable=false)]
public partial class eSocial {
    
    private eSocialEvtBasesTrab evtBasesTrabField;
    
    /// <remarks/>
    public eSocialEvtBasesTrab evtBasesTrab {
        get {
            return this.evtBasesTrabField;
        }
        set {
            this.evtBasesTrabField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.esocial.gov.br/schema/evt/evtBasesTrab/v_S_01_00_00")]
public partial class eSocialEvtBasesTrab {
    
    private T_ideEvento_retorno_trab ideEventoField;
    
    private T_ideEmpregador ideEmpregadorField;
    
    private eSocialEvtBasesTrabIdeTrabalhador ideTrabalhadorField;
    
    private eSocialEvtBasesTrabInfoCpCalc[] infoCpCalcField;
    
    private eSocialEvtBasesTrabInfoCp infoCpField;
    
    private string idField;
    
    /// <remarks/>
    public T_ideEvento_retorno_trab ideEvento {
        get {
            return this.ideEventoField;
        }
        set {
            this.ideEventoField = value;
        }
    }
    
    /// <remarks/>
    public T_ideEmpregador ideEmpregador {
        get {
            return this.ideEmpregadorField;
        }
        set {
            this.ideEmpregadorField = value;
        }
    }
    
    /// <remarks/>
    public eSocialEvtBasesTrabIdeTrabalhador ideTrabalhador {
        get {
            return this.ideTrabalhadorField;
        }
        set {
            this.ideTrabalhadorField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("infoCpCalc")]
    public eSocialEvtBasesTrabInfoCpCalc[] infoCpCalc {
        get {
            return this.infoCpCalcField;
        }
        set {
            this.infoCpCalcField = value;
        }
    }
    
    /// <remarks/>
    public eSocialEvtBasesTrabInfoCp infoCp {
        get {
            return this.infoCpField;
        }
        set {
            this.infoCpField = value;
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


public partial class T_ideEvento_retorno_trab {
    
    private string nrRecArqBaseField;
    
    private sbyte indApuracaoField;
    
    private string perApurField;
    
    /// <remarks/>
    public string nrRecArqBase {
        get {
            return this.nrRecArqBaseField;
        }
        set {
            this.nrRecArqBaseField = value;
        }
    }
    
    /// <remarks/>
    public sbyte indApuracao {
        get {
            return this.indApuracaoField;
        }
        set {
            this.indApuracaoField = value;
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
}


public partial class T_sucessaoVinc {
    
    private sbyte tpInscField;
    
    private string nrInscField;
    
    private string matricAntField;
    
    private System.DateTime dtAdmField;
    
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
    
    /// <remarks/>
    public string matricAnt {
        get {
            return this.matricAntField;
        }
        set {
            this.matricAntField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime dtAdm {
        get {
            return this.dtAdmField;
        }
        set {
            this.dtAdmField = value;
        }
    }
}

public partial class T_ideEmpregador {
    
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


public partial class eSocialEvtBasesTrabIdeTrabalhador {
    
    private string cpfTrabField;
    
    private eSocialEvtBasesTrabIdeTrabalhadorInfoCompl infoComplField;
    
    private eSocialEvtBasesTrabIdeTrabalhadorProcJudTrab[] procJudTrabField;
    
    /// <remarks/>
    public string cpfTrab {
        get {
            return this.cpfTrabField;
        }
        set {
            this.cpfTrabField = value;
        }
    }
    
    /// <remarks/>
    public eSocialEvtBasesTrabIdeTrabalhadorInfoCompl infoCompl {
        get {
            return this.infoComplField;
        }
        set {
            this.infoComplField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("procJudTrab")]
    public eSocialEvtBasesTrabIdeTrabalhadorProcJudTrab[] procJudTrab {
        get {
            return this.procJudTrabField;
        }
        set {
            this.procJudTrabField = value;
        }
    }
}


public partial class eSocialEvtBasesTrabIdeTrabalhadorInfoCompl {
    
    private T_sucessaoVinc sucessaoVincField;
    
    private eSocialEvtBasesTrabIdeTrabalhadorInfoComplInfoInterm[] infoIntermField;
    
    private eSocialEvtBasesTrabIdeTrabalhadorInfoComplInfoComplCont[] infoComplContField;
    
    /// <remarks/>
    public T_sucessaoVinc sucessaoVinc {
        get {
            return this.sucessaoVincField;
        }
        set {
            this.sucessaoVincField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("infoInterm")]
    public eSocialEvtBasesTrabIdeTrabalhadorInfoComplInfoInterm[] infoInterm {
        get {
            return this.infoIntermField;
        }
        set {
            this.infoIntermField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("infoComplCont")]
    public eSocialEvtBasesTrabIdeTrabalhadorInfoComplInfoComplCont[] infoComplCont {
        get {
            return this.infoComplContField;
        }
        set {
            this.infoComplContField = value;
        }
    }
}


public partial class eSocialEvtBasesTrabIdeTrabalhadorInfoComplInfoInterm {
    
    private sbyte diaField;
    
    /// <remarks/>
    public sbyte dia {
        get {
            return this.diaField;
        }
        set {
            this.diaField = value;
        }
    }
}


public partial class eSocialEvtBasesTrabIdeTrabalhadorInfoComplInfoComplCont {
    
    private string codCBOField;
    
    private sbyte natAtividadeField;
    
    private bool natAtividadeFieldSpecified;
    
    private sbyte qtdDiasTrabField;
    
    private bool qtdDiasTrabFieldSpecified;
    
    /// <remarks/>
    public string codCBO {
        get {
            return this.codCBOField;
        }
        set {
            this.codCBOField = value;
        }
    }
    
    /// <remarks/>
    public sbyte natAtividade {
        get {
            return this.natAtividadeField;
        }
        set {
            this.natAtividadeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool natAtividadeSpecified {
        get {
            return this.natAtividadeFieldSpecified;
        }
        set {
            this.natAtividadeFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public sbyte qtdDiasTrab {
        get {
            return this.qtdDiasTrabField;
        }
        set {
            this.qtdDiasTrabField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool qtdDiasTrabSpecified {
        get {
            return this.qtdDiasTrabFieldSpecified;
        }
        set {
            this.qtdDiasTrabFieldSpecified = value;
        }
    }
}


public partial class eSocialEvtBasesTrabIdeTrabalhadorProcJudTrab {
    
    private string nrProcJudField;
    
    private string codSuspField;
    
    /// <remarks/>
    public string nrProcJud {
        get {
            return this.nrProcJudField;
        }
        set {
            this.nrProcJudField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string codSusp {
        get {
            return this.codSuspField;
        }
        set {
            this.codSuspField = value;
        }
    }
}


public partial class eSocialEvtBasesTrabInfoCpCalc {
    
    private eSocialEvtBasesTrabInfoCpCalcTpCR tpCRField;
    
    private decimal vrCpSegField;
    
    private decimal vrDescSegField;
    
    /// <remarks/>
    public eSocialEvtBasesTrabInfoCpCalcTpCR tpCR {
        get {
            return this.tpCRField;
        }
        set {
            this.tpCRField = value;
        }
    }
    
    /// <remarks/>
    public decimal vrCpSeg {
        get {
            return this.vrCpSegField;
        }
        set {
            this.vrCpSegField = value;
        }
    }
    
    /// <remarks/>
    public decimal vrDescSeg {
        get {
            return this.vrDescSegField;
        }
        set {
            this.vrDescSegField = value;
        }
    }
}


public enum eSocialEvtBasesTrabInfoCpCalcTpCR {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("108201")]
    Item108201,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("108202")]
    Item108202,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("108203")]
    Item108203,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("108204")]
    Item108204,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("108205")]
    Item108205,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("108207")]
    Item108207,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("108221")]
    Item108221,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("108222")]
    Item108222,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("108223")]
    Item108223,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("108224")]
    Item108224,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("108225")]
    Item108225,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("109901")]
    Item109901,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("109902")]
    Item109902,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("109921")]
    Item109921,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("109922")]
    Item109922,
}


public partial class eSocialEvtBasesTrabInfoCp {
    
    private string classTribField;
    
    private eSocialEvtBasesTrabInfoCpIdeEstabLot[] ideEstabLotField;
    
    /// <remarks/>
    public string classTrib {
        get {
            return this.classTribField;
        }
        set {
            this.classTribField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ideEstabLot")]
    public eSocialEvtBasesTrabInfoCpIdeEstabLot[] ideEstabLot {
        get {
            return this.ideEstabLotField;
        }
        set {
            this.ideEstabLotField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.esocial.gov.br/schema/evt/evtBasesTrab/v_S_01_00_00")]
public partial class eSocialEvtBasesTrabInfoCpIdeEstabLot {
    
    private sbyte tpInscField;
    
    private string nrInscField;
    
    private string codLotacaoField;
    
    private eSocialEvtBasesTrabInfoCpIdeEstabLotInfoCategIncid[] infoCategIncidField;
    
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
    
    /// <remarks/>
    public string codLotacao {
        get {
            return this.codLotacaoField;
        }
        set {
            this.codLotacaoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("infoCategIncid")]
    public eSocialEvtBasesTrabInfoCpIdeEstabLotInfoCategIncid[] infoCategIncid {
        get {
            return this.infoCategIncidField;
        }
        set {
            this.infoCategIncidField = value;
        }
    }
}


public partial class eSocialEvtBasesTrabInfoCpIdeEstabLotInfoCategIncid {
    
    private string matriculaField;
    
    private string codCategField;
    
    private sbyte indSimplesField;
    
    private bool indSimplesFieldSpecified;
    
    private eSocialEvtBasesTrabInfoCpIdeEstabLotInfoCategIncidInfoBaseCS[] infoBaseCSField;
    
    private eSocialEvtBasesTrabInfoCpIdeEstabLotInfoCategIncidCalcTerc[] calcTercField;
    
    private eSocialEvtBasesTrabInfoCpIdeEstabLotInfoCategIncidInfoPerRef[] infoPerRefField;
    
    /// <remarks/>
    public string matricula {
        get {
            return this.matriculaField;
        }
        set {
            this.matriculaField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string codCateg {
        get {
            return this.codCategField;
        }
        set {
            this.codCategField = value;
        }
    }
    
    /// <remarks/>
    public sbyte indSimples {
        get {
            return this.indSimplesField;
        }
        set {
            this.indSimplesField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool indSimplesSpecified {
        get {
            return this.indSimplesFieldSpecified;
        }
        set {
            this.indSimplesFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("infoBaseCS")]
    public eSocialEvtBasesTrabInfoCpIdeEstabLotInfoCategIncidInfoBaseCS[] infoBaseCS {
        get {
            return this.infoBaseCSField;
        }
        set {
            this.infoBaseCSField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("calcTerc")]
    public eSocialEvtBasesTrabInfoCpIdeEstabLotInfoCategIncidCalcTerc[] calcTerc {
        get {
            return this.calcTercField;
        }
        set {
            this.calcTercField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("infoPerRef")]
    public eSocialEvtBasesTrabInfoCpIdeEstabLotInfoCategIncidInfoPerRef[] infoPerRef {
        get {
            return this.infoPerRefField;
        }
        set {
            this.infoPerRefField = value;
        }
    }
}


public partial class eSocialEvtBasesTrabInfoCpIdeEstabLotInfoCategIncidInfoBaseCS {
    
    private sbyte ind13Field;
    
    private sbyte tpValorField;
    
    private decimal valorField;
    
    /// <remarks/>
    public sbyte ind13 {
        get {
            return this.ind13Field;
        }
        set {
            this.ind13Field = value;
        }
    }
    
    /// <remarks/>
    public sbyte tpValor {
        get {
            return this.tpValorField;
        }
        set {
            this.tpValorField = value;
        }
    }
    
    /// <remarks/>
    public decimal valor {
        get {
            return this.valorField;
        }
        set {
            this.valorField = value;
        }
    }
}


public partial class eSocialEvtBasesTrabInfoCpIdeEstabLotInfoCategIncidCalcTerc {
    
    private eSocialEvtBasesTrabInfoCpIdeEstabLotInfoCategIncidCalcTercTpCR tpCRField;
    
    private decimal vrCsSegTercField;
    
    private decimal vrDescTercField;
    
    /// <remarks/>
    public eSocialEvtBasesTrabInfoCpIdeEstabLotInfoCategIncidCalcTercTpCR tpCR {
        get {
            return this.tpCRField;
        }
        set {
            this.tpCRField = value;
        }
    }
    
    /// <remarks/>
    public decimal vrCsSegTerc {
        get {
            return this.vrCsSegTercField;
        }
        set {
            this.vrCsSegTercField = value;
        }
    }
    
    /// <remarks/>
    public decimal vrDescTerc {
        get {
            return this.vrDescTercField;
        }
        set {
            this.vrDescTercField = value;
        }
    }
}


public enum eSocialEvtBasesTrabInfoCpIdeEstabLotInfoCategIncidCalcTercTpCR {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("121802")]
    Item121802,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("122102")]
    Item122102,
}


public partial class eSocialEvtBasesTrabInfoCpIdeEstabLotInfoCategIncidInfoPerRef {
    
    private string perRefField;
    
    private eSocialEvtBasesTrabInfoCpIdeEstabLotInfoCategIncidInfoPerRefIdeADC[] ideADCField;
    
    private eSocialEvtBasesTrabInfoCpIdeEstabLotInfoCategIncidInfoPerRefDetInfoPerRef[] detInfoPerRefField;
    
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
    [System.Xml.Serialization.XmlElementAttribute("ideADC")]
    public eSocialEvtBasesTrabInfoCpIdeEstabLotInfoCategIncidInfoPerRefIdeADC[] ideADC {
        get {
            return this.ideADCField;
        }
        set {
            this.ideADCField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("detInfoPerRef")]
    public eSocialEvtBasesTrabInfoCpIdeEstabLotInfoCategIncidInfoPerRefDetInfoPerRef[] detInfoPerRef {
        get {
            return this.detInfoPerRefField;
        }
        set {
            this.detInfoPerRefField = value;
        }
    }
}


public partial class eSocialEvtBasesTrabInfoCpIdeEstabLotInfoCategIncidInfoPerRefIdeADC {
    
    private System.DateTime dtAcConvField;
    
    private bool dtAcConvFieldSpecified;
    
    private TS_tpAcConv tpAcConvField;
    
    private string dscField;
    
    private TS_sim_nao remunSucField;
    
    private bool remunSucFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime dtAcConv {
        get {
            return this.dtAcConvField;
        }
        set {
            this.dtAcConvField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool dtAcConvSpecified {
        get {
            return this.dtAcConvFieldSpecified;
        }
        set {
            this.dtAcConvFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public TS_tpAcConv tpAcConv {
        get {
            return this.tpAcConvField;
        }
        set {
            this.tpAcConvField = value;
        }
    }
    
    /// <remarks/>
    public string dsc {
        get {
            return this.dscField;
        }
        set {
            this.dscField = value;
        }
    }
    
    /// <remarks/>
    public TS_sim_nao remunSuc {
        get {
            return this.remunSucField;
        }
        set {
            this.remunSucField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool remunSucSpecified {
        get {
            return this.remunSucFieldSpecified;
        }
        set {
            this.remunSucFieldSpecified = value;
        }
    }
}


public enum TS_tpAcConv {
    
    /// <remarks/>
    A,
    
    /// <remarks/>
    B,
    
    /// <remarks/>
    C,
    
    /// <remarks/>
    D,
    
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
}


public enum TS_sim_nao {
    
    /// <remarks/>
    S,
    
    /// <remarks/>
    N,
}


public partial class eSocialEvtBasesTrabInfoCpIdeEstabLotInfoCategIncidInfoPerRefDetInfoPerRef {
    
    private sbyte ind13Field;
    
    private sbyte tpVrPerRefField;
    
    private decimal vrPerRefField;
    
    /// <remarks/>
    public sbyte ind13 {
        get {
            return this.ind13Field;
        }
        set {
            this.ind13Field = value;
        }
    }
    
    /// <remarks/>
    public sbyte tpVrPerRef {
        get {
            return this.tpVrPerRefField;
        }
        set {
            this.tpVrPerRefField = value;
        }
    }
    
    /// <remarks/>
    public decimal vrPerRef {
        get {
            return this.vrPerRefField;
        }
        set {
            this.vrPerRefField = value;
        }
    }
}
}