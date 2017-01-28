using UnityEngine;
using Aznal;
using System;

public class ItemFunctions : MonoBehaviour
{
	#region "Modificador de atributo"

	public static void AttributeUp (string attribute, float number)
	{
        Game.instancia.player.ModifyAttribute(attribute, number);
    }

	public static void AttributeDown (string attribute, float number)
	{
        Game.instancia.player.ModifyAttribute(attribute, -number);
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

	// Angulos de disparo máximo y mínimo (Cambiarlos a placer)
	private const float MAX_SHOOT_ANGLE = 30;

	public static void SetNumberOfGuns (int numero)
	{
		DelteGuns ();
		for (int i = 0; i < numero; i++) {
			AddGun ();
		}
		GunAngleCorrection ();
	}

	private static void AddGun ()
	{
		GameObject player = GameObject.FindGameObjectWithTag ("Player");
		GameObject gunObject = Instantiate (Resources.Load ("Gun", typeof(GameObject)), Vector3.zero, Quaternion.identity) as GameObject;
		gunObject.transform.parent = GameObject.Find ("Player/Guns").transform;
		gunObject.transform.localPosition = Vector3.zero;
		gunObject.transform.name = "Gun";
	}


	// TODO: Arreglar esto que por alguna razón nunca asigna el valor de -30 bien, todo mu raro
	private static void GunAngleCorrection ()
	{
		GameObject[] guns = GameObject.FindGameObjectsWithTag ("Gun");
		float numberOfGuns = guns.Length;
		if (numberOfGuns == 1) {
			guns [0].transform.localRotation = Quaternion.Euler (0, 0, 0);
		} else {
			float actual = -MAX_SHOOT_ANGLE;
			float incremento = (MAX_SHOOT_ANGLE * 2) / (numberOfGuns - 1);

			for (int i = 0; i < guns.Length; i++) {
				guns [i].transform.localRotation = Quaternion.Euler (0, actual, 0);
				actual += incremento;
			}
		}
	}

	private static void DelteGuns ()
	{
		GameObject[] guns = GameObject.FindGameObjectsWithTag ("Gun");
		foreach (GameObject gun in guns) {
			Destroy (gun.gameObject);
		}
	}

	private static int GetNumberOfGuns ()
	{
		return GameObject.FindGameObjectsWithTag ("Gun").Length;
	}

	public static void DoubleShot ()
	{

		SetNumberOfGuns (GetNumberOfGuns () * 2);
	}

	public static void TripleShoot ()
	{
		SetNumberOfGuns (GetNumberOfGuns () * 3);
	}


	#endregion
}
