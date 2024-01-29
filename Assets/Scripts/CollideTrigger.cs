using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollideTrigger : MonoBehaviour
{
    private Animator _playerAnimator; // Assign this in the Inspector

    // Start is called before the first frame update
    void Start()
    {
        GameObject Player = GameObject.Find("Player");
        _playerAnimator = Player.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) // Check if the collider belongs to the Player
        {
            _playerAnimator.SetBool("isHit", true); // Modify the blend tree parameter
        }
        Debug.Log("Trigged");
    }
}
