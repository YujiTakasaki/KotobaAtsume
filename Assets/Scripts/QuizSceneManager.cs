using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuizSceneManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void toBadEndScene() {
        SceneManager.LoadScene("BadEndScene");
    }
    public void toHappyEndScene() {
        SceneManager.LoadScene("HappyEndScene");
    }
}
