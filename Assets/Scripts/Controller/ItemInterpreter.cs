using UnityEngine;

public class ItemInterpreter : MonoBehaviour
{
	public void Execute (string item)
	{
		switch (item) {
		case "Ta Wapo TT":
			ItemFunctions.DamageUp (1f);
			ItemFunctions.ShootDelayDown (2f);
			break;
		case "Pa La Virgen":
			ItemFunctions.DamageUpPercent (50f);
			ItemFunctions.DoubleShoot ();
			break;
		}
	}
}
