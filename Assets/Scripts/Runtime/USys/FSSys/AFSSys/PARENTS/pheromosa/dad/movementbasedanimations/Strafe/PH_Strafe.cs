using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Pheromosa.Dad.movementbasedanimations.Strafing.StrafeLeft;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Pheromosa.Dad.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Pheromosa.Dad.movementbasedanimations.Strafing
{
	public class PHParentDad_Strafing : MonoBehaviour 
	{
		private PHParentDad_StrafeLeft PHParentDad_strafeleft;
		
		private PHParentDad_StrafeRight PHParentDad_straferight;

		public void PHParentDad_StrafingController()
		{
			if (PHParentDad_strafeleft == null)
			{
				Load_PHParentDad_StrafeLeft();
			}
			if (PHParentDad_straferight == null)
			{
				Load_PHParentDad_StrafeRight();
			}
			

		}
		private void Load_PHParentDad_StrafeRight()
		{
			PHParentDad_straferight.PHParentDad_StrafeRightController();
		}
		
		private void Load_PHParentDad_StrafeLeft()
		{
			PHParentDad_strafeleft.PHParentDad_StrafeLeftController();
		}
	}
}