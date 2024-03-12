using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowScritp : MonoBehaviour
{
    [SerializeField] private float followSpeed;
    [SerializeField] private Vector3 offSet;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, PlayerController.Instance.transform.position + offSet, followSpeed);
    }
}
