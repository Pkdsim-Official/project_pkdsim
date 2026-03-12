using Project_Pkdsim.ANIMATOR.Parents.Garchomp.Mom.movementbasedanimations.Strafing.StrafeLeft;
using Project_Pkdsim.ANIMATOR.Parents.Garchomp.Mom.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Garchomp.Mom.movementbasedanimations.Strafing
{
	public class GARCParentMom_Strafing : MonoBehaviour 
	{
		private GARCParentMom_StrafeLeft GARCParentMom_strafeleft;
		
		private GARCParentMom_StrafeRight GARCParentMom_straferight;

		public void GARCParentMom_StrafingController()
		{
			if (GARCParentMom_strafeleft == null)
			{
				Load_GARCParentMom_StrafeLeft();
			}
			if (GARCParentMom_straferight == null)
			{
				Load_GARCParentMom_StrafeRight();
			}
		}
		private void Load_GARCParentMom_StrafeRight()
		{
			GARCParentMom_straferight.GARCParentMom_StrafeRightController();
		}
		
		private void Load_GARCParentMom_StrafeLeft()
		{
			GARCParentMom_strafeleft.GARCParentMom_StrafeLeftController();
		}
	}
}