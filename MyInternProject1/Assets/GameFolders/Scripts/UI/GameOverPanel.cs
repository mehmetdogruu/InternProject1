using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MyInternProject1.Managers;

namespace MyInternProject1.UI
{
    public class GameOverPanel : MonoBehaviour
    {
        public void TryAgainClicked()
        {
            GameManager.Instance.LoadLevelScene();
        }

        public void ExitClicked()
        {
            GameManager.Instance.LoadMenuScene();
        }
    }

}

