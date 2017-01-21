using UnityEngine;

public class Shoot : MonoBehaviour
{

	public GameObject balaObject;

	// Use this for initialization
	void Start ()
	{

	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetMouseButtonDown (0)) {
			GameObject bala = Instantiate (balaObject, transform.position, transform.rotation);
			bala.transform.parent = GameObject.Find ("Bullets").transform;
		}
	}
}
