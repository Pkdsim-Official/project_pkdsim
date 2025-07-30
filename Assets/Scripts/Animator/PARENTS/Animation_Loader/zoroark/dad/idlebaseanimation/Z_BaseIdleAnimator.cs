using project_pkdsim.ANIMATOR.Parents.Zoroark.Dad.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.Parents.Zoroark.Dad.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Zoroark.Dad.idlebaseanimation
{
	public class ZoroarkParentDad_IdleAnimatorController : MonoBehaviour 
	{
		private ZParentDad_IdleStanding ZoroarkIdlestanding;
		
		private ZParentDad_IdleSitting ZoroarkIdlesitting;
		
		public void	ZParentDad_IdleAnimatorController()
		{
			ZParentDad_IdleStandingAnimatorController();
			ZParentDad_IdleSittingAnimatorController();
		}
		private void ZParentDad_IdleStandingAnimatorController()
		{
			ZoroarkIdlestanding.ZParentDad_IdleStandingController();
		}
		private void ZParentDad_IdleSittingAnimatorController()
		{
			ZoroarkIdlesitting.ZParentDad_IdleSittingController();
		}
	}
}