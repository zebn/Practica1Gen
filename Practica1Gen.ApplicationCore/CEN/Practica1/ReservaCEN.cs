

using System;
using System.Text;
using System.Collections.Generic;

using Practica1Gen.ApplicationCore.Exceptions;

using Practica1Gen.ApplicationCore.EN.Practica1;
using Practica1Gen.ApplicationCore.IRepository.Practica1;


namespace Practica1Gen.ApplicationCore.CEN.Practica1
{
/*
 *      Definition of the class ReservaCEN
 *
 */
public partial class ReservaCEN
{
private IReservaRepository _IReservaRepository;

public ReservaCEN(IReservaRepository _IReservaRepository)
{
        this._IReservaRepository = _IReservaRepository;
}

public IReservaRepository get_IReservaRepository ()
{
        return this._IReservaRepository;
}

public int CrearReserva (Nullable<DateTime> p_inicio, Nullable<DateTime> p_final, string p_cliente)
{
        ReservaEN reservaEN = null;
        int oid;

        //Initialized ReservaEN
        reservaEN = new ReservaEN ();
        reservaEN.Inicio = p_inicio;

        reservaEN.Final = p_final;


        if (p_cliente != null) {
                // El argumento p_cliente -> Property cliente es oid = false
                // Lista de oids id
                reservaEN.Cliente = new Practica1Gen.ApplicationCore.EN.Practica1.ClienteEN ();
                reservaEN.Cliente.DNI = p_cliente;
        }

        //Call to ReservaRepository

        oid = _IReservaRepository.CrearReserva (reservaEN);
        return oid;
}

public void BorrarReserva (int id
                           )
{
        _IReservaRepository.BorrarReserva (id);
}
}
}
