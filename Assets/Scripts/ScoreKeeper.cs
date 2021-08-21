using UnityEngine;
using System.Collections;

public class ScoreKeeper : MonoBehaviour{
	public int score = 0;

    	//Initializing
    	void Start(){
        		DontDestroyOnLoad(gameObject);
    	}

	void update(){}

    	public void IncrementScore(int amount){
        		score += amount;
        		AudioSource source = GetComponent<AudioSource>();
        		source.Play();
    	}
}
