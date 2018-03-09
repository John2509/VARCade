using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaracLife : MonoBehaviour
{

    protected bool isAlive;

    protected void Awake()
    {
        isAlive = true;
    }

    public bool IsAlive()
    {
        return isAlive;
    }

    public void TakeHit()
    {
        if (isAlive)
        {
            isAlive = false;
        }
    }
}