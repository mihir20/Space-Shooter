using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpwan : MonoBehaviour {
    public GameObject enemyToSpwan;

    public bool canSpwan = true;
    public float enemySpwanTime = 1.0f;
    public float maxX = 28.0f;
    public float startingY = 22.0f;

    float randomX = 0.0f;

	// Use this for initialization
	void Start () {
        StartCoroutine(spwanEnemyTimer());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    IEnumerator spwanEnemyTimer()
    {
        while (canSpwan==true) {
            spwanEnemy();
            yield return new WaitForSeconds(enemySpwanTime);
        }
    }
    void spwanEnemy() {
        randomX = Random.Range(-maxX, maxX);
        Instantiate(enemyToSpwan, new Vector3 (randomX , startingY, 0),Quaternion.identity);
    }
}
