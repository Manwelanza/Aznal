using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Aznal;

public class GameController : MonoBehaviour {
    #region "Public variables"
    public static GameController instancia;
    #endregion

    void Awake()
    {
        if (instancia == null)
        {
            Game.instancia = Game.CreateNormalGame();
            instancia = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            DestroyImmediate(this.gameObject);
        }
    }

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
