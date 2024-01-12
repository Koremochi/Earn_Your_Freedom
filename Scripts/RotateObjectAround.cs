using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObjectAround : MonoBehaviour
{
    Vector3 pivotPoint;

    private void Start()
    {
        pivotPoint = transform.localPosition;
    }

    private void Update()
    {
        transform.RotateAround(pivotPoint, Vector3.up, 90 * Time.unscaledDeltaTime);
    }
}
