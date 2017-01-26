using UnityEngine;
using System.Collections;
using Aznal;

public class BulletController : MonoBehaviour
{

	private MPlayer player;
	private bool InstantiateSpeed = true;

	void Start ()
	{
		player = Aznal.Game.instancia.player;
	}

	// Update is called once per frame
	void Update ()
	{
		float speed = player.shootSpeed * Time.deltaTime;
		if (InstantiateSpeed) {
			transform.Translate (new Vector3 (speed, 0, speed), GameObject.Find ("Gun").transform);
			InstantiateSpeed = false;
		} else {
			transform.Translate (new Vector3 (speed, 0, speed), transform);
		}
		StartCoroutine (DestroyBullet ());

	}

	/// <summary>
	/// Corrutina para destruir la bala después de un tiempo
	/// </summary>
	/// <returns>The bullet.</returns>
	private IEnumerator DestroyBullet ()
	{
		while (true) {
			yield return new WaitForSeconds (2f);
			Destroy (this.gameObject);
		}
	}

	void OnTriggerEnter (Collider collider)
	{
		if (collider.tag != "Player" && collider.tag != "PlayerBullet") {
			Destroy (this.gameObject);
		}
	}
}
