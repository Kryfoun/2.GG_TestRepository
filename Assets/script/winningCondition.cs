using UnityEngine;
using UnityEngine.SceneManagement;

public class winningCondition : MonoBehaviour
{   

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void levelFinished(int score, bool guardAlive)
    {
        
            if (SceneManager.GetActiveScene().name == "level")
             {
                if (score >= 5)
                 {
                    
                    Debug.Log("Vyhral jsi");
                    SceneManager.LoadScene("level2");
                 }
           }
           else if(SceneManager.GetActiveScene().name == "level2")
        {
                if (score >= 5)
            {
                if (guardAlive)
                {
                    Debug.Log("Vyhrál jsi");
                    SceneManagment.LoadScene("level3");
                }


            }
        }
    }  
     

    // Update is called once per frame
    void Update()
    {
        
    }
}
