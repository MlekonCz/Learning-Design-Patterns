using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Singleton_Pattern
{
    public class SceneReloader : MonoBehaviour
    {
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }
}