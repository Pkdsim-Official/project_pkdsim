using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Dad.movementbasedanimations.Strafing.StrafeLeft;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Dad.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Dragapult.Dad.movementbasedanimations.Strafing
{
	public class DRParentDad_Parent_Strafing : MonoBehaviour 
	{
		private DRParentDad_StrafeLeft DRParentDad_strafeleft;
		
		private DRParentDad_StrafeRight DRParentDad_straferight;

		public void DRParentDad_Parent_StrafingController()
		{
			if (DRParentDad_strafeleft == null)
			{
				Load_DRParentDad_StrafeLeft();
			}
			if (DRParentDad_straferight == null)
			{
				Load_DRParentDad_StrafeRight();
			}
			

		}
		private void Load_DRParentDad_StrafeRight()
		{
			DRParentDad_straferight.DRParentDad_StrafeRightController();
		}
		
		private void Load_DRParentDad_StrafeLeft()
		{
			DRParentDad_strafeleft.DRParentDad_StrafeLeftController();
		}
	}
}