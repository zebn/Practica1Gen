using System;
using System.Collections.Generic;
using System.Text;

namespace Practica1Gen.ApplicationCore.Utils
{
public class Util
{
public static string GetEncondeMD5 (string password)
{
        System.Security.Cryptography.MD5 md5;
        md5 = new System.Security.Cryptography.MD5CryptoServiceProvider ();
        Byte[] encodedBytes = md5.ComputeHash (ASCIIEncoding.Default.GetBytes (password));
        return System.Text.RegularExpressions.Regex.Replace (BitConverter.ToString (encodedBytes).ToLower (), @"-", "");
}

public static string Decode (string token)
{
        string json = Jose.JWT.Decode (token, Utils.Util.getKey ());

        return json;
}

public static byte[] getKey ()
{
        /*PROTECTED REGION ID(secretKeyPractica1Gen.ApplicationCore) ENABLED START*/
        var secretKey = new byte[] { 164, 60, 194, 0, 161, 189, 41, 38, 130, 89, 141, 164, 45, 170, 159, 209, 69, 137, 243, 216, 191, 131, 47, 250, 32, 107, 231, 117, 37, 158, 225, 234 };

        /*PROTECTED REGION END*/

        return secretKey;
}
}
}
