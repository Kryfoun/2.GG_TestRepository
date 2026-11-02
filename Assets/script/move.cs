using UnityEngine;

public class move : MonoBehaviour
{
    [SerializeField] float speedX = 1f;
     [SerializeField] float speedY = 1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(Input.GetAxis("Horizontal")*speedX*Time.deltaTime,Input.GetAxis("Vertical")*speedY*Time.deltaTime,0);
    }
}
