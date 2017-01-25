using UnityEngine;
using System.Collections;

public class bitDrag : MonoBehaviour {

    private Vector3 screenPoint;
    private Vector3 offset;
    private float locked_Zposition;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    //click and drag
    void OnMouseDown()
    { 
        locked_Zposition = screenPoint.z;
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
        Cursor.visible = false;
    }

    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        curPosition.z = locked_Zposition;
        transform.position = curPosition;
    }

    void OnMouseUp()
    {
        Cursor.visible = true;
    }
}
