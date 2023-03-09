using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MyInternProject1.Controllers
{
    public class FinishFloorController : MonoBehaviour
    {
        [SerializeField] GameObject _fireWork;
        [SerializeField] GameObject _finishLight;

        private void OnCollisionEnter(Collision other)
        {
            PlayerController player = other.collider.GetComponent<PlayerController>();
            if (player = null) return;
            if (other.GetContact(0).normal.y==-1)
            {
                _fireWork.gameObject.SetActive(true);
                _finishLight.gameObject.SetActive(true);
            }
            else
            {
                //GameOver
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }


        }
    }
}

