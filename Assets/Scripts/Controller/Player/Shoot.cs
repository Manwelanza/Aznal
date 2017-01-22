using UnityEngine;

public class Shoot : MonoBehaviour
{
	public GameObject balaObject;

	// Update is called once per frame
	void Update ()
	{		
		if (Input.GetMouseButtonDown (0)) {
			GameObject bullet = Instantiate (balaObject, transform.position, Quaternion.identity);
			bullet.transform.parent = GameObject.Find ("Bullets").transform;
			bullet.transform.Rotate (new Vector3 (transform.eulerAngles.x, transform.eulerAngles.y - 45, transform.eulerAngles.z));
		}
	}
}
