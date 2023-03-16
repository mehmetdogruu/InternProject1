using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using MyInternProject1.Managers;
using MyInternProject1.Controllers;

namespace MyInternProject1.Abstracs.Controllers
{
    public abstract class WallController : MonoBehaviour
    {
        private void OnCollisionEnter(Collision other)
        {
            PlayerController player = other.collider.GetComponent<PlayerController>();
            if (player!=null && player.CanMove)
            {
                GameManager.Instance.GameOver();
            }
        }
    }
}

