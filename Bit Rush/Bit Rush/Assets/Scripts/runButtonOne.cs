using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class runButtonOne : MonoBehaviour {

    public GameObject yesBit;
    public GameObject noBit;
    public Transform yesStart;
    public Transform noStart;
    public GameObject redEnd;
    public GameObject blueEnd;
    public GameObject laser;
    public Material blueMat;
    public Material redMat;

    private bool redSignal = false;
    private bool blueSignal = false;
    private GameObject done;
    private GameObject congrats;
    private GameObject oops;
    private GameObject run;
    private GameObject replay;
    private GameObject next;
    private GameObject retCon;

    private GameObject[] end;
    private List<GameObject> lasers;

    // Use this for initialization
	void Start () {
        lasers = new List<GameObject>();

        end = new GameObject[2];
        end[0] = redEnd;
        end[1] = blueEnd;

        congrats = GameObject.FindGameObjectWithTag("congrats");
        oops = GameObject.FindGameObjectWithTag("oops");
        run = GameObject.Find("Run Button");
        replay = GameObject.Find("Replay Button");
        next = GameObject.Find("Next Button");
        retCon = GameObject.Find("Return Button");

        congrats.GetComponent<Text>().enabled = false;
        oops.GetComponent<Text>().enabled = false;
        replay.gameObject.SetActive(false);
        next.gameObject.SetActive(false);
        retCon.gameObject.SetActive(false);


        for (int i = 0; i < 5; i++)
        {
            lasers.Add(Instantiate(laser, new Vector3(0, -2 + i, 1), laser.transform.rotation));
        }

        Instantiate(yesBit, yesStart);
        Instantiate(noBit, noStart);
        done = Instantiate(end[(int)Mathf.Round(Random.Range(0f, 1f))], new Vector3(0, 3, 1), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void RunProgram()
    {
        if (blueSignal)
        {
            foreach (GameObject l in lasers)
            {
                l.GetComponent<Renderer>().material = blueMat;
            }

            if (done.CompareTag("blue end"))
            {
                run.gameObject.SetActive(false);
                congrats.GetComponent<Text>().enabled = true;
                replay.gameObject.SetActive(true);
                next.gameObject.SetActive(true);
                retCon.gameObject.SetActive(true);
            }
            else
            {
                run.gameObject.SetActive(false);
                oops.GetComponent<Text>().enabled = true;
                replay.gameObject.SetActive(true);
            }
        }

        if (redSignal)
        {
            foreach (GameObject l in lasers)
            {
                l.GetComponent<Renderer>().material = redMat;
            }

            if (done.CompareTag("red end"))
            {
                run.gameObject.SetActive(false);
                congrats.GetComponent<Text>().enabled = true;
                replay.gameObject.SetActive(true);
                next.gameObject.SetActive(true);
                retCon.gameObject.SetActive(true);
            }
            else
            {
                run.gameObject.SetActive(false);
                oops.GetComponent<Text>().enabled = true;
                replay.gameObject.SetActive(true);
            }

        }
    }

    void OnTriggerStay(Collider bit)
    {
        bit.transform.position = gameObject.transform.position;
    }

    void OnTriggerEnter(Collider bit)
    {
        if(bit.tag == "yes")
        {
            redSignal = false;
            blueSignal = true;
        }

        if (bit.tag == "no")
        {
            redSignal = true;
            blueSignal = false;
        }
    }
}
