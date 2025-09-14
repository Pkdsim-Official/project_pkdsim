using project_pkdsim.ANIMATOR.Parents.Lucario.Mom.movementbasedanimations.Strafing.StrafeLeft;
using project_pkdsim.ANIMATOR.Parents.Lucario.Mom.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Lucario.Mom.movementbasedanimations.Strafing
{
	public class LUCAParentMom_Strafing : MonoBehaviour 
	{
		private LUCAParentMom_StrafeLeft LUCAParentMom_strafeleft;
		
		private LUCAParentMom_StrafeRight LUCAParentMom_straferight;

		public void LUCAParentMom_StrafingController()
		{
			if (LUCAParentMom_strafeleft == null)
			{
				Load_LUCAParentMom_StrafeLeft();
			}
			if (LUCAParentMom_straferight == null)
			{
				Load_LUCAParentMom_StrafeRight();
			}
		}
		private void Load_LUCAParentMom_StrafeRight()
		{
			LUCAParentMom_straferight.LUCAParentMom_StrafeRightController();
		}
		
		private void Load_LUCAParentMom_StrafeLeft()
		{
			LUCAParentMom_strafeleft.LUCAParentMom_StrafeLeftController();
		}
	}
}