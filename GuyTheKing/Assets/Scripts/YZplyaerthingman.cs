using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YZplyaerthingman : MonoBehaviour
{
    [SerializeField] GameObject hoorayyouwin;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag=="endwin")
        {
            FindAnyObjectByType<LevelLoader>().LoadNextScene();
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag=="lironsi")
        {
            hoorayyouwin.SetActive(true);
        }
    }
}
