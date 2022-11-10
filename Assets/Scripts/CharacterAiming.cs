using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAiming : MonoBehaviour
{
    Camera mainCamera;
    [SerializeField]
    float turnSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, mainCamera.transform.rotation.eulerAngles.y, 0), turnSpeed * Time.deltaTime);
    }
}
