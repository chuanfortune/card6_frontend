using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.SceneScripts
{
    public class LoginScene : MonoBehaviour
    {
        public static LoginScene Instance;
        public GameObject loginScene;
        public GameObject SignupScene;
        // Use this for initialization

        public void LoginClick()
        {
            SceneManager.SwitchScene("MainBoardScene");

        }
        public void SignUpClick()
        {
            loginScene.SetActive(false);
            SignupScene.SetActive(true);

        }
        public void SingInClick()
        {
            loginScene.SetActive(true);
            SignupScene.SetActive(false);
        }

        void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else if (Instance != this)
            {
                Destroy(gameObject);
            }
        }

        void Start()
        {
            SignupScene.SetActive(false);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
