using UnityEngine;
using System.Collections;

public class DetectScoring : MonoBehaviour {
    	public int scorePerHit = 1;
	void Start (){}
	void Update (){}

    	private void OnCollisionEnter(Collision collision){
        		ScoreKeeper scoreKeeper = FindObjectOfType<ScoreKeeper>();
        		scoreKeeper.IncrementScore(scorePerHit);
    	}
}
