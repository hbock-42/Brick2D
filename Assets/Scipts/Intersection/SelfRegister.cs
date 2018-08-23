using System.Collections.Generic;
using UnityEngine;

namespace Scipts.Intersection
{
	/// <summary>
	/// Base class from which solid object inherits from
	/// </summary>
	public abstract class SelfRegister : MonoBehaviour
	{
		#region Properties

		public static List<SelfRegister> IntersectObjects { get; private set; }

		#endregion

		#region Mono

		// ReSharper disable once Unity.RedundantEventFunction
		public virtual void Start()
		{
		}

		private void Awake()
		{
			if (IntersectObjects == null) IntersectObjects = new List<SelfRegister>();
		}

		private void OnEnable()
		{
			if (IntersectObjects.Contains(this)) return;
			IntersectObjects.Add(this);
		}

		private void OnDisable()
		{
			IntersectObjects.Remove(this);
		}

		private void OnDestroy()
		{
			IntersectObjects.Remove(this);
		}

		#endregion

	}
}
