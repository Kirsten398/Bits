using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {
    private bool signal;
    private SpriteRenderer tsprite;
	// Use this for initialization
	void Start () {
        tsprite = GetComponent<SpriteRenderer>();
        signal = false;
        updatecolor(signal);
	}
	void OnMouseDown()
    {
        updatecolor(!signal);
    }
	// Update is called once per frame
	void Update () {

	}

    public bool getsignal()
    {
        return signal;
    }

    public void changethis()
    {
        signal = !signal;
    }

    public void updatecolor(bool ssignal)
    {
        signal = ssignal;
        if (ssignal)
        {
            tsprite.color = Color.green;
        }
        else
        {
            tsprite.color = Color.red;
        }
    }
}
