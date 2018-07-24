using UnityEngine;

namespace Scipts.Shapes
{
	public class RectParamter : ShapeParameter
	{
		public Vector2 Position { get; set; }
		public float Heigth { get; set; }
		public float Width { get; set; }
	}

	public class Rect: IRect
	{
		#region Fields

		private float _halfHeigth;
		private float _halfWidth;

		#endregion

		#region Constructor

		public Rect(float height, float width)
		{
			Initialize(RectParamFromRectValues(height, width, Vector2.zero));
		}

		public Rect(float height, float width, Vector2 position)
		{
			Initialize(RectParamFromRectValues(height, width, position));
		}

		#endregion

		#region Methods

		private RectParamter RectParamFromRectValues(float height, float width, Vector2 position)
		{
			return new RectParamter()
			{
				Heigth = height,
				Width = width,
				Position = position,
			};
		}

		#endregion

		#region IRect

		#region Properties

		public bool Ready { get; set; }
		public bool InitFailed { get; set; }
		public Vector2 Position { get; set; }

		#endregion

		public void Initialize(ShapeParameter param)
		{
			var rectParam = param as RectParamter;

			if (rectParam == null)
			{
				InitFailed = true;
				return;
			}

			Position = rectParam.Position;
			Heigth = rectParam.Heigth;
			Width = rectParam.Width;
			_halfHeigth = 0.5f * Heigth;
			_halfWidth = 0.5f * Width;
		}

		public float Distance(Vector2 @from)
		{
			throw new System.NotImplementedException();
		}

		public float Width { get; set; }
		public float Heigth { get; set; }

		#endregion
	}
}
