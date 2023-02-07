

using System;
using System.Text;
using System.Collections.Generic;

using Practica1Gen.ApplicationCore.Exceptions;

using Practica1Gen.ApplicationCore.EN.Practica1;
using Practica1Gen.ApplicationCore.IRepository.Practica1;
using Newtonsoft.Json;


namespace Practica1Gen.ApplicationCore.CEN.Practica1
{
/*
 *      Definition of the class ClienteCEN
 *
 */
public partial class ClienteCEN
{
private IClienteRepository _IClienteRepository;

public ClienteCEN(IClienteRepository _IClienteRepository)
{
        this._IClienteRepository = _IClienteRepository;
}

public IClienteRepository get_IClienteRepository ()
{
        return this._IClienteRepository;
}

public string CrearCliente (string p_DNI, string p_nombre, string p_direccion, string p_telefono, String p_pass)
{
        ClienteEN clienteEN = null;
        string oid;

        //Initialized ClienteEN
        clienteEN = new ClienteEN ();
        clienteEN.DNI = p_DNI;

        clienteEN.Nombre = p_nombre;

        clienteEN.Direccion = p_direccion;

        clienteEN.Telefono = p_telefono;

        clienteEN.Pass = Utils.Util.GetEncondeMD5 (p_pass);

        //Call to ClienteRepository

        oid = _IClienteRepository.CrearCliente (clienteEN);
        return oid;
}

public void BorrarCliente (string DNI
                           )
{
        _IClienteRepository.BorrarCliente (DNI);
}

public void Modificar (string p_Cliente_OID, string p_nombre, string p_direccion, string p_telefono, String p_pass)
{
        ClienteEN clienteEN = null;

        //Initialized ClienteEN
        clienteEN = new ClienteEN ();
        clienteEN.DNI = p_Cliente_OID;
        clienteEN.Nombre = p_nombre;
        clienteEN.Direccion = p_direccion;
        clienteEN.Telefono = p_telefono;
        clienteEN.Pass = Utils.Util.GetEncondeMD5 (p_pass);
        //Call to ClienteRepository

        _IClienteRepository.Modificar (clienteEN);
}

public string Login (string p_Cliente_OID, string p_pass)
{
        string result = null;
        ClienteEN en = _IClienteRepository.ReadOIDDefault (p_Cliente_OID);

        if (en != null && en.Pass.Equals (Utils.Util.GetEncondeMD5 (p_pass)))
                result = this.GetToken (en.DNI);

        return result;
}




private string Encode (string DNI)
{
        var payload = new Dictionary<string, object>(){
                { "DNI", DNI }
        };
        string token = Jose.JWT.Encode (payload, Utils.Util.getKey (), Jose.JwsAlgorithm.HS256);

        return token;
}

public string GetToken (string DNI)
{
        ClienteEN en = _IClienteRepository.ReadOIDDefault (DNI);
        string token = Encode (en.DNI);

        return token;
}
public string CheckToken (string token)
{
        string result = null;

        try
        {
                string decodedToken = Utils.Util.Decode (token);



                string id = (string)ObtenerDNI (decodedToken);

                ClienteEN en = _IClienteRepository.ReadOIDDefault (id);

                if (en != null && ((string)en.DNI).Equals (ObtenerDNI (decodedToken))
                    ) {
                        result = id;
                }
                else throw new ModelException ("El token es incorrecto");
        } catch (Exception e)
        {
                throw new ModelException ("El token es incorrecto");
        }

        return result;
}


public string ObtenerDNI (string decodedToken)
{
        try
        {
                Dictionary<string, object> results = JsonConvert.DeserializeObject<Dictionary<string, object> >(decodedToken);
                string dni = (string)results ["DNI"];
                return dni;
        }
        catch
        {
                throw new Exception ("El token enviado no es correcto");
        }
}
}
}
