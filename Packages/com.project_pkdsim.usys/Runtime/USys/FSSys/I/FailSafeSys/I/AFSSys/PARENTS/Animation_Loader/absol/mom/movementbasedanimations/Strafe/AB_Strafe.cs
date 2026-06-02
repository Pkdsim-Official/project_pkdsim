using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Absol.Mom.movementbasedanimations.Strafing.StrafeLeft;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Absol.Mom.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Absol.Mom.movementbasedanimations.Strafing
{
	public class ABParentMom_Strafing : MonoBehaviour 
	{
		private ABStrafeLeft AB_strafeleft;
		
		private ABStrafeRight AB_straferight;

		public void ABParentMom_StrafingController()
		{
			if (AB_strafeleft == null)
			{
				AB_strafeleft = GetComponent<ABStrafeLeft>();
				Load_ABStrafeLeft();
			}
			if (AB_straferight == null)
			{
				AB_straferight = GetComponent<ABStrafeRight>();
				Load_ABStrafeRight();
			}
			

		}
		private void Load_ABStrafeRight()
		{
			AB_straferight.ABStrafeRightController();
		}
		
		private void Load_ABStrafeLeft()
		{
			AB_strafeleft.ABStrafeLeftController();
		}
	}
}