using System.Linq;
using UnityEngine;
using Scipts.Intersection;

namespace Scipts
{
	public class TestSelfRegistration : MonoBehaviour {

		// Update is called once per frame
		void Update () {
			Debug.Log("All:" + SelfRegister.IntersectObjects.Count);
			Debug.Log("Rect:" + SelfRegister.IntersectObjects.Count(x => x is RectSelfRegister));
		}
	}
}
