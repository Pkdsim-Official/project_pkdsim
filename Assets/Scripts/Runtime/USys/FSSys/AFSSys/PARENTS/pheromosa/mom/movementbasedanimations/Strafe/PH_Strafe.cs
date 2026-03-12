using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Pheromosa.Mom.movementbasedanimations.Strafing.StrafeLeft;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Pheromosa.Mom.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Pheromosa.Mom.movementbasedanimations.Strafing
{
	public class PHParentMom_Strafing : MonoBehaviour 
	{
		private PHParentMom_StrafeLeft PHParentMom_strafeleft;
		
		private PHParentMom_StrafeRight PHParentMom_straferight;

		public void PHParentMom_StrafingController()
		{
			if (PHParentMom_strafeleft == null)
			{
				Load_PHParentMom_StrafeLeft();
			}
			if (PHParentMom_straferight == null)
			{
				Load_PHParentMom_StrafeRight();
			}
		}
		private void Load_PHParentMom_StrafeRight()
		{
			PHParentMom_straferight.PHParentMom_StrafeRightController();
		}
		
		private void Load_PHParentMom_StrafeLeft()
		{
			PHParentMom_strafeleft.PHParentMom_StrafeLeftController();
		}
	}
}