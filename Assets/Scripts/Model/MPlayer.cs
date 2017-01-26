namespace Aznal
{
	public class MPlayer
	{
		#region "Constantes "

		public const string HEALTH = "HEALTH";
		public const string SPEED = "SPEED";
		public const string DAMAGE = "DAMAGE";
		public const string SHOOT_SPEED = "SHOT_SPEED";
		public const string SHOOT_DELAY = "SHOOT_DELAY";
		public const string TIME_DODGING = "TIME_DODGING";
		public const string DODGE_SPEED = "DODGE_SPEED";

		#endregion

		#region "Public Variables"

		public float health { get; set; }

		public float speed { get; set; }

		public float damage { get; set; }

		public float shootSpeed { get; set; }

		public float shootDelay { get; set; }

		public float timeDodging { get; set; }

		public float dodgeSpeed { get; set; }

		public bool dodging { get; set; }
		//TODO: Añadir nuevas variables cuando sea necesario

		#endregion

		public MPlayer ()
		{
			health = 50;
			speed = 10;
			shootSpeed = 10;
			shootDelay = 3;
			damage = 5;
			timeDodging = 60f;
			dodging = false;
			dodgeSpeed = 15;
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


