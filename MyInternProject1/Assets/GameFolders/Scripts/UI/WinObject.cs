using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MyInternProject1.Managers;

namespace MyInternProject1.UI
{
    public class WinObject : MonoBehaviour
    {
        [SerializeField] GameObject _winPanel;

        private void Awake()
        {
            if (_winPanel.activeSelf)
            {
                _winPanel.SetActive(false);
            }
        }
        private void OnEnable()
        {
            GameManager.Instance.OnLevelCompleted += HandleOnLevelSucceed;
        }
        private void OnDisable()
        {
            GameManager.Instance.OnLevelCompleted -= HandleOnLevelSucceed;

        }
        private void HandleOnLevelSucceed()
        {
            if (!_winPanel.activeSelf)
            {
                _winPanel.SetActive(true);
            }
        }

    }
}
