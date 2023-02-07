
using System;
using Practica1Gen.ApplicationCore.EN.Practica1;
namespace Practica1Gen.Infraestructure.EN.Practica1
{
public partial class CocheNH : CocheEN {
public CocheNH ()
{
}

public CocheNH (CocheEN dto)
{
        this.NumLicencia = dto.NumLicencia;


        this.Categoria = dto.Categoria;


        this.Estado = dto.Estado;
}
}
}
