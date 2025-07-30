using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Dad.movementbasedanimations.Strafing.StrafeLeft;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Dad.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Lucario.Dad.movementbasedanimations.Strafing
{
	public class LUCAParentDad_Strafing : MonoBehaviour 
	{
		private LUCAParentDad_StrafeLeft LUCAParentDad_strafeleft;
		
		private LUCAParentDad_StrafeRight LUCAParentDad_straferight;

		public void LUCAParentDad_StrafingController()
		{
			if (LUCAParentDad_strafeleft == null)
			{
				LUCAParentDad_strafeleft = GetComponent<LUCAParentDad_StrafeLeft>();
				Load_LUCAParentDad_StrafeLeft();
			}
			if (LUCAParentDad_straferight == null)
			{
				LUCAParentDad_straferight = GetComponent<LUCAParentDad_StrafeRight>();
				Load_LUCAParentDad_StrafeRight();
			}
			
		}
		private void Load_LUCAParentDad_StrafeRight()
		{
			LUCAParentDad_straferight.LUCAParentDad_StrafeRightController();
		}
		
		private void Load_LUCAParentDad_StrafeLeft()
		{
			LUCAParentDad_strafeleft.LUCAParentDad_StrafeLeftController();
		}
	}
}