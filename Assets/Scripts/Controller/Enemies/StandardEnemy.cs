using UnityEngine;

public class StandardEnemy : MonoBehaviour
{
	private MEnemy enemy;

	void Start ()
	{
		enemy = Aznal.Game.instancia.enemy;
	}

	void Update ()
	{
		if (enemy.health <= 0) {
			Destroy (gameObject);
		}
	}

	void OnTriggerEnter (Collider collider)
	{
		if (collider.tag == "PlayerBullet") {
			enemy.health -= Aznal.Game.instancia.player.damage;
		}
	}
}
