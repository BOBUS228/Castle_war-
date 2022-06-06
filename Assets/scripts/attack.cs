using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{
    public void getdamage(unit char1, unit char2)
    {
        char2.currenthp -= char1.damage;
    }
}
