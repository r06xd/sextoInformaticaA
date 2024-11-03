using System;

/// <summary>
/// Servicio de notificaciones
/// </summary>
public interface INotificacionesServices
{
	/// <summary>
	/// Nevio generico de notificacion
	/// </summary>
	/// <param name="mensaje"></param>
	void EnviarNotificacion(string mensaje);
}
