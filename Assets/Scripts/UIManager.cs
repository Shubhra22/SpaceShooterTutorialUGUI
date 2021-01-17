using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    // 1. name
    // 2. Arguments.
    // 3. Return type.(void)
    
    public Text scoreText;
    public Text healthText;

    private int totalScore = 0;
  
    // Start is called before the first frame update
    void Start()
    {
        //int i = UpdateScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void UpdateScore(int score)
    {
        totalScore = totalScore + score;
        scoreText.text = "Points: "+totalScore;
    }
    
    public void UpdateHealth(int health)
    {
        healthText.text = "Health: " + health;
    }
    
}
