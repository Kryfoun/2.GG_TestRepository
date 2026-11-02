using UnityEngine;

public class axi : MonoBehaviour
{
    float horizontal;
    float vertical;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        Debug.Log("Horizontal:" + horizontal);
        Debug.Log("Vertical" + vertical);
    }
}
