using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GS_PLAYER : MonoBehaviour
{
    [SerializeField] GameObject levelLoader;
    private void OnMouseDown()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, 5);
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Respawn")
        {
            FindObjectOfType<GS_LevelLoader1>().RestartScene();
        }
        if (other.gameObject.tag =="Finish")
        {
            FindObjectOfType<GS_LevelLoader1>().LoadNextScene();
        }
    }
}
