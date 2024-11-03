using System;
/// <summary>
/// Adaptador para el envio de emails 
/// </summary>
public class EmailNotificacionAdapter : INotificacionesServices
{
	private IEmail _tipoNotificacionEmail;

	/// <summary>
	/// Adaptador para envio de email
	/// </summary>
	/// <param name="ServicioEmail"></param>
	public EmailNotificacionAdapter(IEmail ServicioEmail)
	{
		_tipoNotificacionEmail = ServicioEmail;
    }

	/// <summary>
	/// Metodo que viene de la injeccion de notificaciones Services
	/// </summary>
	/// <param name="mensaje"></param>
    public void EnviarNotificacion(string mensaje)
    {
        _tipoNotificacionEmail.EnviarEmail(mensaje);
    }
}
