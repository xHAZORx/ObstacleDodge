using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float dropTime = 2f;
    MeshRenderer myMeshRenderer;
    Rigidbody myRigidbody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myMeshRenderer = GetComponent<MeshRenderer>();
        myRigidbody = GetComponent<Rigidbody>();

        myMeshRenderer.enabled = false;
        myRigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > dropTime)
        { 
            myMeshRenderer.enabled = true;
            myRigidbody.useGravity = true;
        }
    }
}
