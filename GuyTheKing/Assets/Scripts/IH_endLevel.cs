using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IH_endLevel : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        FindObjectOfType<LevelLoader>().LoadNextScene();
    }
}
