using Project_Pkdsim.Mouse.States.Mouse_leftclick;
using Project_Pkdsim.Mouse.States.Mouse_middleclick;
using Project_Pkdsim.Mouse.States.Mouse_rightclick;
using UnityEngine;

namespace Project_Pkdsim.Mouse.States.Modules
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