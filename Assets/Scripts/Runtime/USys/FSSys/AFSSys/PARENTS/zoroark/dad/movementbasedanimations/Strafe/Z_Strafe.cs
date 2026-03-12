using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Zoroark.Dad.movementbasedanimations.Strafing.StrafeLeft;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Zoroark.Dad.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Zoroark.Dad.movementbasedanimations.Strafing
{
	public class ZParentDad_Strafing : MonoBehaviour 
	{
		private ZParentDad_StrafeLeft ZParentDad_strafeleft;
		
		private ZParentDad_StrafeRight ZParentDad_straferight;

		public void ZParentDad_StrafingController()
		{
			if (ZParentDad_strafeleft == null)
			{
				Load_ZParentDad_StrafeLeft();
			}
			if (ZParentDad_straferight == null)
			{
				Load_ZParentDad_StrafeRight();
			}
			

		}
		private void Load_ZParentDad_StrafeRight()
		{
			ZParentDad_straferight.ZParentDad_StrafeRightController();
		}
		
		private void Load_ZParentDad_StrafeLeft()
		{
			ZParentDad_strafeleft.ZParentDad_StrafeLeftController();
		}
	}
}