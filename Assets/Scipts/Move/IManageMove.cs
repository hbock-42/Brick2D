using UnityEngine;

namespace Scipts.Base
{
	public interface IManageMove
	{
		Vector2 Direction { get; set; }
		float Speed { get; set; }

		void Move(Transform body, Vector2 direction, float speed);
	}
}