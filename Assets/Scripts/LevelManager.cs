using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour{
    	public float timeTillNextLevel = 0.0f;
   	void Start(){}
    	void Update(){
		if (timeTillNextLevel > 0){
            			timeTillNextLevel -= Time.deltaTime;
            			if (timeTillNextLevel < 0){
                			LoadNextScene();
                			print("Load Next Scene");
   			}
        		}
    	}

    	public void LoadNextScene(){
        		int currentIndex = SceneManager.GetActiveScene().buildIndex;
        		SceneManager.LoadScene(currentIndex + 1);
    	}

    	public void LoadPreviousScene(){
        		int currentIndex = SceneManager.GetActiveScene().buildIndex;
        		SceneManager.LoadScene(currentIndex - 1);
    	}
}
