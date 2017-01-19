using UnityEngine;

public class PlayerMove : MonoBehaviour
{
	private float speed = 10f;

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		float YMovement = Input.GetAxis ("Vertical") * speed;
		float XMovement = Input.GetAxis ("Horizontal") * speed;

		YMovement *= Time.deltaTime;
		XMovement *= Time.deltaTime;

		transform.Translate (XMovement, 0, YMovement);

		// Esta mierda no funciona, es para mirar hacia el mouse y paso de mirarlo ahora.
		/*
		Vector2 playerPosition = Camera.main.WorldToViewportPoint (transform.position);
		Vector2 mousePosition = (Vector2)Camera.main.ScreenToViewportPoint (Input.mousePosition);
		float angle = AnglesBetweenTwoPoints (playerPosition, mousePosition);

		transform.rotation = Quaternion.Euler (new Vector3 (0, angle, 0));
		*/
	}


	float AnglesBetweenTwoPoints (Vector3 a, Vector3 b)
	{
		return Mathf.Atan2 (a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
	}
}
