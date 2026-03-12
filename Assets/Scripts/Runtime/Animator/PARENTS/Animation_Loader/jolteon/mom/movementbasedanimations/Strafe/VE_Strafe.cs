using Project_Pkdsim.ANIMATOR.Parents.Jolteon.Mom.movementbasedanimations.Strafing.StrafeLeft;
using Project_Pkdsim.ANIMATOR.Parents.Jolteon.Mom.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Jolteon.Mom.movementbasedanimations.Strafing
{
	public class JTParentMom_Strafing : MonoBehaviour 
	{
		private JTParentMom_StrafeLeft JTParentMom_strafeleft;
		
		private JTParentMom_StrafeRight JTParentMom_straferight;

		public void JTParentMom_StrafingController()
		{
			if (JTParentMom_strafeleft == null)
			{
				Load_JTParentMom_StrafeLeft();
			}
			if (JTParentMom_straferight == null)
			{
				Load_JTParentMom_StrafeRight();
			}
		}
		private void Load_JTParentMom_StrafeRight()
		{
			JTParentMom_straferight.JTParentMom_StrafeRightController();
		}
		
		private void Load_JTParentMom_StrafeLeft()
		{
			JTParentMom_strafeleft.JTParentMom_StrafeLeftController();
		}
	}
}