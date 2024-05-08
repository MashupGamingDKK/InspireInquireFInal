using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class randomPosition : MonoBehaviour
{

    int[] positions = { 310, -130, -570 };
    public int[] randomized = { -1, -1, -1 };
    public GameObject[] buttons;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Shuffle()
    {
        int first = UnityEngine.Random.Range(0, 3);
        randomized[0] = positions[first];
        int second;
        do
        {
            second = UnityEngine.Random.Range(0, 3);
        }
        while (first == second);
        randomized[1] = positions[second];
        int third;
        do
        {
            third = UnityEngine.Random.Range(0, 3);
        }
        while ((third == second) || (third == first));
        randomized[2] = positions[third];
        buttons[0].transform.localPosition = new Vector3(0, randomized[0], 0);
        buttons[1].transform.localPosition = new Vector3(0, randomized[1], 0);
        buttons[2].transform.localPosition = new Vector3(0, randomized[2], 0);
    }
}