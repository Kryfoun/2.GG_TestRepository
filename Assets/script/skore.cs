using Mono.Cecil.Cil;
using Unity.VisualScripting;
using UnityEngine;

public class nasobeni : MonoBehaviour
{
   int playerCoins = 7;

   int pointsPerCoin = 10;
   
   int playerScore;
   void Start()
    {
       playerScore =  playerCoins*pointsPerCoin;
       Debug.Log("Hráč má " + playerScore +"bodů");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
