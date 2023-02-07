

using System;
using System.Text;
using System.Collections.Generic;

using Practica1Gen.ApplicationCore.Exceptions;

using Practica1Gen.ApplicationCore.EN.Practica1;
using Practica1Gen.ApplicationCore.IRepository.Practica1;


namespace Practica1Gen.ApplicationCore.CEN.Practica1
{
/*
 *      Definition of the class LineaFacturaCEN
 *
 */
public partial class LineaFacturaCEN
{
private ILineaFacturaRepository _ILineaFacturaRepository;

public LineaFacturaCEN(ILineaFacturaRepository _ILineaFacturaRepository)
{
        this._ILineaFacturaRepository = _ILineaFacturaRepository;
}

public ILineaFacturaRepository get_ILineaFacturaRepository ()
{
        return this._ILineaFacturaRepository;
}

public int CrearLinea (double p_precio, int p_reserva, int p_factura)
{
        LineaFacturaEN lineaFacturaEN = null;
        int oid;

        //Initialized LineaFacturaEN
        lineaFacturaEN = new LineaFacturaEN ();
        lineaFacturaEN.Precio = p_precio;


        if (p_reserva != -1) {
                // El argumento p_reserva -> Property reserva es oid = false
                // Lista de oids numLinea
                lineaFacturaEN.Reserva = new Practica1Gen.ApplicationCore.EN.Practica1.ReservaEN ();
                lineaFacturaEN.Reserva.Id = p_reserva;
        }


        if (p_factura != -1) {
                // El argumento p_factura -> Property factura es oid = false
                // Lista de oids numLinea
                lineaFacturaEN.Factura = new Practica1Gen.ApplicationCore.EN.Practica1.FacturaEN ();
                lineaFacturaEN.Factura.Id = p_factura;
        }

        //Call to LineaFacturaRepository

        oid = _ILineaFacturaRepository.CrearLinea (lineaFacturaEN);
        return oid;
}
}
}
