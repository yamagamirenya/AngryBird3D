using UnityEngine;
using System.Collections;

public class GameToFinish : MonoBehaviour {


    public GameObject Man;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject == Man)
        {
            Application.LoadLevel("Finish");
        }
    }
	
}
