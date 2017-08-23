using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveTransformDown : MonoBehaviour {
    public float transformSpeed = 0.1f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        moveToBottom();
	}
    void moveToBottom() { transform.Translate(0, -transformSpeed, 0); }
}
