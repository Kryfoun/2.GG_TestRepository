using UnityEngine;

public class key : MonoBehaviour
{
    [SerializeField] bool hasKey = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
     Debug.Log("Má hráč klíč:" +hasKey);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
