using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SyncPosition : MonoBehaviour
{
    private Animator _animator;
    private float _extent = 0.0f;
    private SeaOfParticles _seaOfParticles;
    private float _initHeightScale;
    
    // assign a game object ref
    public GameObject target;
    // set offset extent
    public float extent = 3.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
        // get "Sea of Particles" script component
        _seaOfParticles = target.GetComponent<SeaOfParticles>();
        _initHeightScale = _seaOfParticles.heightScale;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        
        // Set the parameter values
        _animator.SetFloat("Yaxis", vertical);
        _animator.SetFloat("Xaxis", horizontal);
        
        _extent = vertical * vertical+ horizontal * horizontal;
        // set "heigehtScale" value in "Sea of Particles" script
        _seaOfParticles.heightScale = _initHeightScale + _extent * extent;
    }
}
