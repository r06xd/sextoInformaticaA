using System;

/// <summary>
/// Adaptador para el envio de SMS
/// </summary>
public class SmsNotificacionAdapter:INotificacionesServices
{
    private ISms _tipoNotificacionSMS;
	public SmsNotificacionAdapter(ISms sms)
	{
        _tipoNotificacionSMS=sms;

    }

    /// <summary>
    /// Metodo que viene de la injeccion de notificaciones Services
    /// </summary>
    /// <param name="mensaje"></param>
    /// <exception cref="NotImplementedException"></exception>
    public void EnviarNotificacion(string mensaje)
    {
        _tipoNotificacionSMS.EnviarSms(mensaje);
    }
}
