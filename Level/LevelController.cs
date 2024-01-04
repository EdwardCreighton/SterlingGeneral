using UnityEngine;
using Sterling.Input;

namespace Sterling
{
	public class LevelController : MonoBehaviour
	{
		[SerializeField] private InputController inputController;

		public InputController InputController => inputController;
	}
}