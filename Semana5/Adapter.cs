using System;

/// <summary>
/// Espacio para el ejecutar el ejemplo de ADAPTER
/// </summary>
public class Adapter
{
	private IEmail email;
	public Adapter()
	{
	}

	/// <summary>
	/// Metodo que llama a los adapter de email y SMS para su prueba
	/// </summary>
	public void EjecutarAdapter() 
	{
		INotificacionesServices emailNotificacionAdapter = new EmailNotificacionAdapter(new Email());
        INotificacionesServices smsNotificacionAdapter = new SmsNotificacionAdapter(new Sms());
        emailNotificacionAdapter.EnviarNotificacion("Ejecucion de ejemplo email");
		smsNotificacionAdapter.EnviarNotificacion("Ejecucion de ejemplo SMS");


    }
}
