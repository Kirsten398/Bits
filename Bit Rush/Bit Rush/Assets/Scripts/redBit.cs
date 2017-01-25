using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redBit : MonoBehaviour {

    public GameObject blueBit;
    public Transform blueStart;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider otherBit)
    {
        Destroy(otherBit.gameObject);

        Instantiate(blueBit, blueStart.position, Quaternion.identity);
    }
}
