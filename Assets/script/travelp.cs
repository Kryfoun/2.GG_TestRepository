using UnityEngine;

public class travelp : MonoBehaviour
{
    float playerSpeed = 4.5f;
    float timeOfRun = 3.2f;
    float traveledDistance;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        traveledDistance = playerSpeed * timeOfRun;
        Debug.Log ("Hráč urazil " + traveledDistance + " jednotek");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
