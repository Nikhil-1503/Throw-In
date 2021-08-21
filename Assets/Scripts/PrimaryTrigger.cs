using UnityEngine;
using System.Collections;

public class PrimaryTrigger : MonoBehaviour {
	void OnTriggerEnter(Collider collider){
        		SecondaryTrigger trigger = GetComponentInChildren<SecondaryTrigger>();
        		trigger.ExpectCollider(collider);
    	}
}
