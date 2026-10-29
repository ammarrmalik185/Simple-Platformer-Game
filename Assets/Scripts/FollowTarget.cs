using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    public Transform target;
    
    private void Update(){
        var position = transform.position;
        position = new Vector3(position.x, target.position.y, position.z);
        transform.position = position;
    }
}
