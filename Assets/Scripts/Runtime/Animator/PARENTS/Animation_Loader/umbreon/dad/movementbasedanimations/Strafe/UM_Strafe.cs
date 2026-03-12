using Project_Pkdsim.ANIMATOR.Parents.Umbreon.Dad.movementbasedanimations.Strafing.StrafeLeft;
using Project_Pkdsim.ANIMATOR.Parents.Umbreon.Dad.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Umbreon.Dad.movementbasedanimations.Strafing
{
	public class UMParentDad_Strafing : MonoBehaviour 
	{
		private UMParentDad_StrafeLeft UMParentDad_strafeleft;
		
		private UMParentDad_StrafeRight UMParentDad_straferight;

		public void UMParentDad_StrafingController()
		{
			if (UMParentDad_strafeleft == null)
			{
				Load_UMParentDad_StrafeLeft();
			}
			if (UMParentDad_straferight == null)
			{
				Load_UMParentDad_StrafeRight();
			}
		}

		private void Load_UMParentDad_StrafeRight()
		{
			UMParentDad_straferight.UMParentDad_StrafeRightController();
		}
		
		private void Load_UMParentDad_StrafeLeft()
		{
			UMParentDad_strafeleft.UMParentDad_StrafeLeftController();
		}
	}
}