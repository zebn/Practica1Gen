
using System;
using System.Text;
using System.Collections.Generic;
using Practica1Gen.ApplicationCore.Exceptions;
using Practica1Gen.ApplicationCore.EN.Practica1;
using Practica1Gen.ApplicationCore.IRepository.Practica1;


/*PROTECTED REGION ID(usingPractica1Gen.ApplicationCore.CEN.Practica1_Coche_reservar) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace Practica1Gen.ApplicationCore.CEN.Practica1
{
public partial class CocheCEN
{
public void Reservar (int p_oid)
{
        /*PROTECTED REGION ID(Practica1Gen.ApplicationCore.CEN.Practica1_Coche_reservar) ENABLED START*/

        // Write here your custom code...

        if (DamePorOID (p_oid).Estado == Enumerated.Practica1.EstadoCocheEnum.libre) {
                Modificar (p_oid, DamePorOID(p_oid).Categoria, Enumerated.Practica1.EstadoCocheEnum.alquilado);
                AsignarReserva (p_oid);
        }

        //     throw new NotImplementedException ("Method Reservar() not yet implemented.");

        /*PROTECTED REGION END*/
}
}
}
