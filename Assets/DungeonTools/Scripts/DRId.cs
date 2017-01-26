using UnityEngine;

public class DRId : MonoBehaviour
{

	public int id = -1;

	void Start ()
	{
		/*
		CreateCollider ();
		GetComponent<MeshRenderer> ().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.Off;
		*/
	}

	/// <summary>
	/// Método que genera el collider adecuado para cada muro y para el suelo
	/// </summary>
	private void CreateCollider ()
	{
		switch (gameObject.name) {
		case "ICornerTL":
			AddColliders ();
			GetComponents<BoxCollider> () [0].center = new Vector3 (-0.25f, 1.25f, -1.25f);
			GetComponents<BoxCollider> () [1].center = new Vector3 (1.25f, 1.25f, 0.25f);
			break;

		case "ICornerTR":
			AddColliders ();
			GetComponents<BoxCollider> () [0].center = new Vector3 (0.25f, 1.25f, -1.25f);
			GetComponents<BoxCollider> () [1].center = new Vector3 (-1.25f, 1.25f, 0.25f);
			break;

		case "ICornerBL":
			AddColliders ();
			GetComponents<BoxCollider> () [0].center = new Vector3 (-0.25f, 1.25f, 1.25f);
			GetComponents<BoxCollider> () [1].center = new Vector3 (1.25f, 1.25f, -0.25f);
			break;

		case "ICornerBR":
			AddColliders ();
			GetComponents<BoxCollider> () [0].center = new Vector3 (0.25f, 1.25f, 1.25f);
			GetComponents<BoxCollider> () [1].center = new Vector3 (-1.25f, 1.25f, -0.25f);
			break;

		default:
			gameObject.AddComponent<BoxCollider> ();
			break;

		}
	}

	/// <summary>
	/// Método que genera los colliders necesarios para las esquinas y les da el tamaño adecuado
	/// </summary>
	private void AddColliders ()
	{
		gameObject.AddComponent<BoxCollider> ();
		gameObject.AddComponent<BoxCollider> ();
		GetComponents<BoxCollider> () [0].size = new Vector3 (0.5f, 2.5f, 2.5f);
		GetComponents<BoxCollider> () [1].size = new Vector3 (2.5f, 2.5f, 0.5f);
	}
}
