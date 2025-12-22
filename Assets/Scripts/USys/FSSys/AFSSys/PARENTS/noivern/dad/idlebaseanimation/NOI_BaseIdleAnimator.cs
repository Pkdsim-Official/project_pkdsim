using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Noivern.Dad.idlebaseanimation.IdleSitting;
using project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Noivern.Dad.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Noivern.Dad.idlebaseanimation
{
	public class Noivern_IdleAnimatorController : MonoBehaviour 
	{
		private NOIParentDad_IdleStanding NoivernParentDadidlestanding;
		
		private NOIParentDad_IdleSitting NoivernParentDadidlesitting;
		
		public void	NOIParentDad_IdleAnimatorController()
		{
			NOIParentDad_IdleStandingAnimatorController();
			NOIParentDad_IdleSittingAnimatorController();
		}
		private void NOIParentDad_IdleStandingAnimatorController()
		{
			NoivernParentDadidlestanding.NOIParentDad_IdleStandingController();
		}
		private void NOIParentDad_IdleSittingAnimatorController()
		{
			NoivernParentDadidlesitting.NOIParentDad_IdleSittingController();
		}
	}
}