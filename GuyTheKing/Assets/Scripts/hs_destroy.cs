using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hs_destroy : MonoBehaviour
{
    int maxHits = 1;
    int numberHits = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        numberHits = numberHits + 1;
        if (numberHits == maxHits)
        {
            Destroy(gameObject);
        }

    }
}
