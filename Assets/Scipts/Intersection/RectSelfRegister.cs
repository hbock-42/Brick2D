using System;
using Scipts.Shapes;
using UnityEngine;

namespace Scipts.Intersection
{
	public class RectParamter : ShapeParameter
	{
		public Vector2 Center { get; set; }
		public float Heigth { get; set; }
		public float Width { get; set; }
	}

	public class RectSelfRegister: SelfRegister, IRect
	{

		#region Fields

		private float _halfHeigth;
		private float _halfWidth;

		#endregion

		#region IRect members

		public float Heigth { get; set; }
		public float Width { get; set; }
		public bool Ready { get; set; }
		public bool InitFailed { get; set; }
		public Vector2 Center { get; set; }

		public void Initialize(ShapeParameter param)
		{
			var rectParam = param as RectParamter;

			if (rectParam == null)
			{
				InitFailed = true;
				return;
			}

			Center = rectParam.Center;
			Heigth = rectParam.Heigth;
			Width = rectParam.Width;
			_halfHeigth = 0.5f * Heigth;
			_halfWidth = 0.5f * Width;
		}

		/// <summary>
		/// Distance with a point
		/// </summary>
		/// <param name="from">The point to calculate the distance with</param>
		/// <returns>Distance between the rect and the point
		/// Value is negative if the point is inside the rect</returns>
		public float Distance(Vector2 from)
		{
			// Todo 
			throw new NotImplementedException();
		}

		#endregion

		#region Mono

		// ReSharper disable once RedundantOverriddenMember
		public override void Start()
		{
			base.Start();
		}

		#endregion

		#region Method

		#endregion
	}
}
