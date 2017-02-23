using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End : MonoBehaviour {
    private bool signal;
    public Button in1;
    private SpriteRenderer tsprite;
    // Use this for initialization
    void Start () {
        tsprite = GetComponent<SpriteRenderer>();
        signal = false;
    }
	
	// Update is called once per frame
	void Update () {
        signal = in1.getsignal();
        if (signal)
        {
            tsprite.color = Color.yellow;
        }
        else
        {
            tsprite.color = Color.blue;
        }
    }

    private void finishlevel()
    {

    }
}
