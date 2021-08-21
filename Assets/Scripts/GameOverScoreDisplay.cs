using UnityEngine;
using UnityEngine.UI;

public class GameOverScoreDisplay : MonoBehaviour {
    	ScoreAbsorber scoreAbsorber;
    	Text text;

    	void Start(){
        		scoreAbsorber = FindObjectOfType<ScoreAbsorber>();
        		text = GetComponent<Text>();
    	}

    	void Update(){
        		text.text = "Score: " + scoreAbsorber.score;
    	}
}
