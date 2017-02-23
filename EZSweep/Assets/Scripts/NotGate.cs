using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotGate : MonoBehaviour {
    public Button in1;
    public Button selfie;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (!in1.getsignal())
        {
            selfie.updatecolor(true);
        }
        else
        {
            selfie.updatecolor(false);
        }
    }
}
