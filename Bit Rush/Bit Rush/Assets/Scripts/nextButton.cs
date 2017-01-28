using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class nextButton : MonoBehaviour {

    int thisScene;
    
    // Use this for initialization
	void Start () {
        thisScene = SceneManager.GetActiveScene().buildIndex;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void NextLevel()
    {
        SceneManager.LoadScene(thisScene + 1);
    }
}
