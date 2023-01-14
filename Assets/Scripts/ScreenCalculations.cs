using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenCalculations : MonoBehaviour
{
    public ScreenToWorldPositions GetScreenToWorldPositions()
    {

    }
}

public struct ScreenToWorldPositions
{
    public float minX;
    public float minY;
    public float maxX;
    public float maxY;
}
