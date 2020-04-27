using UnityEngine.UI;
using UnityEngine;

public class TextScoreScript : MonoBehaviour
{
    private Text textScore;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        textScore = GameObject.FindGameObjectWithTag("TextScore").GetComponent<Text>();
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        textScore.text = gameManager.getScore().ToString();
    }
}
