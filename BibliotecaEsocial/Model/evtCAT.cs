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


namespace BibliotecaEsocial.Model.S2210
{

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.esocial.gov.br/schema/evt/evtCAT/v_S_01_00_00")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.esocial.gov.br/schema/evt/evtCAT/v_S_01_00_00", IsNullable=false)]
public partial class eSocial {
    
    private eSocialEvtCAT evtCATField;
    
    /// <remarks/>
    public eSocialEvtCAT evtCAT {
        get {
            return this.evtCATField;
        }
        set {
            this.evtCATField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.esocial.gov.br/schema/evt/evtCAT/v_S_01_00_00")]
public partial class eSocialEvtCAT {
    
    private T_ideEvento_trab ideEventoField;
    
    private T_ideEmpregador ideEmpregadorField;
    
    private T_ideVinculo_sst ideVinculoField;
    
    private eSocialEvtCATCat catField;
    
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
    public T_ideEmpregador ideEmpregador {
        get {
            return this.ideEmpregadorField;
        }
        set {
            this.ideEmpregadorField = value;
        }
    }
    
    /// <remarks/>
    public T_ideVinculo_sst ideVinculo {
        get {
            return this.ideVinculoField;
        }
        set {
            this.ideVinculoField = value;
        }
    }
    
    /// <remarks/>
    public eSocialEvtCATCat cat {
        get {
            return this.catField;
        }
        set {
            this.catField = value;
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


public partial class T_ideVinculo_sst {
    
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


public partial class eSocialEvtCATCat {
    
    private System.DateTime dtAcidField;
    
    private sbyte tpAcidField;
    
    private string hrAcidField;
    
    private string hrsTrabAntesAcidField;
    
    private sbyte tpCatField;
    
    private TS_sim_nao indCatObitoField;
    
    private System.DateTime dtObitoField;
    
    private bool dtObitoFieldSpecified;
    
    private TS_sim_nao indComunPoliciaField;
    
    private string codSitGeradoraField;
    
    private sbyte iniciatCATField;
    
    private string obsCATField;
    
    private System.DateTime ultDiaTrabField;
    
    private bool ultDiaTrabFieldSpecified;
    
    private TS_sim_nao houveAfastField;
    
    private bool houveAfastFieldSpecified;
    
    private eSocialEvtCATCatLocalAcidente localAcidenteField;
    
    private eSocialEvtCATCatParteAtingida parteAtingidaField;
    
    private eSocialEvtCATCatAgenteCausador agenteCausadorField;
    
    private eSocialEvtCATCatAtestado atestadoField;
    
    private eSocialEvtCATCatCatOrigem catOrigemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime dtAcid {
        get {
            return this.dtAcidField;
        }
        set {
            this.dtAcidField = value;
        }
    }
    
    /// <remarks/>
    public sbyte tpAcid {
        get {
            return this.tpAcidField;
        }
        set {
            this.tpAcidField = value;
        }
    }
    
    /// <remarks/>
    public string hrAcid {
        get {
            return this.hrAcidField;
        }
        set {
            this.hrAcidField = value;
        }
    }
    
    /// <remarks/>
    public string hrsTrabAntesAcid {
        get {
            return this.hrsTrabAntesAcidField;
        }
        set {
            this.hrsTrabAntesAcidField = value;
        }
    }
    
    /// <remarks/>
    public sbyte tpCat {
        get {
            return this.tpCatField;
        }
        set {
            this.tpCatField = value;
        }
    }
    
    /// <remarks/>
    public TS_sim_nao indCatObito {
        get {
            return this.indCatObitoField;
        }
        set {
            this.indCatObitoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime dtObito {
        get {
            return this.dtObitoField;
        }
        set {
            this.dtObitoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool dtObitoSpecified {
        get {
            return this.dtObitoFieldSpecified;
        }
        set {
            this.dtObitoFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public TS_sim_nao indComunPolicia {
        get {
            return this.indComunPoliciaField;
        }
        set {
            this.indComunPoliciaField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string codSitGeradora {
        get {
            return this.codSitGeradoraField;
        }
        set {
            this.codSitGeradoraField = value;
        }
    }
    
    /// <remarks/>
    public sbyte iniciatCAT {
        get {
            return this.iniciatCATField;
        }
        set {
            this.iniciatCATField = value;
        }
    }
    
    /// <remarks/>
    public string obsCAT {
        get {
            return this.obsCATField;
        }
        set {
            this.obsCATField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime ultDiaTrab {
        get {
            return this.ultDiaTrabField;
        }
        set {
            this.ultDiaTrabField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ultDiaTrabSpecified {
        get {
            return this.ultDiaTrabFieldSpecified;
        }
        set {
            this.ultDiaTrabFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public TS_sim_nao houveAfast {
        get {
            return this.houveAfastField;
        }
        set {
            this.houveAfastField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool houveAfastSpecified {
        get {
            return this.houveAfastFieldSpecified;
        }
        set {
            this.houveAfastFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public eSocialEvtCATCatLocalAcidente localAcidente {
        get {
            return this.localAcidenteField;
        }
        set {
            this.localAcidenteField = value;
        }
    }
    
    /// <remarks/>
    public eSocialEvtCATCatParteAtingida parteAtingida {
        get {
            return this.parteAtingidaField;
        }
        set {
            this.parteAtingidaField = value;
        }
    }
    
    /// <remarks/>
    public eSocialEvtCATCatAgenteCausador agenteCausador {
        get {
            return this.agenteCausadorField;
        }
        set {
            this.agenteCausadorField = value;
        }
    }
    
    /// <remarks/>
    public eSocialEvtCATCatAtestado atestado {
        get {
            return this.atestadoField;
        }
        set {
            this.atestadoField = value;
        }
    }
    
    /// <remarks/>
    public eSocialEvtCATCatCatOrigem catOrigem {
        get {
            return this.catOrigemField;
        }
        set {
            this.catOrigemField = value;
        }
    }
}


public enum TS_sim_nao {
    
    /// <remarks/>
    S,
    
    /// <remarks/>
    N,
}


public partial class eSocialEvtCATCatLocalAcidente {
    
    private sbyte tpLocalField;
    
    private string dscLocalField;
    
    private string tpLogradField;
    
    private string dscLogradField;
    
    private string nrLogradField;
    
    private string complementoField;
    
    private string bairroField;
    
    private string cepField;
    
    private string codMunicField;
    
    private TS_uf ufField;
    
    private bool ufFieldSpecified;
    
    private string paisField;
    
    private string codPostalField;
    
    private eSocialEvtCATCatLocalAcidenteIdeLocalAcid ideLocalAcidField;
    
    /// <remarks/>
    public sbyte tpLocal {
        get {
            return this.tpLocalField;
        }
        set {
            this.tpLocalField = value;
        }
    }
    
    /// <remarks/>
    public string dscLocal {
        get {
            return this.dscLocalField;
        }
        set {
            this.dscLocalField = value;
        }
    }
    
    /// <remarks/>
    public string tpLograd {
        get {
            return this.tpLogradField;
        }
        set {
            this.tpLogradField = value;
        }
    }
    
    /// <remarks/>
    public string dscLograd {
        get {
            return this.dscLogradField;
        }
        set {
            this.dscLogradField = value;
        }
    }
    
    /// <remarks/>
    public string nrLograd {
        get {
            return this.nrLogradField;
        }
        set {
            this.nrLogradField = value;
        }
    }
    
    /// <remarks/>
    public string complemento {
        get {
            return this.complementoField;
        }
        set {
            this.complementoField = value;
        }
    }
    
    /// <remarks/>
    public string bairro {
        get {
            return this.bairroField;
        }
        set {
            this.bairroField = value;
        }
    }
    
    /// <remarks/>
    public string cep {
        get {
            return this.cepField;
        }
        set {
            this.cepField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string codMunic {
        get {
            return this.codMunicField;
        }
        set {
            this.codMunicField = value;
        }
    }
    
    /// <remarks/>
    public TS_uf uf {
        get {
            return this.ufField;
        }
        set {
            this.ufField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ufSpecified {
        get {
            return this.ufFieldSpecified;
        }
        set {
            this.ufFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string pais {
        get {
            return this.paisField;
        }
        set {
            this.paisField = value;
        }
    }
    
    /// <remarks/>
    public string codPostal {
        get {
            return this.codPostalField;
        }
        set {
            this.codPostalField = value;
        }
    }
    
    /// <remarks/>
    public eSocialEvtCATCatLocalAcidenteIdeLocalAcid ideLocalAcid {
        get {
            return this.ideLocalAcidField;
        }
        set {
            this.ideLocalAcidField = value;
        }
    }
}


public enum TS_uf {
    
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


public partial class eSocialEvtCATCatLocalAcidenteIdeLocalAcid {
    
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


public partial class eSocialEvtCATCatParteAtingida {
    
    private string codParteAtingField;
    
    private sbyte lateralidadeField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string codParteAting {
        get {
            return this.codParteAtingField;
        }
        set {
            this.codParteAtingField = value;
        }
    }
    
    /// <remarks/>
    public sbyte lateralidade {
        get {
            return this.lateralidadeField;
        }
        set {
            this.lateralidadeField = value;
        }
    }
}


public partial class eSocialEvtCATCatAgenteCausador {
    
    private string codAgntCausadorField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string codAgntCausador {
        get {
            return this.codAgntCausadorField;
        }
        set {
            this.codAgntCausadorField = value;
        }
    }
}


public partial class eSocialEvtCATCatAtestado {
    
    private System.DateTime dtAtendimentoField;
    
    private string hrAtendimentoField;
    
    private TS_sim_nao indInternacaoField;
    
    private string durTratField;
    
    private TS_sim_nao indAfastField;
    
    private string dscLesaoField;
    
    private string dscCompLesaoField;
    
    private string diagProvavelField;
    
    private string codCIDField;
    
    private string observacaoField;
    
    private eSocialEvtCATCatAtestadoEmitente emitenteField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime dtAtendimento {
        get {
            return this.dtAtendimentoField;
        }
        set {
            this.dtAtendimentoField = value;
        }
    }
    
    /// <remarks/>
    public string hrAtendimento {
        get {
            return this.hrAtendimentoField;
        }
        set {
            this.hrAtendimentoField = value;
        }
    }
    
    /// <remarks/>
    public TS_sim_nao indInternacao {
        get {
            return this.indInternacaoField;
        }
        set {
            this.indInternacaoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string durTrat {
        get {
            return this.durTratField;
        }
        set {
            this.durTratField = value;
        }
    }
    
    /// <remarks/>
    public TS_sim_nao indAfast {
        get {
            return this.indAfastField;
        }
        set {
            this.indAfastField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string dscLesao {
        get {
            return this.dscLesaoField;
        }
        set {
            this.dscLesaoField = value;
        }
    }
    
    /// <remarks/>
    public string dscCompLesao {
        get {
            return this.dscCompLesaoField;
        }
        set {
            this.dscCompLesaoField = value;
        }
    }
    
    /// <remarks/>
    public string diagProvavel {
        get {
            return this.diagProvavelField;
        }
        set {
            this.diagProvavelField = value;
        }
    }
    
    /// <remarks/>
    public string codCID {
        get {
            return this.codCIDField;
        }
        set {
            this.codCIDField = value;
        }
    }
    
    /// <remarks/>
    public string observacao {
        get {
            return this.observacaoField;
        }
        set {
            this.observacaoField = value;
        }
    }
    
    /// <remarks/>
    public eSocialEvtCATCatAtestadoEmitente emitente {
        get {
            return this.emitenteField;
        }
        set {
            this.emitenteField = value;
        }
    }
}


public partial class eSocialEvtCATCatAtestadoEmitente {
    
    private string nmEmitField;
    
    private sbyte ideOCField;
    
    private string nrOCField;
    
    private TS_uf ufOCField;
    
    private bool ufOCFieldSpecified;
    
    /// <remarks/>
    public string nmEmit {
        get {
            return this.nmEmitField;
        }
        set {
            this.nmEmitField = value;
        }
    }
    
    /// <remarks/>
    public sbyte ideOC {
        get {
            return this.ideOCField;
        }
        set {
            this.ideOCField = value;
        }
    }
    
    /// <remarks/>
    public string nrOC {
        get {
            return this.nrOCField;
        }
        set {
            this.nrOCField = value;
        }
    }
    
    /// <remarks/>
    public TS_uf ufOC {
        get {
            return this.ufOCField;
        }
        set {
            this.ufOCField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ufOCSpecified {
        get {
            return this.ufOCFieldSpecified;
        }
        set {
            this.ufOCFieldSpecified = value;
        }
    }
}


public partial class eSocialEvtCATCatCatOrigem {
    
    private string nrRecCatOrigField;
    
    /// <remarks/>
    public string nrRecCatOrig {
        get {
            return this.nrRecCatOrigField;
        }
        set {
            this.nrRecCatOrigField = value;
        }
    }
}
}