using UnityEngine;

public class movementScript : MonoBehaviour
{

    [SerializeField] float speedX =1f;
    [SerializeField] float speedY = 1f;
    //Vector3 speed ;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
            transform.position = transform.position +  
            new Vector3(Input.GetAxis("Horizontal")*speedX*Time.deltaTime
            ,Input.GetAxis("Vertical")*speedY*Time.deltaTime
            ,0);





                 // 10fps 1*1*0.1 = 0.1 ( 1 jendotka za vteřinu)
                 // 30fps 1*1*0.0333 =0.0333 (1 jednotka za vteřinu)
                 // 100fps 1*1*0.01 = 0.01 (1 jednotka za vteřinu)

 
    }

}

