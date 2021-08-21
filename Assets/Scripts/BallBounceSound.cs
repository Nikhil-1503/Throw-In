using UnityEngine;
using System.Collections;

public class BallBounceSound : MonoBehaviour {

    private void OnCollisionEnter(Collision collision)
    {
        AudioSource source = GetComponent<AudioSource>();
        source.Play();
    }
}
