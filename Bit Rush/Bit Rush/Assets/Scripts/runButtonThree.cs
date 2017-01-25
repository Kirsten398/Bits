using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class runButtonThree : MonoBehaviour {

    public GameObject start;
    public GameObject yesBit;
    public GameObject noBit;
    public Transform yesStart;
    public Transform noStart;
    public GameObject redEnd;
    public GameObject blueEnd;
    public GameObject laser;
    public Material blueMat;
    public Material redMat;
    public snapping snap;

    private bool redSignal1 = false;
    private bool redSignal2 = false;
    private bool blueSignal1 = false;
    private bool blueSignal2 = false;
    private GameObject done;
    private GameObject congrats;
    private GameObject oops;
    private GameObject run;
    private GameObject replay;
    private GameObject next;
    private GameObject retCon;

    private GameObject[] end;
    private GameObject[] starts;
    private List<GameObject> startLasers1;
    private List<GameObject> startLasers2;
    private List<GameObject> endLasers;

    // Use this for initialization
    void Start()
    {
        startLasers1 = new List<GameObject>();
        startLasers2 = new List<GameObject>();
        endLasers = new List<GameObject>();

        starts = new GameObject[2];
        starts[0] = Instantiate(start, new Vector3(-1, -3, 1), Quaternion.identity);
        starts[1] = Instantiate(start, new Vector3(1, -3, 1), Quaternion.identity);

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


        for (int i = 0; i < 2; i++)
        {
            startLasers1.Add(Instantiate(laser, new Vector3(-1, -2 + i, 1), laser.transform.rotation));
            startLasers2.Add(Instantiate(laser, new Vector3(1, -2 + i, 1), laser.transform.rotation));
            endLasers.Add(Instantiate(laser, new Vector3(0, 1 + i, 1), laser.transform.rotation));
            Instantiate(yesBit, yesStart);
            Instantiate(noBit, noStart);
        }

        done = Instantiate(end[(int)Mathf.Round(Random.Range(0f, 1f))], new Vector3(0, 3, 1), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void RunProgram()
    {
        Debug.Log("Program Staato!");

        blueSignal1 = starts[0].GetComponent<snapping>().getBlueSignal();
        redSignal1 = starts[0].GetComponent<snapping>().getRedSignal();
        blueSignal2 = starts[1].GetComponent<snapping>().getBlueSignal();
        redSignal2 = starts[1].GetComponent<snapping>().getRedSignal();

        Debug.Log(blueSignal1 + ", " + blueSignal2 + ", " + redSignal1 + ", " + redSignal2);


        if (blueSignal1 && redSignal2)
        {
            foreach (GameObject l in startLasers1)
            {
                l.GetComponent<Renderer>().material = blueMat;
            }

            foreach (GameObject k in startLasers2)
            {
                k.GetComponent<Renderer>().material = redMat;
            }

            foreach (GameObject m in endLasers)
            {
                m.GetComponent<Renderer>().material = redMat;
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

        if (redSignal1 && blueSignal2)
        {
            foreach (GameObject l in startLasers1)
            {
                l.GetComponent<Renderer>().material = redMat;
            }

            foreach (GameObject k in startLasers2)
            {
                k.GetComponent<Renderer>().material = blueMat;
            }

            foreach (GameObject m in endLasers)
            {
                m.GetComponent<Renderer>().material = redMat;
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

        if (blueSignal1 && blueSignal2)
        {
            foreach (GameObject l in startLasers1)
            {
                l.GetComponent<Renderer>().material = blueMat;
            }

            foreach (GameObject k in startLasers2)
            {
                k.GetComponent<Renderer>().material = blueMat;
            }

            foreach (GameObject m in endLasers)
            {
                m.GetComponent<Renderer>().material = blueMat;
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

        if (redSignal1 && redSignal2)
        {
            foreach (GameObject l in startLasers1)
            {
                l.GetComponent<Renderer>().material = redMat;
            }

            foreach (GameObject k in startLasers2)
            {
                k.GetComponent<Renderer>().material = redMat;
            }

            foreach (GameObject m in endLasers)
            {
                m.GetComponent<Renderer>().material = redMat;
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
}
