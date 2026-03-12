using Project_Pkdsim.ANIMATOR.Parents.Vespiquen.Dad.idlebaseanimation.IdleSitting;
using Project_Pkdsim.ANIMATOR.Parents.Vespiquen.Dad.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Vespiquen.Dad.idlebaseanimation
{
	public class VespiquenParentDad_IdleAnimatorController : MonoBehaviour 
	{
		private VEParentDad_IdleStanding VEParentDad_idlestanding;
		
		private VEParentDad_IdleSitting VEParentDad_idlesitting;
		
		public void	VEParentDad_IdleAnimatorController()
		{
			VEParentDad_IdleStandingAnimatorController();
			VEParentDad_IdleSittingAnimatorController();
		}
		private void VEParentDad_IdleStandingAnimatorController()
		{
			VEParentDad_idlestanding.VEParentDad_IdleStandingController();
		}
		private void VEParentDad_IdleSittingAnimatorController()
		{
			VEParentDad_idlesitting.VEParentDad_IdleSittingController();
		}
	}
}