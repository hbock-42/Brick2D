using Scipts.Base;
using UnityEngine;

namespace Scipts.Move
{
	/// <summary>
	/// Highest level move class.
	/// You can inherite from it if you want to add more complexe behaviours
	/// </summary>
	public class ManageMove : MonoBehaviour, IManageMove
	{

		#region Fields

		private Vector2 _direction;
		private Transform _body;
		private float _speed = 10f;

		#endregion

		#region Properties

		public Vector2 Direction
		{
			get { return _direction; }
			set { _direction = value.normalized; }
		}

		public float Speed
		{
			get { return _speed; }
			set { _speed = value > 0 ? value : 0; }
		}

		#endregion

		#region Mono

		private void Start()
		{
			_body = transform;
		}

		private void Update()
		{
			Move(_body, Direction, Speed);
		}

		#endregion

		#region Methods

		public void Move(Transform body, Vector2 direction, float speed)
		{
			body.position = (Vector2)body.position + direction * speed * Time.deltaTime;
		}

		#endregion
	}
}
