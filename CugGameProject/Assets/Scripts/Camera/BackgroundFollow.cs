using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundFollow : MonoBehaviour
{
    public Transform target;
    public float ModifyDir;

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            if (transform.position != target.position)
            {
                Vector3 targetPos = target.position;
                targetPos.x = target.position.x - 4.5f;
                targetPos.y = target.position.y-0.7f- ModifyDir;
                transform.position = targetPos;
            }
        }
    }
}
