using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorcontroller : MonoBehaviour
{
    public Animator animator;

  
    private void OnTriggerEnter(Collider other)
    {
       Debug.Log(other.tag);
       
       
        if(other.tag == "Player"){
            animator.SetBool("open",true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player"){
            animator.SetBool("open",false);
        }
    }
}



