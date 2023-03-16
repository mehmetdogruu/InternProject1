using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MyInternProject1.Abstracs.Controllers;

namespace MyInternProject1.Controllers
{
    public class KineticWallController : WallController
    {
        [SerializeField] Vector3 _direction;
        [SerializeField] float _speed = 1f;
        [SerializeField] float _factor;

        Vector3 _startPosition;
        const float fullCircle=Mathf.PI*2f;

        private void Awake()
        {
            _startPosition = transform.position;
        }

        private void Update()
        {
            float cycle = Time.time / _speed;
            float sinwave = Mathf.Sin(cycle * fullCircle);

            _factor = Mathf.Abs(sinwave);

            Vector3 offset = _direction * _factor;
            transform.position = offset + _startPosition;

        }
    }
}
