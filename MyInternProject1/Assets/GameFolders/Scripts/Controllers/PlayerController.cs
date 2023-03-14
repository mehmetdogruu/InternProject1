using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MyInternProject1.Inputs;
using MyInternProject1.Movements;
using MyInternProject1.Managers;

namespace MyInternProject1.Controllers
{ 
    public class PlayerController : MonoBehaviour
    {

        [SerializeField] private float _turnSpeed=35f;
        [SerializeField] private float _force = 55f;

        DefaultInput _input;
        Mover _mover;
        Rotator _rotator;
        Fuel _fuel;

        bool _canMove;
        bool _canForceUp;
        float _leftRight;

        public float TurnSpeed => _turnSpeed;

        public float Force => _force;

        private void Awake()
        {
            _input = new DefaultInput();
            _mover = new Mover(this);
            _rotator = new Rotator(this);
            _fuel = GetComponent<Fuel>();
        }
        private void Start()
        {
            _canMove = true;
        }
        private void OnEnable()
        {
            GameManager.Instance.OnGameOver += HandleOnEventTrigger;
            GameManager.Instance.OnLevelCompleted += HandleOnEventTrigger;
        }



        private void OnDisable()
        {
            GameManager.Instance.OnGameOver -= HandleOnEventTrigger;
            GameManager.Instance.OnLevelCompleted -= HandleOnEventTrigger;

        }

        private void Update()
        {
            if (!_canMove) return;

            if (_input.isForceUp && !_fuel.IsFuelEmpty)
            {
                _canForceUp = true;
            }
            else
            {
                _canForceUp = false;
                _fuel.FuelIncrease(0.05f);
            }
            _leftRight = _input.leftRight;
            
        }

        private void FixedUpdate()
        {
            if (_canForceUp)
            {
                _mover.FixedTick();
                _fuel.FuelDecrease(0.2f);
            }
            _rotator.FixedTick(_leftRight);
        }
        private void HandleOnEventTrigger()
        {
            _canMove = false;
            _canForceUp = false;
            _leftRight = 0f;
            _fuel.FuelIncrease(0f);
        }
    }

}
