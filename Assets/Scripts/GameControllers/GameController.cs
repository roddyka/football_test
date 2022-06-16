using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameController : MonoBehaviour
{
    public static GameController instance;
    public int score1Int; 
    public int score2Int; 
    public Text score1; 
    public Text score2; 

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        score1.text = score1Int.ToString();
        score2.text = score2Int.ToString();
    }

    public void updateScoreText(string goal){
        if(goal == "goal1") {
            score1Int += 1;
            score1.text = score1Int.ToString();
        } 
        else if(goal == "goal2"){
            score2Int += 1;
            score2.text = score2Int.ToString();
        }
    }
}
