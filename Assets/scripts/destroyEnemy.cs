using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyEnemy : MonoBehaviour {
    scoreLogic addToScore;
    public GameObject particles;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="collision") {

            spwanParticle(collision.transform.position);
            Destroy(collision.gameObject);

            callScoreLogicScript();
        }
    }
    void callScoreLogicScript() {
        addToScore = GameObject.FindGameObjectWithTag("GUI").GetComponent<scoreLogic>();
        addToScore.addToScoreVOID();
    }
   void  spwanParticle(Vector2 temPosition)
    {
        Instantiate(particles, temPosition, Quaternion.identity);
    }
}
