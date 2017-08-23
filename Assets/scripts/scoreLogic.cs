using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreLogic : MonoBehaviour {
    Text txt;
    public int score = 12;
	// Use this for initialization
	void Start () {
        txt = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void addToScoreVOID() { score = score + 1;
        printScore();
    }

    public void printScore() { txt.text = "Score: " + score; }
}
