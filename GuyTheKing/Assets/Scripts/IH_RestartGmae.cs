using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IH_RestartGmae : MonoBehaviour
{
    private void OnMouseDown()
    {
        FindObjectOfType<LevelLoader>().RestartGame();
    }
}
