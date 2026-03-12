using Project_Pkdsim.ANIMATOR.Parents.Cinderace.movementbasedanimations.Strafing.StrafeLeft;
using Project_Pkdsim.ANIMATOR.Parents.Cinderace.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Cinderace.movementbasedanimations.Strafing
{
	public class ParentDad_Strafing : MonoBehaviour 
	{
		private C_StrafeLeft C_strafeleft;
		
		private C_StrafeRight C_straferight;

		public void ParentDad_StrafingController()
		{
			if (C_strafeleft == null)
			{
				Load_C_StrafeLeft();
			}
			if (C_straferight == null)
			{
				Load_C_StrafeRight();
			}
			

		}
		private void Load_C_StrafeRight()
		{
			C_straferight.C_StrafeRightController();
		}
		
		private void Load_C_StrafeLeft()
		{
			C_strafeleft.C_StrafeLeftController();
		}
	}
}