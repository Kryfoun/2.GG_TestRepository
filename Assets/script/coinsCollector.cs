using UnityEngine;
using UnityEngine.SceneManagement;

public class coinsCollector : MonoBehaviour
{
  int score = 0;

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Nastala kolize s " + collision.gameObject.name);
        if (collision.gameObject.tag == "coins") 
        {
            score ++;  //toto je stejné jako score = score + 1

            if (SceneManager.GetActiveScene().name == "level1")
            { 
                if (score >= 5)
                {
                    Debug.Log("Vyhrál jsi!");
                    SceneManager.LoadScene("level2");
                }
            }
            else if(SceneManager.GetActiveScene().name == "level2")
            {
                
            }

            Destroy(collision.gameObject);
        }

    }
}
