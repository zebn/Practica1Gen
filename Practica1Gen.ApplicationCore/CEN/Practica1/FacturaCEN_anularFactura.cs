
using System;
using System.Text;
using System.Collections.Generic;
using Practica1Gen.ApplicationCore.Exceptions;
using Practica1Gen.ApplicationCore.EN.Practica1;
using Practica1Gen.ApplicationCore.IRepository.Practica1;


/*PROTECTED REGION ID(usingPractica1Gen.ApplicationCore.CEN.Practica1_Factura_anularFactura) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace Practica1Gen.ApplicationCore.CEN.Practica1
{
public partial class FacturaCEN
{
public void AnularFactura (int p_Factura_OID)
{
        /*PROTECTED REGION ID(Practica1Gen.ApplicationCore.CEN.Practica1_Factura_anularFactura) ENABLED START*/

        // Write here your custom code...

            if (DanePorOID(p_Factura_OID).EsAnulada == false)
            {
                Modficar(p_Factura_OID, DanePorOID(p_Factura_OID).Fecha, DanePorOID(p_Factura_OID).EsPagada, true, DanePorOID(p_Factura_OID).Total);
            }

     //   throw new NotImplementedException ("Method AnularFactura() not yet implemented.");

        /*PROTECTED REGION END*/
}
}
}
