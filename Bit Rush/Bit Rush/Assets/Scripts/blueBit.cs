using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blueBit : MonoBehaviour {

    public GameObject redBit;
    public Transform redStart;
    
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider otherBit)
    {
        Destroy(otherBit.gameObject);

        Instantiate(redBit, redStart.position, Quaternion.identity);
    }
}
