using Project_Pkdsim.ANIMATOR.Parents.Umbreon.Mom.movementbasedanimations.Strafing.StrafeLeft;
using Project_Pkdsim.ANIMATOR.Parents.Umbreon.Mom.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Umbreon.Mom.movementbasedanimations.Strafing
{
	public class UMParentMom_Strafing : MonoBehaviour 
	{
		private UMParentMom_StrafeLeft UMParentMom_strafeleft;
		
		private UMParentMom_StrafeRight UMParentMom_straferight;

		public void UMParentMom_StrafingController()
		{
			if (UMParentMom_strafeleft == null)
			{
				Load_UMParentMom_StrafeLeft();
			}
			if (UMParentMom_straferight == null)
			{
				Load_UMParentMom_StrafeRight();
			}
		}
		private void Load_UMParentMom_StrafeRight()
		{
			UMParentMom_straferight.UMParentMom_StrafeRightController();
		}
		
		private void Load_UMParentMom_StrafeLeft()
		{
			UMParentMom_strafeleft.UMParentMom_StrafeLeftController();
		}
	}
}