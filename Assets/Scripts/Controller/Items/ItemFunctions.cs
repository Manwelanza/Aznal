using UnityEngine;
using Aznal;
using System;

public class ItemFunctions : MonoBehaviour
{
	#region "Attribute modifiers"

	public static void AttributeUp (string attribute, float number)
	{
		Game.instancia.player.ModifyAttribute (attribute, number);
	}

	public static void AttributeDown (string attribute, float number)
	{
		Game.instancia.player.ModifyAttribute (attribute, -number);
	}

	public static void AttributePercentUp (string attribute, float percent)
	{
		Game.instancia.player.ModifyPercent (attribute, percent);

	}

	public static void AttributePercentDown (string attribute, float percent)
	{
		Game.instancia.player.ModifyPercent (attribute, -percent);
	}

	public static void AttributeSet (string attribute, float number)
	{
		Game.instancia.player.Set (attribute, number);
	}

	#endregion

	#region "Shot modifiers"

	/// <summary>
	/// Máximo angulo que se utilizará para el disparo, si este angulo es más grande el disparo será más disperso.
	/// Si es más pequeño el disparo será más concentrado.
	/// TODO IDEA: Poner esta dispersión como una variable del personaje para modificar el disparo.
	/// </summary>
	private const float MAX_SHOOT_ANGLE = 5;

	public static void SetNumberOfGuns (int numero)
	{
		Shoot shoot = GameObject.FindGameObjectWithTag ("Gun").GetComponent<Shoot> ();
		DelteGuns ();
		for (int i = 0; i < numero; i++) {
			AddGun (shoot);
		}
		GunAngleCorrection ();
	}

	private static void AddGun (Shoot shoot)
	{
		GameObject gunObject = Instantiate (new GameObject (), Vector3.zero, Quaternion.identity) as GameObject;
		gunObject.AddComponent (shoot.GetType ());
		gunObject.GetComponent<Shoot> ().balaObject = shoot.balaObject;
		gunObject.tag = "Gun";
		gunObject.transform.parent = GameObject.Find ("Player/Guns").transform;
		gunObject.transform.localPosition = Vector3.zero;
		gunObject.transform.name = "Gun";
	}

	private static void GunAngleCorrection ()
	{
		
		GameObject[] guns = GameObject.FindGameObjectsWithTag ("Gun");
		float numberOfGuns = guns.Length;
		if (numberOfGuns == 1) {
			guns [0].transform.localRotation = Quaternion.Euler (0, 0, 0);
		} else {
			float actual = -MAX_SHOOT_ANGLE;
			float incremento = (MAX_SHOOT_ANGLE * 2) / (numberOfGuns - 1);

			for (int i = 0; i < guns.Length; i++) {
				guns [i].transform.localRotation = Quaternion.Euler (0, actual, 0);
				actual += incremento;
			}
		}
	}

	private static void DelteGuns ()
	{
		GameObject[] guns = GameObject.FindGameObjectsWithTag ("Gun");
		foreach (GameObject gun in guns) {
			gun.transform.tag = "Untagged";
			Destroy (gun.gameObject);
		}
	}

	private static int GetNumberOfGuns ()
	{
		return GameObject.FindGameObjectsWithTag ("Gun").Length;
	}

	public static void DoubleShot ()
	{
		SetNumberOfGuns (GetNumberOfGuns () * 2);
	}

	public static void TripleShoot ()
	{
		SetNumberOfGuns (GetNumberOfGuns () * 3);
	}


	#endregion
}
