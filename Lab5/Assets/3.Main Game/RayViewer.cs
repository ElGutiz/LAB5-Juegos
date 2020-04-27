using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayViewer : MonoBehaviour
{
    public float weaponRange = 50f;
    private Camera fpsCamera;
    void Start()
    {
        fpsCamera = GetComponentInParent<Camera>();
    }


    void Update()
    {
        Vector3 lineOrigin = fpsCamera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0));
        Debug.DrawRay(lineOrigin, fpsCamera.transform.forward * weaponRange, Color.green);
    }
}
