using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Graph : MonoBehaviour
{
    [SerializeField] private Transform pointPrefab;

    private void Awake()
    {
        Transform point;
        for (int i = 0; i < 10; i++)
        {
            point = Instantiate(pointPrefab);
            point.localPosition = Vector3.right * ((i + 0.5f) / 5f - 1f);
            point.localScale = Vector3.one / 5f; 
        }
    }
}
