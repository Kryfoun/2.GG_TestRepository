using UnityEngine;

public class sword : MonoBehaviour
{
    string swordName = "Sword of doom";
    int swordPrice = 180;
    float swordWeight = 2.5f;
    int swordDamage = 25;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
            Debug.Log("Prědmět " + swordName + "\nstojí " + swordPrice + "zlatých. \nVáží" +swordWeight + "kg. \nDává zranění " + swordDamage + "damage.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
