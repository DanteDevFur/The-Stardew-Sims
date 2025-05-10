using UnityEngine;

namespace _TSS.Player
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private PlayerInput input;
        [SerializeField] private Rigidbody2D rb;

        private Vector2 _moveDirection;

        private void OnMovementChanged(Vector2 moveDirection)
        {
            _moveDirection = moveDirection;
            rb.velocity = _moveDirection.normalized;
        }

        private void OnEnable() => input.OnMovementChanged += OnMovementChanged;


        private void OnDisable() => input.OnMovementChanged -= OnMovementChanged;
    }
}
