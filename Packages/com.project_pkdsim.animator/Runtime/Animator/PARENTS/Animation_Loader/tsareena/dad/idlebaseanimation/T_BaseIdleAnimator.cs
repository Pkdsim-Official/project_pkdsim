using project_pkdsim.ANIMATOR.Parents.Tsareena.Dad.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.Parents.Tsareena.Dad.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Tsareena.Dad.idlebaseanimation
{
	public class TsareenaParentDad_IdleAnimatorController : MonoBehaviour 
	{
		private TParentDad_IdleStanding Tidlestanding;
		
		private TParentDad_IdleSitting Tidlesitting;
		
		public void	TParentDad_IdleAnimatorController()
		{
			TParentDad_IdleStandingAnimatorController();
			TParentDad_IdleSittingAnimatorController();
		}
		private void TParentDad_IdleStandingAnimatorController()
		{
			Tidlestanding.TParentDad_IdleStandingController();
		}
		private void TParentDad_IdleSittingAnimatorController()
		{
			Tidlesitting.TParentDad_IdleSittingController();
		}
	}
}