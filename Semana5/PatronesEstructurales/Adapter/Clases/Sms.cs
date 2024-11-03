using System;

/// <summary>
/// Clase con metodos de envio de SMS
/// </summary>
public class Sms:ISms
{
    public void EnviarSms(string mensaje)
    {
        Console.WriteLine("Entra en la clase SMS >> " + mensaje);
    }
}
