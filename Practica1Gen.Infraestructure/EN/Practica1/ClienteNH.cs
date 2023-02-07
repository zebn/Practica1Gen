
using System;
using Practica1Gen.ApplicationCore.EN.Practica1;
namespace Practica1Gen.Infraestructure.EN.Practica1
{
public partial class ClienteNH : ClienteEN {
public ClienteNH ()
{
}

public ClienteNH (ClienteEN dto)
{
        this.DNI = dto.DNI;


        this.Nombre = dto.Nombre;


        this.Direccion = dto.Direccion;


        this.Telefono = dto.Telefono;


        this.Pass = dto.Pass;
}
}
}
