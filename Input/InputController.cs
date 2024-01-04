using UnityEngine;
using UnityEngine.InputSystem;

namespace Sterling.Input
{
	public class InputController : MonoBehaviour
	{
		[SerializeField] private PlayerInput playerInput;

		private SterlingInputActions _sterlingInputActions;

		private void Awake()
		{
			_sterlingInputActions = new SterlingInputActions();
			playerInput.actions = _sterlingInputActions.asset;
			
			_sterlingInputActions.Player.Enable();
		}
	}
}