using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Camera follows character(Player object)

public class CameraBehavior : MonoBehaviour
{

    public Vector3 camOffset = new Vector3(0, 2.9f, -3.9f);

    private Transform target;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        this.transform.position = target.TransformPoint(camOffset);

        this.transform.LookAt(target);
    }
}
