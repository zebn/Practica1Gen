
using System;
using Practica1Gen.ApplicationCore.EN.Practica1;

namespace Practica1Gen.ApplicationCore.IRepository.Practica1
{
public partial interface IClienteRepository
{
ClienteEN ReadOIDDefault (string DNI
                          );

void ModifyDefault (ClienteEN cliente);

System.Collections.Generic.IList<ClienteEN> ReadAllDefault (int first, int size);



string CrearCliente (ClienteEN cliente);

void BorrarCliente (string DNI
                    );


void Modificar (ClienteEN cliente);
}
}
