using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Dad.movementbasedanimations.Strafing.StrafeLeft;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Dad.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Dad.movementbasedanimations.Strafing
{
	public class MEOWParentDad_Parent_Strafing : MonoBehaviour 
	{
		private MEOWParentDad_StrafeLeft MEOWParentDad_strafeleft;
		
		private MEOWParentDad_StrafeRight MEOWParentDad_straferight;

		public void MEOWParentDad_Parent_StrafingController()
		{
			if (MEOWParentDad_strafeleft == null)
			{
				Load_MEOWParentDad_StrafeLeft();
			}
			if (MEOWParentDad_straferight == null)
			{
				Load_MEOWParentDad_StrafeRight();
			}
			

		}
		private void Load_MEOWParentDad_StrafeRight()
		{
			MEOWParentDad_straferight.MEOWParentDad_StrafeRightController();
		}
		
		private void Load_MEOWParentDad_StrafeLeft()
		{
			MEOWParentDad_strafeleft.MEOWParentDad_StrafeLeftController();
		}
	}
}