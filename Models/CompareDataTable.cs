using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CompareDataTable")]
public class CompareDataTable
{
    [XmlElement("FiscalDate")]
    public string FiscalDate { get; set; }

    [XmlElement("ColumnHeaders")]
    public TableLayout ColumnHeaders { get; set; }

}