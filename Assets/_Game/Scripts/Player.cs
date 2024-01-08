using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] int width, height;
    int zPos;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            Up();
        }
        if(Input.GetKeyDown(KeyCode.S))
        {
            Down();
        }
        if(Input.GetKeyDown(KeyCode.A))
        {
            LeftToRight(1);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            LeftToRight(-1);
        }
    }
    private void Up()
    {
        zPos++;
        if(zPos > height)
        {
            height = zPos;
        }
    }
    private void Down()
    {
        if (zPos > height - 3)
        {
            zPos--;
        }
    }
    private void LeftToRight(int value)
    {
        width += value;
        width = Mathf.Clamp(width, -3, 3);
    }
}
