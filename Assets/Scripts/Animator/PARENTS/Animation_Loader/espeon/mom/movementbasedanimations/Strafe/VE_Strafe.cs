using project_pkdsim.ANIMATOR.Parents.Espeon.Mom.movementbasedanimations.Strafing.StrafeLeft;
using project_pkdsim.ANIMATOR.Parents.Espeon.Mom.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Espeon.Mom.movementbasedanimations.Strafing
{
	public class ESParentMom_Strafing : MonoBehaviour 
	{
		private ESParentMom_StrafeLeft ESParentMom_strafeleft;
		
		private ESParentMom_StrafeRight ESParentMom_straferight;

		public void ESParentMom_StrafingController()
		{
			if (ESParentMom_strafeleft == null)
			{
				Load_ESParentMom_StrafeLeft();
			}
			if (ESParentMom_straferight == null)
			{
				Load_ESParentMom_StrafeRight();
			}
		}
		private void Load_ESParentMom_StrafeRight()
		{
			ESParentMom_straferight.ESParentMom_StrafeRightController();
		}
		
		private void Load_ESParentMom_StrafeLeft()
		{
			ESParentMom_strafeleft.ESParentMom_StrafeLeftController();
		}
	}
}