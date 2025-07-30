using project_pkdsim.ANIMATOR.Parents.Noivern.Dad.movementbasedanimations.Strafing.StrafeLeft;
using project_pkdsim.ANIMATOR.Parents.Noivern.Dad.movementbasedanimations.Strafing.StrafeRight;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Noivern.Dad.movementbasedanimations.Strafing
{
	public class NOIParentDad_Strafing : MonoBehaviour 
	{
		private NOIParentDad_StrafeLeft NOIParentDad_strafeleft;
		
		private NOIParentDad_StrafeRight NOIParentDad_straferight;

		public void NOIParentDad_StrafingController()
		{
			if (NOIParentDad_strafeleft == null)
			{
				Load_NOIParentDad_StrafeLeft();
			}
			if (NOIParentDad_straferight == null)
			{
				Load_NOIParentDad_StrafeRight();
			}
			

		}
		private void Load_NOIParentDad_StrafeRight()
		{
			NOIParentDad_straferight.NOIParentDad_StrafeRightController();
		}
		
		private void Load_NOIParentDad_StrafeLeft()
		{
			NOIParentDad_strafeleft.NOIParentDad_StrafeLeftController();
		}
	}
}