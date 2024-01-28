using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideTrigger : MonoBehaviour
{
    public Animator playerAnimator; // Assign this in the Inspector
    public float blendValue; // The value to set the blend parameter to

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) // Check if the collider belongs to the Player
        {
            playerAnimator.SetBool("isHit", true); // Modify the blend tree parameter
        }
        Debug.Log("Trigged");
    }
}
