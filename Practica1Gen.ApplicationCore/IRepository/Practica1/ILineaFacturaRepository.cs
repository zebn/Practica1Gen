
using System;
using Practica1Gen.ApplicationCore.EN.Practica1;

namespace Practica1Gen.ApplicationCore.IRepository.Practica1
{
public partial interface ILineaFacturaRepository
{
LineaFacturaEN ReadOIDDefault (int numLinea
                               );

void ModifyDefault (LineaFacturaEN lineaFactura);

System.Collections.Generic.IList<LineaFacturaEN> ReadAllDefault (int first, int size);



int CrearLinea (LineaFacturaEN lineaFactura);
}
}
