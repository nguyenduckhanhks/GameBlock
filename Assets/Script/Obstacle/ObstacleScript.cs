using UnityEngine;

public class ObstacleScript : MonoBehaviour
{
    public Rigidbody rigibody;
    public float forwardForce = 1000;
    public Transform player;

    private GameManager gameManager ;
    private bool isOverCome = false;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameManager.getIsEndGame())
        {
            rigibody.AddForce(0, 0, -forwardForce * Time.deltaTime);
        }
        if( !isOverCome &&  player.position.z > transform.position.z)
        {
            gameManager.scoreUp();
            isOverCome = true;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "End Obstacle")
        {
            Destroy(this.gameObject);
        }
        if(collision.gameObject.tag == "Player")
        {
            gameManager.endGame();
        }
    }
}
