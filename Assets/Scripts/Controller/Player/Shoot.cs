using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour
{
	public GameObject balaObject;
	private bool canShoot;

	void Start ()
	{
		canShoot = true;
	}

	// Update is called once per frame
	void Update ()
	{
		if ((Input.GetMouseButtonDown (0)) && (!Aznal.Game.instancia.player.dodging) && canShoot) {
			GameObject bullet = Instantiate (balaObject, transform.position, Quaternion.identity);
			bullet.transform.parent = GameObject.Find ("Bullets").transform;
			bullet.transform.Rotate (new Vector3 (transform.eulerAngles.x, transform.eulerAngles.y - 45, transform.eulerAngles.z));
			StartCoroutine (shoot ());
		}
	}

	IEnumerator shoot ()
	{
		canShoot = false;
		yield return new WaitForSeconds (Aznal.Game.instancia.player.shootDelay * 0.1f);
		canShoot = true;
	}
}
