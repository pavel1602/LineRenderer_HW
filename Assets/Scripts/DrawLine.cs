using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLine : MonoBehaviour
{
    private LineRenderer _line;
    private void Awake()
    {
        _line = GetComponent<LineRenderer>();
    }

    private void Start()
    {
        _line.startWidth = 0.03f;
        _line.endWidth = 0.03f;
        _line.positionCount = 0;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _line.positionCount = 0;
        }


        if (Input.GetMouseButton(0))
        {
            var mousePoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1);
            var currentPoint = Camera.main.ScreenToWorldPoint(mousePoint);
            _line.positionCount++;
            _line.SetPosition(_line.positionCount - 1, currentPoint);
        }
    }
}
