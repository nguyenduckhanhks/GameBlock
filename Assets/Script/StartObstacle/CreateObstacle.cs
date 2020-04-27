using UnityEngine;

public class CreateObstacle : MonoBehaviour
{
    public GameObject obstacle;

    private float preTime;
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        preTime = Time.time;
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time - preTime >= 1 && !gameManager.getIsEndGame())
        {
            Vector3 newPosition = obstacle.transform.position;
            newPosition = newPosition + new Vector3(Random.Range(-7, 7), 0, 0);
            Instantiate(obstacle, newPosition,Quaternion.identity);
           
            preTime = Time.time;
        } 
    }
}
