﻿using UnityEngine;
public class ShapeGenerator : MonoBehaviour
{
    [SerializeField] private Shape shape = null;
    [SerializeField] private int triangleCount = 2;

    void Start()
    {
        if (shape == null) return;

        for(int i = 0; i < triangleCount; i++)
        { 
            var obj = Instantiate(shape);
            obj.transform.parent = transform;
        }
    }    
}