using UnityEngine;
using Aznal;

public class ItemFunctions : MonoBehaviour
{
	public static void DamageUp (float number)
	{
		Aznal.Game.instancia.player.damage += number;
	}

	public static void DamageUpPercent (float percent)
	{
		float increment = (Aznal.Game.instancia.player.damage * percent) / 100;
		Aznal.Game.instancia.player.damage += increment;
	}

	public static void DoubleShoot ()
	{
		// Este no funciona
		/*
		GameObject gun = GameObject.Find ("Player/Gun");
		Vector3 gunPosition = gun.transform.localPosition;
		Instantiate (Resources.Load ("Assets/Prefabs/Gun", typeof(GameObject)),
			new Vector3 (gunPosition.x, gunPosition.y, gunPosition.z), gun.transform.rotation);
		*/
	}
}
