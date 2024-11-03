using System;

/// <summary>
/// Interfaz de SMS
/// </summary>
public interface ISms
{
	/// <summary>
	/// Metodo de la interfaz para llamar al metodo de envio de SMS
	/// </summary>
	/// <param name="mensaje"></param>
	void EnviarSms(string mensaje);
}
