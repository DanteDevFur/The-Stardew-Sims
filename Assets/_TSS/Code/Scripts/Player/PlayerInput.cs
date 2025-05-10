using System;
using UnityEngine;

namespace _TSS.Player
{
    public class PlayerInput : MonoBehaviour
    {
        [Header("Interact")] 
        [SerializeField] private KeyCode interactKey = KeyCode.E;

        [Header("Move")] 
        [SerializeField] private string horizontalAxis = "Horizontal";
        [SerializeField] private string verticalAxis = "Vertical";
        
        public event System.Action<Vector2> OnMovementChanged;
        public event System.Action OnInteract;

        private Vector2 _moveDirection;
        private Vector2 _lastMoveDirection;

        private void Update()
        {
            HandleMove();
            HandleInteract();
        }

        private void HandleInteract()
        {
            if (!Input.GetKeyDown(interactKey)) return;
            
            OnInteract?.Invoke();
        }

        private void HandleMove()
        {
            _moveDirection.x = Input.GetAxisRaw(horizontalAxis); 
            _moveDirection.y = Input.GetAxisRaw(verticalAxis); 
            
            if(_moveDirection == _lastMoveDirection) return;

            _lastMoveDirection = _moveDirection;
            
            OnMovementChanged?.Invoke(_moveDirection);
        }
    }
}
