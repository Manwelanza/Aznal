using UnityEngine;
using System.Collections;

abstract public class Shoot : MonoBehaviour
{
	public GameObject balaObject;
	protected bool canShoot;

	protected IEnumerator shoot ()
	{
		canShoot = false;
		yield return new WaitForSeconds (Aznal.Game.instancia.player.shootDelay * 0.1f);
		canShoot = true;
	}
}
