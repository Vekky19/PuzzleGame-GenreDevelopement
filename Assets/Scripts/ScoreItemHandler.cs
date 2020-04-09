using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreItemHandler : MonoBehaviour
{
    public static ScoreItemHandler Instance;
    public int keys;

    void Start()
    {
        Instance = this;
        keys = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
