using UnityEngine;
using System.Collections;
using Aznal;

public class PlayerMove : MonoBehaviour
{
	private MPlayer player;
	private Rigidbody body;

	// Use this for initialization
	void Start ()
	{
		body = GetComponent<Rigidbody> ();
		player = Game.instancia.player;
	}
	
	// Update is called once per frame
	void Update ()
	{
		MovePlayer ();
		LookAtMouse ();
		Dodge ();
	}

	/// <summary>
	/// Método que mueve al jugador
	/// </summary>
	private void MovePlayer ()
	{

		if (!player.dodging) {
			float XMovement = Input.GetAxis ("Horizontal") * player.speed;
			float YMovement = Input.GetAxis ("Vertical") * player.speed;

			body.velocity = new Vector3 (XMovement, 0, YMovement);
		}
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
	/// Método que hace que el personaje esquive
	/// </summary>
	private void Dodge ()
	{
		if (!player.dodging) {
			if (Input.GetKeyDown (KeyCode.Space)) {
				player.Dodge ();
				StartCoroutine (Dodging ());
			}
		}
	}

	/// <summary>
	/// Corrutina para esquivar
	/// </summary>
	/// <returns></returns>
	private IEnumerator Dodging ()
	{
		Shader shader = GetComponent<MeshRenderer> ().material.shader;
		Color color = GetComponent<MeshRenderer> ().material.color;
		GetComponent<MeshRenderer> ().material.shader = Shader.Find ("Transparent/Diffuse");
		GetComponent<MeshRenderer> ().material.color = new Color (0, 255, 0, 0.2f);
		float count = 0;
		float aux = 360 / player.timeDodging;
		while (count <= 360) {
			// TODO: HACER QUE ROTE!
			count += aux;
			yield return 0;
		}
		GetComponent<MeshRenderer> ().material.shader = shader;
		GetComponent<MeshRenderer> ().material.color = color;
		player.StopDodge ();
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

	void OnTriggerEnter (Collider collider)
	{
		if (collider.tag == "Item") {
			Destroy (collider.gameObject);
			ItemInterpreter.Execute (collider.name);
		}
	}

}
