using UnityEngine;
using Aznal;

public class ItemFunctions : MonoBehaviour
{
	#region "Modificador de atributo"

	public static void AttributeUp (string attribute, float number)
	{
		switch (attribute) {
		case MPlayer.DAMAGE:
			Game.instancia.player.damage += number;
			break;
		case MPlayer.HEALTH:
			Game.instancia.player.health += number;
			break;
		case MPlayer.SHOOT_DELAY:
			Game.instancia.player.shootDelay += number;
			break;
		case MPlayer.SHOOT_SPEED:
			Game.instancia.player.shootSpeed += number;
			break;
		case MPlayer.TIME_DODGING:
			Game.instancia.player.timeDodging += number;
			break;
		case MPlayer.DODGE_SPEED:
			Game.instancia.player.dodgeSpeed += number;
			break;
		default:
			System.Console.Error.WriteLine ("¡Valor de atributo erroneo!");
			break;
		}
	}

	public static void AttributeDown (string attribute, float number)
	{
		switch (attribute) {
		case MPlayer.DAMAGE:
			Game.instancia.player.damage -= number;
			break;
		case MPlayer.HEALTH:
			Game.instancia.player.health -= number;
			break;
		case MPlayer.SHOOT_DELAY:
			Game.instancia.player.shootDelay -= number;
			break;
		case MPlayer.SHOOT_SPEED:
			Game.instancia.player.shootSpeed -= number;
			break;
		case MPlayer.TIME_DODGING:
			Game.instancia.player.timeDodging -= number;
			break;
		case MPlayer.DODGE_SPEED:
			Game.instancia.player.dodgeSpeed -= number;
			break;
		default:
			System.Console.Error.WriteLine ("¡Valor de atributo erroneo!");
			break;
		}
	}

	public static void AttributePercentUp (string attribute, float percent)
	{
		float aux;
		switch (attribute) {
		case MPlayer.DAMAGE:
			aux = (Game.instancia.player.damage * percent) / 100;
			Game.instancia.player.damage += aux;
			break;
		case MPlayer.HEALTH:
			aux = (Game.instancia.player.health * percent) / 100;
			Game.instancia.player.health += aux;
			break;
		case MPlayer.SHOOT_DELAY:
			aux = (Game.instancia.player.shootDelay * percent) / 100;
			Game.instancia.player.shootDelay += aux;
			break;
		case MPlayer.SHOOT_SPEED:
			aux = (Game.instancia.player.shootSpeed * percent) / 100;
			Game.instancia.player.shootSpeed += aux;
			break;
		case MPlayer.TIME_DODGING:
			aux = (Game.instancia.player.timeDodging * percent) / 100;
			Game.instancia.player.timeDodging += aux;
			break;
		case MPlayer.DODGE_SPEED:
			aux = (Game.instancia.player.dodgeSpeed * percent) / 100;
			Game.instancia.player.dodgeSpeed += aux;
			;
			break;
		default:
			System.Console.Error.WriteLine ("¡Valor de atributo erroneo!");
			break;
		}
	}

	public static void AttributePercentDown (string attribute, float percent)
	{
		float aux;
		switch (attribute) {
		case MPlayer.DAMAGE:
			aux = (Game.instancia.player.damage * percent) / 100;
			Game.instancia.player.damage -= aux;
			break;
		case MPlayer.HEALTH:
			aux = (Game.instancia.player.health * percent) / 100;
			Game.instancia.player.health -= aux;
			break;
		case MPlayer.SHOOT_DELAY:
			aux = (Game.instancia.player.shootDelay * percent) / 100;
			Game.instancia.player.shootDelay -= aux;
			break;
		case MPlayer.SHOOT_SPEED:
			aux = (Game.instancia.player.shootSpeed * percent) / 100;
			Game.instancia.player.shootSpeed -= aux;
			break;
		case MPlayer.TIME_DODGING:
			aux = (Game.instancia.player.timeDodging * percent) / 100;
			Game.instancia.player.timeDodging -= aux;
			break;
		case MPlayer.DODGE_SPEED:
			aux = (Game.instancia.player.dodgeSpeed * percent) / 100;
			Game.instancia.player.dodgeSpeed -= aux;
			;
			break;
		default:
			System.Console.Error.WriteLine ("¡Valor de atributo erroneo!");
			break;
		}
	}

	public static void AttributeSet (string attribute, float number)
	{
		switch (attribute) {
		case MPlayer.DAMAGE:
			Game.instancia.player.damage = number;
			break;
		case MPlayer.HEALTH:
			Game.instancia.player.health = number;
			break;
		case MPlayer.SHOOT_DELAY:
			Game.instancia.player.shootDelay = number;
			break;
		case MPlayer.SHOOT_SPEED:
			Game.instancia.player.shootSpeed = number;
			break;
		case MPlayer.TIME_DODGING:
			Game.instancia.player.timeDodging = number;
			break;
		case MPlayer.DODGE_SPEED:
			Game.instancia.player.dodgeSpeed = number;
			break;
		default:
			System.Console.Error.WriteLine ("¡Valor de atributo erroneo!");
			break;
		}
	}

	#endregion

	#region "Modificadores de disparo"

	public static void DoubleShot ()
	{
		GameObject player = GameObject.Find ("Player");
		GameObject.Find ("Player/Gun").transform.localPosition = new Vector3 (-0.3f, 0, 0.8f);

		GameObject gunObject = Instantiate (Resources.Load ("Gun", typeof(GameObject)), Vector3.zero, player.transform.rotation) as GameObject;
		
		gunObject.transform.parent = GameObject.Find ("Player").transform;
		gunObject.transform.localPosition = new Vector3 (0.3f, 0, 0.8f);

	}

	public static void TripleShoot ()
	{
		GameObject gun = GameObject.Find ("Player/Gun");
		Vector3 gunPosition = gun.transform.position;

		GameObject gunObject = Instantiate (Resources.Load ("Gun", typeof(GameObject)),
			                       new Vector3 (gunPosition.x + 0.5f, gunPosition.y, gunPosition.z + 0.5f), gun.transform.rotation) as GameObject;
		GameObject gunObject2 = Instantiate (Resources.Load ("Gun", typeof(GameObject)),
			                        new Vector3 (gunPosition.x - 0.5f, gunPosition.y, gunPosition.z - 0.5f), gun.transform.rotation) as GameObject;

		gunObject.transform.parent = GameObject.Find ("Player").transform;
		gunObject.transform.localPosition = new Vector3 (0.3f, 0, 0.8f);
		gunObject2.transform.parent = GameObject.Find ("Player").transform;
		gunObject2.transform.localPosition = new Vector3 (-0.3f, 0, 0.8f);
	}

	#endregion
}
