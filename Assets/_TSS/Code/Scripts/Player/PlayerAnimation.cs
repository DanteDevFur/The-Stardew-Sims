using System;
using UnityEngine;

namespace _TSS.Player
{
    public class PlayerAnimation : MonoBehaviour
    {
        private static readonly int _LastYInput = Animator.StringToHash("LastYInput");
        private static readonly int _LastXInput = Animator.StringToHash("LastXInput");
        private static readonly int _XInput = Animator.StringToHash("XInput");
        private static readonly int _YInput = Animator.StringToHash("YInput");
        private static readonly int _IsWalking = Animator.StringToHash("IsWalking");
        
        [SerializeField] private PlayerInput input;
        [SerializeField] private Animator animator;

        private bool _isWalking;
        private Vector2 _lastMoveDir;

        private void OnMovementChanged(Vector2 newMovement)
        {
            animator.SetFloat(_XInput, newMovement.x);
            animator.SetFloat(_YInput, newMovement.y);
            
            _isWalking = newMovement != Vector2.zero;
            animator.SetBool(_IsWalking, _isWalking);
            
            if (!_isWalking) return;
            
            _lastMoveDir = newMovement;
            
            animator.SetFloat(_LastXInput, _lastMoveDir.x);
            animator.SetFloat(_LastYInput, _lastMoveDir.y);
        }
        
        private void OnEnable()
        {
            input.OnMovementChanged += OnMovementChanged;
        }


        private void OnDisable()
        {
            input.OnMovementChanged -= OnMovementChanged;
        }
    }
}