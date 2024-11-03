using System;

/// <summary>
/// Interfaz del primer servicio en este caso tomamos como ejemplo envio de email
/// </summary>
public interface IEmail
{
    /// <summary>
    /// Metodo de la interfaz de envio de email
    /// </summary>
    /// <param name="mensaje"></param>
    void EnviarEmail(string mensaje);
}
