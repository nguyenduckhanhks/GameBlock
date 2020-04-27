using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float forceX = 100;

    private GameManager gameManager;
    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }
    private void Update()
    {
        if (transform.position.y < 0)
        {
            //end game
            gameManager.endGame();
        }
        if (Input.GetKey("d"))
        {
            this.GetComponent<Rigidbody>().AddForce(forceX * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            this.GetComponent<Rigidbody>().AddForce(-forceX * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Obstacle" || transform.position.y < 1)
        {
            //end game
            gameManager.endGame();
        }
    }
}
