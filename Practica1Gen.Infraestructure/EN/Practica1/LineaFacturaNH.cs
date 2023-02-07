
using System;
using Practica1Gen.ApplicationCore.EN.Practica1;
namespace Practica1Gen.Infraestructure.EN.Practica1
{
public partial class LineaFacturaNH : LineaFacturaEN {
public LineaFacturaNH ()
{
}

public LineaFacturaNH (LineaFacturaEN dto)
{
        this.NumLinea = dto.NumLinea;


        this.Precio = dto.Precio;
}
}
}
