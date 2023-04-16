using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{   
    [SerializeField] float reloadDelay = 0.5f;
    [SerializeField] ParticleSystem finishEffect;

    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player") {
            finishEffect.Play();
            Invoke("ReloadScene", reloadDelay);
        }
        
    }

    void ReloadScene() {
        SceneManager.LoadScene(0);
    }
}
