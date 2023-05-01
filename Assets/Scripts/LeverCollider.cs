using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverCollider : MonoBehaviour
{
    public GameObject switchCanvas;
    public Animator switchAnimation;
    public Animator gateAnimationL;
    public Animator gateAnimationR;
    public AudioSource switchSound;
    public AudioClip creak;
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E)){
            switchAnimation.enabled = true;
            gateAnimationL.enabled = true;
            gateAnimationR.enabled = true;
            switchSound.PlayOneShot(creak);
        }
    }

    void OnTriggerEnter(Collider other){
        if (other.CompareTag("Player")){
            switchCanvas.SetActive(true);
        }
    }


    void OnTriggerExit(Collider other){
            if (other.CompareTag("Player")){
                switchCanvas.SetActive(false);
            }
        }
        
    
}
