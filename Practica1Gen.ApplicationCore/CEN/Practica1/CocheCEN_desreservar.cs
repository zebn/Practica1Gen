
using System;
using System.Text;
using System.Collections.Generic;
using Practica1Gen.ApplicationCore.Exceptions;
using Practica1Gen.ApplicationCore.EN.Practica1;
using Practica1Gen.ApplicationCore.IRepository.Practica1;


/*PROTECTED REGION ID(usingPractica1Gen.ApplicationCore.CEN.Practica1_Coche_desreservar) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace Practica1Gen.ApplicationCore.CEN.Practica1
{
public partial class CocheCEN
{
public void Desreservar (int p_oid)
{
        /*PROTECTED REGION ID(Practica1Gen.ApplicationCore.CEN.Practica1_Coche_desreservar) ENABLED START*/

        // Write here your custom code...

        if (DamePorOID (p_oid).Estado == Enumerated.Practica1.EstadoCocheEnum.alquilado) {
                Modificar (p_oid, Practica1Gen.ApplicationCore.Enumerated.Practica1.CategoriaCocheEnum.estandar, Enumerated.Practica1.EstadoCocheEnum.libre);
                DeasignarReserva (p_oid);
        }


        //  throw new NotImplementedException ("Method Desreservar() not yet implemented.");

        /*PROTECTED REGION END*/
}
}
}
