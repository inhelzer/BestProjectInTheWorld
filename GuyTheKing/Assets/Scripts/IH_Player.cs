using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IH_Player : MonoBehaviour
{
    private void OnMouseDown()
    {
        GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
    }
}
