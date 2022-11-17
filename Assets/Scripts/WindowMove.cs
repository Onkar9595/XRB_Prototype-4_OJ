using System;
using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;
using DG.Tweening;

public class WindowMove : MonoBehaviour
{
    [SerializeField] private Transform _closePosition;
    [SerializeField] private Ease _ease = Ease.Linear;
    private Vector3 _initialPosition;
    [SerializeField] private float _duration = 0;
    
    void Start()
    {
        _initialPosition = transform.position;
    }

    public void MoveToTarget()
    {
        Move(_closePosition.position);
    }

    private void Move(Vector3 position)
    {
        transform.DOMove(position, _duration)
            .SetEase(_ease)
            .OnComplete(() => Debug.Log("Position Reached"));
    }

    private void OnTriggerEnter(Collider other)
    {
        //if (!other.CompareTag("Player"))return;
        Invoke("MoveToTarget", 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
