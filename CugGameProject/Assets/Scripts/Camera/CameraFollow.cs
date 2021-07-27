using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
    private Transform target;
    public float smoothing;

    public float SetyAddedvalue=0f;
    public Vector2 minPosition;
    public Vector2 maxPosition;

    void Start()
    {
        target = PlayerController.instance.transform;
    }

    void LateUpdate()
    {
        if(target != null)
        {
            if(transform.position != target.position)
            {
                Vector3 targetPos = target.position;
                targetPos.x = Mathf.Clamp(targetPos.x+3.5f, minPosition.x, maxPosition.x);
                targetPos.y = Mathf.Clamp(targetPos.y+ SetyAddedvalue, minPosition.y, maxPosition.y);
                transform.position = Vector3.Lerp(transform.position, targetPos, smoothing);
            }
        }
    }

    public void SetCamPosLimit(Vector2 minPos, Vector2 maxPos)
    {
        minPosition = minPos;
        maxPosition = maxPos;
    }
}