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
namespace BibliotecaEsocial.Model.S2399
{


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.esocial.gov.br/schema/evt/evtTSVTermino/v_S_01_00_00")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.esocial.gov.br/schema/evt/evtTSVTermino/v_S_01_00_00", IsNullable=false)]
public partial class eSocial {
    
    private eSocialEvtTSVTermino evtTSVTerminoField;
    
    /// <remarks/>
    public eSocialEvtTSVTermino evtTSVTermino {
        get {
            return this.evtTSVTerminoField;
        }
        set {
            this.evtTSVTerminoField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.esocial.gov.br/schema/evt/evtTSVTermino/v_S_01_00_00")]
public partial class eSocialEvtTSVTermino {
    
    private T_ideEvento_trab_indGuia ideEventoField;
    
    private T_ideEmpregador ideEmpregadorField;
    
    private T_ideTrabSemVinculo ideTrabSemVinculoField;
    
    private eSocialEvtTSVTerminoInfoTSVTermino infoTSVTerminoField;
    
    private string idField;
    
    /// <remarks/>
    public T_ideEvento_trab_indGuia ideEvento {
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
    public T_ideTrabSemVinculo ideTrabSemVinculo {
        get {
            return this.ideTrabSemVinculoField;
        }
        set {
            this.ideTrabSemVinculoField = value;
        }
    }
    
    /// <remarks/>
    public eSocialEvtTSVTerminoInfoTSVTermino infoTSVTermino {
        get {
            return this.infoTSVTerminoField;
        }
        set {
            this.infoTSVTerminoField = value;
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


public partial class T_ideEvento_trab_indGuia {
    
    private sbyte indRetifField;
    
    private string nrReciboField;
    
    private sbyte indGuiaField;
    
    private bool indGuiaFieldSpecified;
    
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
    public sbyte indGuia {
        get {
            return this.indGuiaField;
        }
        set {
            this.indGuiaField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool indGuiaSpecified {
        get {
            return this.indGuiaFieldSpecified;
        }
        set {
            this.indGuiaFieldSpecified = value;
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


public partial class T_infoMV {
    
    private sbyte indMVField;
    
    private T_infoMVRemunOutrEmpr[] remunOutrEmprField;
    
    /// <remarks/>
    public sbyte indMV {
        get {
            return this.indMVField;
        }
        set {
            this.indMVField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("remunOutrEmpr")]
    public T_infoMVRemunOutrEmpr[] remunOutrEmpr {
        get {
            return this.remunOutrEmprField;
        }
        set {
            this.remunOutrEmprField = value;
        }
    }
}


public partial class T_infoMVRemunOutrEmpr {
    
    private sbyte tpInscField;
    
    private string nrInscField;
    
    private string codCategField;
    
    private decimal vlrRemunOEField;
    
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
    public decimal vlrRemunOE {
        get {
            return this.vlrRemunOEField;
        }
        set {
            this.vlrRemunOEField = value;
        }
    }
}

public partial class T_procJudTrab {
    
    private sbyte tpTribField;
    
    private string nrProcJudField;
    
    private string codSuspField;
    
    /// <remarks/>
    public sbyte tpTrib {
        get {
            return this.tpTribField;
        }
        set {
            this.tpTribField = value;
        }
    }
    
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


public partial class T_infoSimples {
    
    private sbyte indSimplesField;
    
    /// <remarks/>
    public sbyte indSimples {
        get {
            return this.indSimplesField;
        }
        set {
            this.indSimplesField = value;
        }
    }
}


public partial class T_ideTrabSemVinculo {
    
    private string cpfTrabField;
    
    private string matriculaField;
    
    private string codCategField;
    
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


public partial class eSocialEvtTSVTerminoInfoTSVTermino {
    
    private System.DateTime dtTermField;
    
    private eSocialEvtTSVTerminoInfoTSVTerminoMtvDesligTSV mtvDesligTSVField;
    
    private bool mtvDesligTSVFieldSpecified;
    
    private sbyte pensAlimField;
    
    private bool pensAlimFieldSpecified;
    
    private decimal percAlimentField;
    
    private bool percAlimentFieldSpecified;
    
    private decimal vrAlimField;
    
    private bool vrAlimFieldSpecified;
    
    private string nrProcTrabField;
    
    private eSocialEvtTSVTerminoInfoTSVTerminoMudancaCPF mudancaCPFField;
    
    private eSocialEvtTSVTerminoInfoTSVTerminoVerbasResc verbasRescField;
    
    private eSocialEvtTSVTerminoInfoTSVTerminoQuarentena quarentenaField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime dtTerm {
        get {
            return this.dtTermField;
        }
        set {
            this.dtTermField = value;
        }
    }
    
    /// <remarks/>
    public eSocialEvtTSVTerminoInfoTSVTerminoMtvDesligTSV mtvDesligTSV {
        get {
            return this.mtvDesligTSVField;
        }
        set {
            this.mtvDesligTSVField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool mtvDesligTSVSpecified {
        get {
            return this.mtvDesligTSVFieldSpecified;
        }
        set {
            this.mtvDesligTSVFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public sbyte pensAlim {
        get {
            return this.pensAlimField;
        }
        set {
            this.pensAlimField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool pensAlimSpecified {
        get {
            return this.pensAlimFieldSpecified;
        }
        set {
            this.pensAlimFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public decimal percAliment {
        get {
            return this.percAlimentField;
        }
        set {
            this.percAlimentField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool percAlimentSpecified {
        get {
            return this.percAlimentFieldSpecified;
        }
        set {
            this.percAlimentFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public decimal vrAlim {
        get {
            return this.vrAlimField;
        }
        set {
            this.vrAlimField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool vrAlimSpecified {
        get {
            return this.vrAlimFieldSpecified;
        }
        set {
            this.vrAlimFieldSpecified = value;
        }
    }
    
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
    public eSocialEvtTSVTerminoInfoTSVTerminoMudancaCPF mudancaCPF {
        get {
            return this.mudancaCPFField;
        }
        set {
            this.mudancaCPFField = value;
        }
    }
    
    /// <remarks/>
    public eSocialEvtTSVTerminoInfoTSVTerminoVerbasResc verbasResc {
        get {
            return this.verbasRescField;
        }
        set {
            this.verbasRescField = value;
        }
    }
    
    /// <remarks/>
    public eSocialEvtTSVTerminoInfoTSVTerminoQuarentena quarentena {
        get {
            return this.quarentenaField;
        }
        set {
            this.quarentenaField = value;
        }
    }
}


public enum eSocialEvtTSVTerminoInfoTSVTerminoMtvDesligTSV {
    
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
    [System.Xml.Serialization.XmlEnumAttribute("99")]
    Item99,
}


public partial class eSocialEvtTSVTerminoInfoTSVTerminoMudancaCPF {
    
    private string novoCPFField;
    
    /// <remarks/>
    public string novoCPF {
        get {
            return this.novoCPFField;
        }
        set {
            this.novoCPFField = value;
        }
    }
}


public partial class eSocialEvtTSVTerminoInfoTSVTerminoVerbasResc {
    
    private eSocialEvtTSVTerminoInfoTSVTerminoVerbasRescDmDev[] dmDevField;
    
    private T_procJudTrab[] procJudTrabField;
    
    private T_infoMV infoMVField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("dmDev")]
    public eSocialEvtTSVTerminoInfoTSVTerminoVerbasRescDmDev[] dmDev {
        get {
            return this.dmDevField;
        }
        set {
            this.dmDevField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("procJudTrab")]
    public T_procJudTrab[] procJudTrab {
        get {
            return this.procJudTrabField;
        }
        set {
            this.procJudTrabField = value;
        }
    }
    
    /// <remarks/>
    public T_infoMV infoMV {
        get {
            return this.infoMVField;
        }
        set {
            this.infoMVField = value;
        }
    }
}


public partial class eSocialEvtTSVTerminoInfoTSVTerminoVerbasRescDmDev {
    
    private string ideDmDevField;
    
    private eSocialEvtTSVTerminoInfoTSVTerminoVerbasRescDmDevIdeEstabLot[] ideEstabLotField;
    
    /// <remarks/>
    public string ideDmDev {
        get {
            return this.ideDmDevField;
        }
        set {
            this.ideDmDevField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ideEstabLot")]
    public eSocialEvtTSVTerminoInfoTSVTerminoVerbasRescDmDevIdeEstabLot[] ideEstabLot {
        get {
            return this.ideEstabLotField;
        }
        set {
            this.ideEstabLotField = value;
        }
    }
}


public partial class eSocialEvtTSVTerminoInfoTSVTerminoVerbasRescDmDevIdeEstabLot {
    
    private sbyte tpInscField;
    
    private string nrInscField;
    
    private string codLotacaoField;
    
    private eSocialEvtTSVTerminoInfoTSVTerminoVerbasRescDmDevIdeEstabLotDetVerbas[] detVerbasField;
    
    private T_infoSimples infoSimplesField;
    
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
    [System.Xml.Serialization.XmlElementAttribute("detVerbas")]
    public eSocialEvtTSVTerminoInfoTSVTerminoVerbasRescDmDevIdeEstabLotDetVerbas[] detVerbas {
        get {
            return this.detVerbasField;
        }
        set {
            this.detVerbasField = value;
        }
    }
    
    /// <remarks/>
    public T_infoSimples infoSimples {
        get {
            return this.infoSimplesField;
        }
        set {
            this.infoSimplesField = value;
        }
    }
}


public partial class eSocialEvtTSVTerminoInfoTSVTerminoVerbasRescDmDevIdeEstabLotDetVerbas {
    
    private string codRubrField;
    
    private string ideTabRubrField;
    
    private decimal qtdRubrField;
    
    private bool qtdRubrFieldSpecified;
    
    private decimal fatorRubrField;
    
    private bool fatorRubrFieldSpecified;
    
    private decimal vrRubrField;
    
    private sbyte indApurIRField;
    
    private bool indApurIRFieldSpecified;
    
    /// <remarks/>
    public string codRubr {
        get {
            return this.codRubrField;
        }
        set {
            this.codRubrField = value;
        }
    }
    
    /// <remarks/>
    public string ideTabRubr {
        get {
            return this.ideTabRubrField;
        }
        set {
            this.ideTabRubrField = value;
        }
    }
    
    /// <remarks/>
    public decimal qtdRubr {
        get {
            return this.qtdRubrField;
        }
        set {
            this.qtdRubrField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool qtdRubrSpecified {
        get {
            return this.qtdRubrFieldSpecified;
        }
        set {
            this.qtdRubrFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public decimal fatorRubr {
        get {
            return this.fatorRubrField;
        }
        set {
            this.fatorRubrField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool fatorRubrSpecified {
        get {
            return this.fatorRubrFieldSpecified;
        }
        set {
            this.fatorRubrFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public decimal vrRubr {
        get {
            return this.vrRubrField;
        }
        set {
            this.vrRubrField = value;
        }
    }
    
    /// <remarks/>
    public sbyte indApurIR {
        get {
            return this.indApurIRField;
        }
        set {
            this.indApurIRField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool indApurIRSpecified {
        get {
            return this.indApurIRFieldSpecified;
        }
        set {
            this.indApurIRFieldSpecified = value;
        }
    }
}


public partial class eSocialEvtTSVTerminoInfoTSVTerminoQuarentena {
    
    private System.DateTime dtFimQuarField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime dtFimQuar {
        get {
            return this.dtFimQuarField;
        }
        set {
            this.dtFimQuarField = value;
        }
    }
}
}