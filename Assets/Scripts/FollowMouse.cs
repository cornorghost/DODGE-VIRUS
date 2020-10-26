using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FollowMouse : MonoBehaviour
{

    [SerializeField] Transform target;
    private Vector3 targetPos;
    private float moveSpeed = 6.0f;

    // Use this for initialization
    void Start()
    {
        targetPos = transform.position;
    }

    void Update()
    {
        if (Input.GetMouseButton(1)) {
            setTargetPos();
            FollowMouseRotate(); //转向2
        }

        FollowMouseMove(); //移动
    }

    //物体跟随鼠标旋转
    private void FollowMouseRotate()
    {
        if (transform.position.x< targetPos.x) transform.right = - Vector3.right;
        else transform.right = Vector3.right;
    }

    void setTargetPos()
    {
        targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        targetPos.z = transform.position.z;
    }

    //跟随鼠标移动
    void FollowMouseMove()
    {
        if (transform.position != targetPos)
        {
            //transform.rotation = Quaternion.LookRotation(Vector3.forward, targetPos); //转向1
            transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("enter");
        SceneManager.LoadScene(2);
    }

    public void setTarget(Vector3 newTarget)
    {
        targetPos = newTarget;
    }
}