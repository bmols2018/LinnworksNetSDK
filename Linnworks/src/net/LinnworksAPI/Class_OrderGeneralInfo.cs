using System.Text;
using System;
using System.Collections.Generic;
namespace LinnworksAPI
{ public class OrderGeneralInfo
{ public Int32 Status;
public Boolean LabelPrinted;
public String LabelError;
public Boolean InvoicePrinted;
public Boolean PickListPrinted;
public Int32 Notes;
public Boolean PartShipped;
public Byte? Marker;
public String ReferenceNum;
public String ExternalReferenceNum;
public DateTime ReceivedDate;
public String Source;
public String SubSource;
public Boolean HoldOrCancel;
public DateTime DespatchByDate;
public Int32 NumItems;
 
} 
}