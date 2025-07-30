using project_pkdsim.ANIMATOR.Parents.Leafeon.Mom.movementbasedanimations.Strafing.StrafeLeft;
using project_pkdsim.ANIMATOR.Parents.Leafeon.Mom.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Leafeon.Mom.movementbasedanimations.Strafing
{
	public class LEParentMom_Strafing : MonoBehaviour 
	{
		private LEParentMom_StrafeLeft LEParentMom_strafeleft;
		
		private LEParentMom_StrafeRight LEParentMom_straferight;

		public void LEParentMom_StrafingController()
		{
			if (LEParentMom_strafeleft == null)
			{
				Load_LEParentMom_StrafeLeft();
			}
			if (LEParentMom_straferight == null)
			{
				Load_LEParentMom_StrafeRight();
			}
		}
		private void Load_LEParentMom_StrafeRight()
		{
			LEParentMom_straferight.LEParentMom_StrafeRightController();
		}
		
		private void Load_LEParentMom_StrafeLeft()
		{
			LEParentMom_strafeleft.LEParentMom_StrafeLeftController();
		}
	}
}