using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MyInternProject1.Managers;

namespace MyInternProject1.UI
{
    public class WinPanel : MonoBehaviour
    {
        public void NextLevelClicked()
        {
            GameManager.Instance.LoadLevelScene(1);
        }

    }
}
