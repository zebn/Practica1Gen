
using System;
using System.Text;
using System.Collections.Generic;
using Practica1Gen.ApplicationCore.Exceptions;
using Practica1Gen.ApplicationCore.EN.Practica1;
using Practica1Gen.ApplicationCore.IRepository.Practica1;


/*PROTECTED REGION ID(usingPractica1Gen.ApplicationCore.CEN.Practica1_Factura_pagarFacura) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace Practica1Gen.ApplicationCore.CEN.Practica1
{
public partial class FacturaCEN
{
public void PagarFacura (int p_oid)
{
            /*PROTECTED REGION ID(Practica1Gen.ApplicationCore.CEN.Practica1_Factura_pagarFacura) ENABLED START*/

            // Write here your custom code...

            if (DanePorOID(p_oid).EsPagada == false)
            {
                Modficar(p_oid, DanePorOID(p_oid).Fecha, true, DanePorOID(p_oid).EsAnulada, DanePorOID(p_oid).Total);
            }

            //  throw new NotImplementedException ("Method PagarFacura() not yet implemented.");

            /*PROTECTED REGION END*/
        }
}
}
