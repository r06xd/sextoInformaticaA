using System;

/// <summary>
/// Clase que implementa la interfaz
/// </summary>
public class Email:IEmail
{
	/// <summary>
	/// metodo para enviar el email
	/// </summary>
	/// <param name="mensaje"></param>
	public void EnviarEmail(string mensaje)
	{
		Console.WriteLine("Entra en la clase Email >> "+mensaje);
	}
}
