using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionLight : MonoBehaviour
{
    [SerializeField] private Light _motionLight;
// Start is called before the first frame update
    void Start()
    {
        _motionLight.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        _motionLight.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
