using project_pkdsim.Mouse.States.Mouse_leftclick;
using project_pkdsim.Mouse.States.Mouse_middleclick;
using project_pkdsim.Mouse.States.Mouse_rightclick;
using UnityEngine;

namespace project_pkdsim.Mouse.States.Modules
{
	public class MouseStates : MonoBehaviour
	{
		private Mouse_LC Mouse_Lc;
		private Mouse_RC Mouse_Rc;
		private Mouse_MC Mouse_Mc;

		public void LeftClick()
		{
			Debug.Log("Left Click");
		}
		public void RightClick()
		{
			Debug.Log("Right Click");
		}
		public void MiddleClick()
		{
			Debug.Log("Middle Click");
		}
	}
}