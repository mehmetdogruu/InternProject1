using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MyInternProject1.Inputs;
using MyInternProject1.Movements;

namespace MyInternProject1.Controllers
{ 
    public class PlayerController : MonoBehaviour
    {

        [SerializeField] private float _turnSpeed=35f;
        [SerializeField] private float _force = 55f;

        DefaultInput _input;
        Mover _mover;
        Rotator _rotator;

        bool _isForceUp;
        float _leftRight;

        public float TurnSpeed => _turnSpeed;

        public float Force => _force;

        private void Awake()
        {
            _input = new DefaultInput();
            _mover = new Mover(this);
            _rotator = new Rotator(this);

        //_rigidbody = GetComponent<Rigidbody>();

        }

        private void Update()
        {
            if (_input.isForceUp)
            {
                _isForceUp = true;
            }
            else
            {
                _isForceUp = false;
            }
            _leftRight = _input.leftRight;
            
        }

        private void FixedUpdate()
        {
            if (_isForceUp)
            {
                _mover.FixedTick();
                //_rigidbody.AddForce(Vector3.up * Time.deltaTime*_force);
            }
            _rotator.FixedTick(_leftRight);
        } 
    }

}
