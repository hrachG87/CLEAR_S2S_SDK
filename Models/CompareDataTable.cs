using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CompareDataTable")]
public class CompareDataTable
{
    [XmlElement("FiscalDate")]
    public string FiscalDate { get; set; }

    [XmlElement("ColumnHeaders")]
    public TableLayout ColumnHeaders { get; set; }

}
}