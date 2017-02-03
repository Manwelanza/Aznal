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

        #region "Attribute modifiers"
        public void ModifyAttribute (string attribute, float number)
        {
            switch (attribute)
            {
                case DAMAGE:
                    damage += number;
                    break;
                case HEALTH:
                    health += number;
                    break;
                case SHOOT_DELAY:
                    shootDelay += number;
                    break;
                case SHOOT_SPEED:
                    shootSpeed += number;
                    break;
                case TIME_DODGING:
                    timeDodging += number;
                    break;
                case DODGE_SPEED:
                    dodgeSpeed += number;
                    break;
                default:
                    System.Console.Error.WriteLine("¡Valor de atributo erroneo!");
                    break;
            }
        }

        public void ModifyPercent (string attribute, float percent)
        {
            float aux = System.Math.Abs(percent) / 100;
            percent /= System.Math.Abs(percent);
            switch (attribute)
            {
                case DAMAGE:
                    damage += aux * damage * percent;
                    break;
                case HEALTH:
                    health += aux * health * percent;
                    break;
                case SHOOT_DELAY:
                    shootDelay += aux * shootDelay * percent;
                    break;
                case SHOOT_SPEED:
                    shootSpeed += aux * shootSpeed * percent;
                    break;
                case TIME_DODGING:
                    timeDodging += aux * timeDodging * percent;
                    break;
                case DODGE_SPEED:
                    dodgeSpeed += aux * dodgeSpeed * percent;
                    break;
                default:
                    System.Console.Error.WriteLine("¡Valor de atributo erroneo!");
                    break;
            }
        }

        public void Set (string attribute, float number)
        {
            switch (attribute)
            {
                case DAMAGE:
                    damage = number;
                    break;
                case HEALTH:
                    health = number;
                    break;
                case SHOOT_DELAY:
                    shootDelay = number;
                    break;
                case SHOOT_SPEED:
                    shootSpeed = number;
                    break;
                case TIME_DODGING:
                    timeDodging = number;
                    break;
                case DODGE_SPEED:
                    dodgeSpeed = number;
                    break;
                default:
                    System.Console.Error.WriteLine("¡Valor de atributo erroneo!");
                    break;
            }
        }

        public void Dodge ()
		{
			dodging = true;
		}

		public void StopDodge ()
		{
			dodging = false;
		}
        #endregion
    }
}


