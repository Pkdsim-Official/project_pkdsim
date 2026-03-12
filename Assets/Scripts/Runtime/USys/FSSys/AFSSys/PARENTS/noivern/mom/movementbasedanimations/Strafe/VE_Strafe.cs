using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Noivern.Mom.movementbasedanimations.Strafing.StrafeLeft;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Noivern.Mom.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Noivern.Mom.movementbasedanimations.Strafing
{
	public class NOIParentMom_Strafing : MonoBehaviour 
	{
		private NOIParentMom_StrafeLeft NOIParentMom_strafeleft;
		
		private NOIParentMom_StrafeRight NOIParentMom_straferight;

		public void NOIParentMom_StrafingController()
		{
			if (NOIParentMom_strafeleft == null)
			{
				Load_NOIParentMom_StrafeLeft();
			}
			if (NOIParentMom_straferight == null)
			{
				Load_NOIParentMom_StrafeRight();
			}
		}
		private void Load_NOIParentMom_StrafeRight()
		{
			NOIParentMom_straferight.NOIParentMom_StrafeRightController();
		}
		
		private void Load_NOIParentMom_StrafeLeft()
		{
			NOIParentMom_strafeleft.NOIParentMom_StrafeLeftController();
		}
	}
}