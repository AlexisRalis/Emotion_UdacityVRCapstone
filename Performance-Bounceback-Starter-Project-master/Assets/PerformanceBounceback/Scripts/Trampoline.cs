using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{

    public ParticleSystem pSystem;
    public GameManager gameManager;

    void Start()
    {
        pSystem = GetComponentInChildren<ParticleSystem>();
    }


	void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Throwable"){
            gameManager.score++;
            pSystem.Play();
        }
    }
}

