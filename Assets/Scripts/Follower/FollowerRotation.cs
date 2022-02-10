using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowerRotation : MonoBehaviour
{
    [SerializeField]
    private float finalRotation;

    [SerializeField]
    private bool startRotation;

    [SerializeField]
    private GameObject objectiveRotation;

    // Start is called before the first frame update
    void Start()
    {
        startRotation = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (startRotation)
        {
            transform.Rotate(0, 5 * finalRotation, 0);
        }
    }

    public void OnTriggerEnter(Collider collision)
    {
        startRotation = true;
        Debug.Log("Start Rotation");
    }
}
