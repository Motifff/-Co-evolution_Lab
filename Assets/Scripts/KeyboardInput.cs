using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardInput : MonoBehaviour
{
    private Transform _t;
    private float _rotateAngle;
    // Start is called before the first frame update
    void Start()
    {
        _rotateAngle = 0.0f;
    }
    
    void SetZRotation(float angle)
    {
        Vector3 currentRotation = transform.eulerAngles;
        currentRotation.z = angle;
        transform.eulerAngles = currentRotation;
    }
    
    // Update is called once per frame
    void Update()
    {
        _rotateAngle = _rotateAngle - Input.GetAxis("Horizontal")*0.5f;
        if (_rotateAngle > 30 || _rotateAngle < -30)
        {
            if (_rotateAngle > 30)
            {
                _rotateAngle = 30;
            }
            else
            { 
                _rotateAngle = -30;
            }
        }

        SetZRotation(_rotateAngle);
        if(!Input.anyKeyDown)
        {
            if (_rotateAngle > 0)
            {
                _rotateAngle -= 0.1f;
            }
            else
            {
                _rotateAngle += 0.1f;
            }
            SetZRotation(_rotateAngle);
        }
    }
}
