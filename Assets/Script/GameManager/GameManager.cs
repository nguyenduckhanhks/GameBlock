using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool isEndGame = false;
    static private int score = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void endGame()
    {
        isEndGame = true;
        SceneManager.LoadScene("EndGame");
    }

    public void scoreUp()
    {
        score++;
    }

    public bool getIsEndGame()
    {
        return isEndGame;
    }

    public int getScore()
    {
        return score;
    }
}
