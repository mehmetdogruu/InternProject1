using System.Collections;
using System.Collections.Generic;
using MyInternProject1.Managers;
using UnityEngine;

namespace MyInternProject1.UI
{
    public class MenuPanel : MonoBehaviour
    {
        public void StartClick()
        {
            GameManager.Instance.LoadLevelScene(1);
        }
        public void ExitClick()
        {
            GameManager.Instance.Exit();
        }

    }
}

