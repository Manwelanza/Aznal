using UnityEngine;

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

	public static void ShootDelayDown (float number)
	{
		if (Aznal.Game.instancia.player.shootDelay - number < 1) {
			Aznal.Game.instancia.player.shootDelay = 1;
		} else {
			Aznal.Game.instancia.player.shootDelay -= number;
		}
	}

	public static void DoubleShoot ()
	{
		GameObject gun = GameObject.Find ("Player/Gun");
		Vector3 gunPosition = gun.transform.position;
		GameObject gunObject = Instantiate (Resources.Load ("Gun", typeof(GameObject)),
			                       new Vector3 (gunPosition.x + 1, gunPosition.y, gunPosition.z), gun.transform.rotation) as GameObject;
		gunObject.transform.parent = GameObject.Find ("Player").transform;
	}
}
