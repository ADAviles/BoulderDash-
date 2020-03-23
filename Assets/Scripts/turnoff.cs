using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnoff : MonoBehaviour
{
    private void OnMouseDown()
    {
        gameObject.SetActive(false);
    }
}
