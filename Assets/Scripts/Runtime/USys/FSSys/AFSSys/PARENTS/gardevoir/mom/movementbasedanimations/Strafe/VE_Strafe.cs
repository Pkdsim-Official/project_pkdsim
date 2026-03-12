using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Gardevoir.Mom.movementbasedanimations.Strafing.StrafeLeft;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Gardevoir.Mom.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Gardevoir.Mom.movementbasedanimations.Strafing
{
	public class GARDParentMom_Strafing : MonoBehaviour 
	{
		private GARDParentMom_StrafeLeft GARDParentMom_strafeleft;
		
		private GARDParentMom_StrafeRight GARDParentMom_straferight;

		public void GARDParentMom_StrafingController()
		{
			if (GARDParentMom_strafeleft == null)
			{
				Load_GARDParentMom_StrafeLeft();
			}
			if (GARDParentMom_straferight == null)
			{
				Load_GARDParentMom_StrafeRight();
			}
		}
		private void Load_GARDParentMom_StrafeRight()
		{
			GARDParentMom_straferight.GARDParentMom_StrafeRightController();
		}
		
		private void Load_GARDParentMom_StrafeLeft()
		{
			GARDParentMom_strafeleft.GARDParentMom_StrafeLeftController();
		}
	}
}