using UnityEngine;

public class CameraMove : MonoBehaviour
{
	public Transform playerTransform;

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.position = new Vector3 (playerTransform.position.x, transform.position.y, playerTransform.position.z);
	}
}
