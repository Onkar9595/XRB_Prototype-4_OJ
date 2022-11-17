using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MotionLight : MonoBehaviour
{
    [SerializeField] private Light _motionLight;
  

    public bool isFlicekring = false;

    public float timeDelay =2f;

    [SerializeField] private Light pointLightForEmmisive;
// Start is called before the first frame update
    void Start()
    {
        _motionLight.enabled = false;
        isFlicekring = false;
        pointLightForEmmisive.enabled = false;

    }

    private void OnTriggerEnter(Collider other)
    {
        _motionLight.enabled = true;
        pointLightForEmmisive.enabled = true;
        if (isFlicekring == false)
        {
            StartCoroutine(FlickeringLight());
        }

        IEnumerator FlickeringLight()
        {
            isFlicekring = true;
            _motionLight.GetComponent<Light>().enabled = false;
            yield return new WaitForSeconds(timeDelay);
            _motionLight.GetComponent<Light>().enabled = true;
            isFlicekring = false;
        }
    }

    private void OnTriggerExit(Collider other)
    { 
        _motionLight.enabled = false;
        pointLightForEmmisive.enabled = false;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
