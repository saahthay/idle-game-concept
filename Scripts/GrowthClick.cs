using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowthClick : MonoBehaviour
{
    private void OnMouseDown()
    {
        GetComponent<GrowthIncreasing>().PlayAnim();
    }
}
