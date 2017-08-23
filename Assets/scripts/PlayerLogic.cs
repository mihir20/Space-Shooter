using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLogic : MonoBehaviour {

    public GameObject projectile;
    public bool isShooting = true;
    public float shootingTime = 0.5f;
    float projectileCollisionOffSet = 2.0f;

    public float playerSpeed = 0.25f;
    float maxDistanceX = 30.0f;

	// Use this for initialization
	void Start () {
        StartCoroutine(projectileShootTimer());
	}
	
	// Update is called once per frame
	void Update () {
        PlayerMovement();
	}
    void PlayerMovement()
    {
        if (Input.GetKey(KeyCode.D) && transform.position.x <= maxDistanceX) {
            transform.Translate(playerSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.A) && transform.position.x >= -maxDistanceX)
        {
            transform.Translate(-playerSpeed, 0, 0);
        }
    }
    IEnumerator projectileShootTimer() {
        while (isShooting == true) {
            spwanProjectile();
            yield return new WaitForSeconds(shootingTime);
            }
    }

    void spwanProjectile()
    {
        Instantiate(projectile, new Vector3(transform.position.x,transform.position.y+projectileCollisionOffSet,0), Quaternion.identity);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="collision") { SceneManager.LoadScene("spaceShooter");
        }
    }
}
