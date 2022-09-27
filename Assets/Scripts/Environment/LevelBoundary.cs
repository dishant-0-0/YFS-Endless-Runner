using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public static float leftSide = -8f;
    public static float rightSide = 8f;
    public float internalLeft;
    public float internalRight;
    void Start()
    {

    }
    void Update()
    {
        internalLeft = leftSide;
        internalRight = rightSide;
    }
}
