using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    enum MoveDirection
    {
        x = 0,
        y,
        z,
    }

    [SerializeField]
    MoveDirection moveDirection = MoveDirection.x;

    [SerializeField]
    float min;
    [SerializeField]
    float max;

    [SerializeField]
    float velocity = 2f;
    [SerializeField]
    float stopTime = 1f;

    float len;
    float sv;
    float maxVelocity;

    BoxCollider box;

    float time = 0f;

    LayerMask layermask;

    private void Start()
    {
        len = max - min;
        sv = stopTime * velocity;
        maxVelocity = velocity;

        box = GetComponent<BoxCollider>();

        layermask = LayerMask.GetMask("Collidable");
    }

    private float EaseInOutSine(float t)
    {
        //t [0, 0.5, 1, 1.5, 2]
        //x [0, 0.5, 1, 0.5, 0]
        return -(Mathf.Cos(Mathf.PI * t) - 1) / 2;
    }

    private float CalcPosition(float time)
    {
        float p = 0f;
        float tv = time * velocity;

        if (0 <= tv && tv < len)
        {
            p = EaseInOutSine(tv / len) * len + min;
        }
        else if (len <= tv && tv < len + sv)
        {
            p = max;
        }
        else if (len + sv <= tv && tv < len + sv + len)
        {
            p = EaseInOutSine((tv - sv) / len) * len + min;
        }
        else if (len + sv + len <= tv && tv < len + sv + len + sv)
        {
            p = min;
        }
        return p;
    }
    
    private void FixedUpdate()
    {
        time += Time.deltaTime;
        if ((len + sv) * 2 <= time * velocity)
        {
            time -= (len + sv) * 2 / velocity;
        }
        float calcP = CalcPosition(time);
        float maxDelta = maxVelocity * Time.deltaTime;
        Vector3 p = transform.position;

        if ((moveDirection == MoveDirection.x && calcP == p.x) ||
            (moveDirection == MoveDirection.y && calcP == p.y) ||
            (moveDirection == MoveDirection.z && calcP == p.z))
        {
            return;
        }

        Vector3 direction = Vector3.zero;
        float distance = 1f;

        switch (moveDirection)
        {
            case MoveDirection.x:
                direction.x = calcP < p.x ? -1 : 1;
                distance = Mathf.Min(Mathf.Abs(calcP - p.x), maxDelta);
                p.x = Mathf.Clamp(calcP, p.x - maxDelta, p.x + maxDelta);
                break;
            case MoveDirection.y:
                direction.y = calcP < p.y ? -1 : 1;
                distance = Mathf.Min(Mathf.Abs(calcP - p.y), maxDelta);
                p.y = Mathf.Clamp(calcP, p.y - maxDelta, p.y + maxDelta);
                break;
            case MoveDirection.z:
                direction.z = calcP < p.z ? -1 : 1;
                distance = Mathf.Min(Mathf.Abs(calcP - p.z), maxDelta);
                p.z = Mathf.Clamp(calcP, p.z - maxDelta, p.z + maxDelta);
                break;
        }

        //raycast box
        RaycastHit hit;
        bool moveUp = false;
        const float margin = 1f;
        Vector3 start = transform.position;
        switch (moveDirection)
        {
            case MoveDirection.x:
                start.x = direction.x < 0 ? start.x + margin : start.x - margin;
                break;
            case MoveDirection.y:
                start.y = direction.y < 0 ? start.y + margin : start.y - margin;
                moveUp = direction.y > 0;
                break;
            case MoveDirection.z:
                start.z = direction.z < 0 ? start.z + margin : start.z - margin;
                break;
        }
        
        const float BoxSizeDiff = 0.02f;
        Vector3 halfExtents = box.size * 0.5f;
        switch (moveDirection)
        {
            case MoveDirection.x:
                halfExtents.y -= BoxSizeDiff;
                halfExtents.z -= BoxSizeDiff;
                break;
            case MoveDirection.y:
                halfExtents.x -= BoxSizeDiff;
                halfExtents.z -= BoxSizeDiff;
                break;
            case MoveDirection.z:
                halfExtents.x -= BoxSizeDiff;
                halfExtents.y -= BoxSizeDiff;
                break;
        }

        if (Physics.BoxCast(start, halfExtents, direction, out hit, transform.rotation, distance + margin, layermask))
        {
            if (!(moveUp && hit.collider.transform.parent == transform))
            {
                const float minHitDistance = 0.01f;
                Vector3 currentP = transform.position;
                float hitDistance = hit.distance - margin;
                //Debug.Log("Hit : distance = " + distance.ToString() + " hitDistance = " + hitDistance.ToString());
                if (hitDistance < minHitDistance)
                {
                    return;
                }

                switch (moveDirection)
                {
                    case MoveDirection.x:
                        p.x = calcP < currentP.x ? currentP.x - hitDistance : currentP.x + hitDistance;
                        break;
                    case MoveDirection.y:
                        p.y = calcP < currentP.y ? currentP.y - hitDistance : currentP.y + hitDistance;
                        break;
                    case MoveDirection.z:
                        p.z = calcP < currentP.z ? currentP.z - hitDistance : currentP.z + hitDistance;
                        break;
                }
                //Debug.Log("p = " + p.x.ToString() + " calcP = " + calcP.ToString());
            }
        }

        //Debug.Log("x = " + transform.position.x.ToString() + " p = " + p.x.ToString() + " xdif = " + (transform.position.x - p.x).ToString());
        transform.position = p;
    }
}
