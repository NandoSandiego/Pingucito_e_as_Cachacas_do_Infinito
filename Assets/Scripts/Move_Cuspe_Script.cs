﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Cuspe_Script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(10 * Time.deltaTime, 0));
    }
}
