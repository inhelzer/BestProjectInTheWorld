using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NS_onclick : MonoBehaviour
{
    [SerializeField] GameObject[] squares = new GameObject[9];
    [SerializeField] GameObject blacksquare;
    int num;
    // Start is called before the first frame update
    void Start()
    {
        num = Random.Range(0, 8);
        Instantiate(blacksquare, squares[num].transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
