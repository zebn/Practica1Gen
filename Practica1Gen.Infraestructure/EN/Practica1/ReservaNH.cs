
using System;
using Practica1Gen.ApplicationCore.EN.Practica1;
namespace Practica1Gen.Infraestructure.EN.Practica1
{
public partial class ReservaNH : ReservaEN {
public ReservaNH ()
{
}

public ReservaNH (ReservaEN dto)
{
        this.Id = dto.Id;


        this.Inicio = dto.Inicio;


        this.Final = dto.Final;
}
}
}
