using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GetScore : MonoBehaviour {

    public Text scoreText;
    private int score = 0;


	// Use this for initialization
	void Start () {
        scoreText.text = "Score:0 ";

	}
	
	// Update is called once per frame

    void OnCollisionEnter(Collision other)
    {
        score += 10;
        GameObject.Destroy(other.gameObject);

    }

	void Update () {

        scoreText.text = "Score:" + score.ToString();

	}
}
