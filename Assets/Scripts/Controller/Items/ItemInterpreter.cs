using UnityEngine;
using Aznal;

public class ItemInterpreter : MonoBehaviour
{

    public static void Execute(string item)
    {
        switch (item) {
            case "TestItem":
                ItemFunctions.TripleShoot();
                ItemFunctions.AttributeSet(MPlayer.SHOOT_DELAY, 1);
                break;
        
            case "TestItem2":
			    ItemFunctions.DoubleShot();
                ItemFunctions.AttributeSet(MPlayer.SHOOT_DELAY, 1);
                break;
        }
    }
}

