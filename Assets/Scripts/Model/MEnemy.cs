// Para un enemigo básico para hacer pruebas.
// TODO: Mirar como hacmos para tener varios tipos de enemigos
public class MEnemy
{
	#region "Public Variables"

	public float health { get; set; }

	public float speed { get; set; }

	public float shotSpeed { get; set; }

	public float damage { get; set; }

	#endregion

	public MEnemy ()
	{
		health = 15f;
		speed = 10f;
		shotSpeed = 5f;
		damage = 3f;
	}
}
