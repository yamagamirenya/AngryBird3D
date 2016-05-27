using UnityEngine;
using System.Collections;

public class SeeHero : MonoBehaviour {


    public Transform target;
    private Vector3 offset;
    private Vector3 Rotation_Change;
    private bool isMouseUp = false;
	
	// Update is called once per frame


void Start()
    {
        // offset = transform.position - target.transform.position;
        offset = new Vector3(10, 0, 0);
        Rotation_Change = new Vector3(0, 90, 0);
    }


	void Update () {

        if (Input.GetMouseButtonUp(0))
        {
            isMouseUp = true;

        }
      


        if (isMouseUp)
        {
            transform.position = target.transform.position - offset;
            transform.eulerAngles = target.transform.eulerAngles + Rotation_Change;

        }
    }
}
