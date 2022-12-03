using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{

    [SerializeField] private GameObject thingToFollow;
    //camera should track car
    void LateUpdate()
    {
        transform.position = thingToFollow.transform.position+new Vector3(0,0,-10);//maybe create a zoom variable
    }
}
