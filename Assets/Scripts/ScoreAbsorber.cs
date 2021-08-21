using UnityEngine;
using System.Collections;

public class ScoreAbsorber : MonoBehaviour {
    	public int score;
	void Start (){
        		ScoreKeeper oldKeeper = FindObjectOfType<ScoreKeeper>();
        		score = 1;

        		if (oldKeeper){
            			score = oldKeeper.score;
            			Destroy(oldKeeper.gameObject);
        		}
	}
	void Update (){}
}
