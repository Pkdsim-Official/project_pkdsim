using project_pkdsim.ANIMATOR.Parents.Braixen.Dad.movementbasedanimations.Strafing.StrafeLeft;
using project_pkdsim.ANIMATOR.Parents.Braixen.Dad.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Braixen.Dad.movementbasedanimations.Strafing
{
	public class BRParentDad_Strafing : MonoBehaviour 
	{
		private BRParentDad_StrafeLeft BRParentDad_strafeleft;
		
		private BRParentDad_StrafeRight BRParentDad_straferight;

		public void BRParentDad_StrafingController()
		{
			if (BRParentDad_strafeleft == null)
			{
				BRParentDad_strafeleft = GetComponent<BRParentDad_StrafeLeft>();
				Load_BRParentDad_StrafeLeft();
			}
			if (BRParentDad_straferight == null)
			{
				BRParentDad_straferight = GetComponent<BRParentDad_StrafeRight>();
				Load_BRParentDad_StrafeRight();
			}
			

		}
		private void Load_BRParentDad_StrafeRight()
		{
			BRParentDad_straferight.BRParentDad_StrafeRightController();
		}
		
		private void Load_BRParentDad_StrafeLeft()
		{
			BRParentDad_strafeleft.BRParentDad_StrafeLeftController();
		}
	}
}