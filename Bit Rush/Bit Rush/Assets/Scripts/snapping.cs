using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snapping : MonoBehaviour {

    public bool redSig;
    public bool blueSig;
    
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void setSignal(bool Rsig, bool Bsig)
    {
        redSig = Rsig;
        blueSig = Bsig;
    }

    public bool getRedSignal()
    {
        return redSig;
    }

    public bool getBlueSignal()
    {
        return blueSig;
    }

    void OnTriggerStay(Collider bit)
    {
        bit.transform.position = gameObject.transform.position;
    }

    void OnTriggerEnter(Collider bit)
    {
        if (bit.tag == "yes")
        {
            setSignal(false, true);
        }

        if (bit.tag == "no")
        {
            setSignal(true, false);
        }

    }
}
