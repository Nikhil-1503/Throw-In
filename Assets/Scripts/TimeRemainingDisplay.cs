using UnityEngine;
using UnityEngine.UI;
using System;

public class TimeRemainingDisplay : MonoBehaviour {
    Text text;
    LevelManager levelManager;

    //Initializing
    void Start () {
        text = GetComponent<Text>();
        levelManager = FindObjectOfType<LevelManager>();
	}
	
    // Update call per frame
        void Update () {
        text.text = "Time Remaining: " + Convert.ToInt32(levelManager.timeTillNextLevel);
	}
}
