

using System;
using System.Text;
using System.Collections.Generic;

using Practica1Gen.ApplicationCore.Exceptions;

using Practica1Gen.ApplicationCore.EN.Practica1;
using Practica1Gen.ApplicationCore.IRepository.Practica1;


namespace Practica1Gen.ApplicationCore.CEN.Practica1
{
/*
 *      Definition of the class FacturaCEN
 *
 */
public partial class FacturaCEN
{
private IFacturaRepository _IFacturaRepository;

public FacturaCEN(IFacturaRepository _IFacturaRepository)
{
        this._IFacturaRepository = _IFacturaRepository;
}

public IFacturaRepository get_IFacturaRepository ()
{
        return this._IFacturaRepository;
}

public int CrearFactura (Nullable<DateTime> p_fecha, bool p_esPagada, bool p_esAnulada, float p_total, System.Collections.Generic.IList<Practica1Gen.ApplicationCore.EN.Practica1.LineaFacturaEN> p_lineaFactura, string p_cliente)
{
        FacturaEN facturaEN = null;
        int oid;

        //Initialized FacturaEN
        facturaEN = new FacturaEN ();
        facturaEN.Fecha = p_fecha;

        facturaEN.EsPagada = p_esPagada;

        facturaEN.EsAnulada = p_esAnulada;

        facturaEN.Total = p_total;

        facturaEN.LineaFactura = p_lineaFactura;


        if (p_cliente != null) {
                // El argumento p_cliente -> Property cliente es oid = false
                // Lista de oids id
                facturaEN.Cliente = new Practica1Gen.ApplicationCore.EN.Practica1.ClienteEN ();
                facturaEN.Cliente.DNI = p_cliente;
        }

        //Call to FacturaRepository

        oid = _IFacturaRepository.CrearFactura (facturaEN);
        return oid;
}

public void Modficar (int p_Factura_OID, Nullable<DateTime> p_fecha, bool p_esPagada, bool p_esAnulada, float p_total)
{
        FacturaEN facturaEN = null;

        //Initialized FacturaEN
        facturaEN = new FacturaEN ();
        facturaEN.Id = p_Factura_OID;
        facturaEN.Fecha = p_fecha;
        facturaEN.EsPagada = p_esPagada;
        facturaEN.EsAnulada = p_esAnulada;
        facturaEN.Total = p_total;
        //Call to FacturaRepository

        _IFacturaRepository.Modficar (facturaEN);
}

public FacturaEN DanePorOID (int id
                             )
{
        FacturaEN facturaEN = null;

        facturaEN = _IFacturaRepository.DanePorOID (id);
        return facturaEN;
}

public System.Collections.Generic.IList<FacturaEN> DameTODO (int first, int size)
{
        System.Collections.Generic.IList<FacturaEN> list = null;

        list = _IFacturaRepository.DameTODO (first, size);
        return list;
}
}
}
