using UnityEngine;
using Aznal;

public class ItemInterpreter : MonoBehaviour
{

	public static void Execute (string item)
	{
		switch (item) {
		case "TestItem":
			ItemFunctions.TripleShoot ();
			break;
        
		case "TestItem2":
			ItemFunctions.DoubleShot ();
			break;
		}
	}
}

