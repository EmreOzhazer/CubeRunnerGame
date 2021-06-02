using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{
    public Transform SceneManager;
    public Text scoreText;
    

    // Update is called once per frame
    void Update()
    {
        scoreText.text = SceneManager.position.z.ToString("0") ;

    }
}
