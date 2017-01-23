namespace Aznal
{
	public class MPlayer
	{
		#region "Public Variables"

		public float health { get; set; }

		public float speed { get; set; }

		public float shotSpeed { get; set; }

		public float damage { get; set; }

		public float timeDodging { get; set; }

		public bool dodging { get; set; }

		public float shootDelay { get; set; }
		//TODO: Añadir nuevas variables cuando sea necesario

		#endregion

		public MPlayer ()
		{
			health = 50;
			speed = 10;
			shotSpeed = 10;
			shootDelay = 3;
			damage = 5;
			timeDodging = 60f;
			dodging = false;
		}

		public void Dodge ()
		{
			dodging = true;
		}

		public void StopDodge ()
		{
			dodging = false;
		}

	}
}


