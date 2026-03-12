using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Jolteon.Dad.movementbasedanimations.Strafing.StrafeLeft;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Jolteon.Dad.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Jolteon.Dad.movementbasedanimations.Strafing
{
	public class JTParentDad_Strafing : MonoBehaviour 
	{
		private JTParentDad_StrafeLeft JTParentDad_strafeleft;
		private JTParentDad_StrafeRight JTParentDad_straferight;

		public void JTParentDad_StrafingController()
		{
			if (JTParentDad_strafeleft == null)
			{
				Load_JTParentDad_StrafeLeft();
			}
			if (JTParentDad_straferight == null)
			{
				Load_JTParentDad_StrafeRight();
			}
		}

		private void Load_JTParentDad_StrafeRight()
		{
			JTParentDad_straferight.JTParentDad_StrafeRightController();
		}
		
		private void Load_JTParentDad_StrafeLeft()
		{
			JTParentDad_strafeleft.JTParentDad_StrafeLeftController();
		}
	}
}