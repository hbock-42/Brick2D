using UnityEngine;

namespace Scipts.Shapes
{
	public abstract class ShapeParameter
	{

	}

	public interface IShape
	{
		bool Ready { get; set; }
		bool InitFailed { get; set; }
		Vector2 Center { get; set; }

		void Initialize(ShapeParameter param);
		float Distance(Vector2 from);
	}
}
