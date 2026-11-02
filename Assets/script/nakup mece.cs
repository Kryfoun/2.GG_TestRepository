using UnityEngine;

public class nakupmece : MonoBehaviour
{
    int money = 500;    
    
    int swordPrice = 180;
    
    void Start()
    {

       money = money - swordPrice;  
       Debug.Log("Hráči zbývá" + money + "minci");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
