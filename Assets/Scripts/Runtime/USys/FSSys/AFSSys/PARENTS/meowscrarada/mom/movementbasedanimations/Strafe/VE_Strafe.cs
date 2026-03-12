using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Mom.movementbasedanimations.Strafing.StrafeLeft;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Mom.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Meowscarada.Mom.movementbasedanimations.Strafing
{
	public class MEOWParentMom_Strafing : MonoBehaviour 
	{
		private MEOWParentMom_StrafeLeft MEOWParentMom_strafeleft;
		
		private MEOWParentMom_StrafeRight MEOWParentMom_straferight;

		public void MEOWParentMom_StrafingController()
		{
			if (MEOWParentMom_strafeleft == null)
			{
				Load_MEOWParentMom_StrafeLeft();
			}
			if (MEOWParentMom_straferight == null)
			{
				Load_MEOWParentMom_StrafeRight();
			}
		}
		private void Load_MEOWParentMom_StrafeRight()
		{
			MEOWParentMom_straferight.MEOWParentMom_StrafeRightController();
		}
		
		private void Load_MEOWParentMom_StrafeLeft()
		{
			MEOWParentMom_strafeleft.MEOWParentMom_StrafeLeftController();
		}
	}
}