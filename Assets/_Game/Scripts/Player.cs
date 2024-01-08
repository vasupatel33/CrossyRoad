using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Animator animator;
    public int width, height;
    [SerializeField] PathCreator pathScript;
    int zPos;
    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        if(Input.GetKeyDown(KeyCode.W))
        {
            //animator.SetTrigger("Jump");
            Up();
        }
        if(Input.GetKeyDown(KeyCode.S))
        {
            Down();
        }
        if(Input.GetKeyDown(KeyCode.D))
        {
            LeftToRight(1);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            LeftToRight(-1);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Road")
        {
            pathScript.CreatePath();
        }
    }
    private void MovePlayer()
    {
        Vector3 targetPos= new Vector3(width, transform.position.y, zPos);
        transform.position = Vector3.Lerp(transform.position, targetPos,0.2f);
    }
    private void Up()
    {
        transform.eulerAngles = Vector3.zero;
        zPos++;
        if(zPos > height)
        {
            height = zPos;
        }
    }
    private void Down()
    {
        transform.eulerAngles = new Vector3(0,180,0);
        if (zPos > height - 5)
        {
            zPos--;
        }
    }
    private void LeftToRight(int value)
    {
        transform.eulerAngles = new Vector3(0, 90 * value, 0);
        width += value;
        width = Mathf.Clamp(width, -6, 8);
    }
}
