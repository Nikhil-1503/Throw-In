using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour {
    	ScoreKeeper scoreKeeper;
    	Text text;

	// Initializing
	void Start (){
        		scoreKeeper = FindObjectOfType<ScoreKeeper>();
        		text = GetComponent<Text>();
	}
	
	void Update (){
       		text.text = "Score: " + scoreKeeper.score;
	}
}
