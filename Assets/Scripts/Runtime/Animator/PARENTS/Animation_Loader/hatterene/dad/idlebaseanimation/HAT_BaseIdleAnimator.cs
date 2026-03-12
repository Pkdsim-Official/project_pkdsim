using Project_Pkdsim.ANIMATOR.Parents.Hatterene.Dad.idlebaseanimation.IdleSitting;
using Project_Pkdsim.ANIMATOR.Parents.Hatterene.Dad.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Hatterene.Dad.idlebaseanimation
{
	public class HattereneParentDad_IdleAnimatorController : MonoBehaviour 
	{
		private HATParentDad_IdleStanding HATParentDad_idlestanding;
		
		private HATParentDad_IdleSitting HATParentDad_idlesitting;
		
		public void	HATParentDad_IdleAnimatorController()
		{
			HATParentDad_IdleStandingAnimatorController();
			HATParentDad_IdleSittingAnimatorController();
		}
		private void HATParentDad_IdleStandingAnimatorController()
		{
			HATParentDad_idlestanding.HATParentDad_IdleStandingController();
		}
		private void HATParentDad_IdleSittingAnimatorController()
		{
			HATParentDad_idlesitting.HATParentDad_IdleSittingController();
		}
	}
}