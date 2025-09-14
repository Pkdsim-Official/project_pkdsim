using project_pkdsim.ANIMATOR.Parents.Delphox.Mom.movementbasedanimations.Strafing.StrafeLeft;
using project_pkdsim.ANIMATOR.Parents.Delphox.Mom.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Delphox.Mom.movementbasedanimations.Strafing
{
	public class DLParentMom_Strafing : MonoBehaviour 
	{
		private DLParentMom_StrafeLeft DLParentMom_strafeleft;
		
		private DLParentMom_StrafeRight DLParentMom_straferight;

		public void DLParentMom_StrafingController()
		{
			if (DLParentMom_strafeleft == null)
			{
				Load_DLParentMom_StrafeLeft();
			}
			if (DLParentMom_straferight == null)
			{
				Load_DLParentMom_StrafeRight();
			}
		}
		private void Load_DLParentMom_StrafeRight()
		{
			DLParentMom_straferight.DLParentMom_StrafeRightController();
		}
		
		private void Load_DLParentMom_StrafeLeft()
		{
			DLParentMom_strafeleft.DLParentMom_StrafeLeftController();
		}
	}
}