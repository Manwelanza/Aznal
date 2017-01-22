using UnityEngine;
using Aznal;

public class PlayerMove : MonoBehaviour
{
	private MPlayer player;
	private Rigidbody body;

	// Use this for initialization
	void Start ()
	{
        body = GetComponent<Rigidbody> ();
        player = Aznal.Game.instancia.player;
	}
	
	// Update is called once per frame
	void Update ()
	{
		MovePlayer ();
		LookAtMouse ();
	}

	/// <summary>
	/// Método que mueve al jugador
	/// </summary>
	private void MovePlayer ()
	{
		float XMovement = Input.GetAxis ("Horizontal") * player.speed;
		float YMovement = Input.GetAxis ("Vertical") * player.speed;

		body.velocity = new Vector3 (XMovement, 0, YMovement);
	}

	/// <summary>
	/// Método que hace que el personaje mire hacia el ratón
	/// </summary>
	private void LookAtMouse ()
	{
		Vector2 playerPosition = Camera.main.WorldToViewportPoint (transform.position);
		Vector2 mousePosition = (Vector2)Camera.main.ScreenToViewportPoint (Input.mousePosition);
		float angle = AnglesBetweenTwoPoints (playerPosition, mousePosition);
		transform.rotation = Quaternion.Euler (new Vector3 (0, -angle - 90, 0));
	}

	/// <summary>
	/// Ángulo existente entre dos puntos
	/// </summary>
	/// <returns>El ángulo en float entre dos puntos</returns>
	/// <param name="a">Punto A.</param>
	/// <param name="b">Punto B.</param>
	private float AnglesBetweenTwoPoints (Vector3 a, Vector3 b)
	{
		return Mathf.Atan2 (a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
	}

}
