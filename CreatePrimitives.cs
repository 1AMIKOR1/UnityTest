using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePrimitives : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float[,] arr =
        {
            {0, 0, 0},
            {-0.5f, 1, 0},
            {0.5f, 1, 0},
            {0.5f, 2, 0},
            {-0.5f, 2, 0},
            {0, 3, 0}

        };
        // цикл создающий в начале игры фигуру, напоминающую Стива из Minecraft!
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            float x = arr[i, 0];
            float y = arr[i, 1];
            float z = arr[i, 2];
            GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(x, y, z);
        }
        
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
