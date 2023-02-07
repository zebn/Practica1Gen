
using System;
using Practica1Gen.ApplicationCore.EN.Practica1;
namespace Practica1Gen.Infraestructure.EN.Practica1
{
public partial class FacturaNH : FacturaEN {
public FacturaNH ()
{
}

public FacturaNH (FacturaEN dto)
{
        this.Id = dto.Id;


        this.Fecha = dto.Fecha;


        this.EsPagada = dto.EsPagada;


        this.EsAnulada = dto.EsAnulada;


        this.Total = dto.Total;
}
}
}
