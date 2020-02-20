﻿using System.Xml.Serialization;

namespace Atencao_Assistida.ModelSerialization
{
    [XmlRoot(ElementName = "nfeProc", Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public class NFeProc
    {
        [XmlAttribute("versao")]
        public string versao { get; set; }

        [XmlElement("NFe", Namespace = "http://www.portalfiscal.inf.br/nfe")]
        public NFe NotaFiscalEletronica { get; set; }
    }

}
