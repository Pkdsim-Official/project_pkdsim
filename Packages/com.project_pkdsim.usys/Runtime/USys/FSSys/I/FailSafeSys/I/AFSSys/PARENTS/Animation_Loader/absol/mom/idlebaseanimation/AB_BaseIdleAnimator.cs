using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Absol.Mom.idlebaseanimation.IdleSitting;
using project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Absol.Mom.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.USys.FSSys.Modules.FailSafeSys.Modules.AnimatorFailSafeSys.ANIMATOR.Parents.Absol.Mom.idlebaseanimation
{
	public class AbsolParentMom_IdleAnimatorController : MonoBehaviour 
	{
		private ABParentMom_IdleStanding Absolidlestanding;
		
		private ABParentMom_IdleSitting Absolidlesitting;
		
		public void	ABParentMom_IdleAnimatorController()
		{
			ABParentMom_IdleStandingAnimatorController();
			ABParentMom_IdleSittingAnimatorController();
		}
		public void ABParentMom_IdleStandingAnimatorController()
		{
			Absolidlestanding.ABParentMom_IdleStandingController();
		}
		public void ABParentMom_IdleSittingAnimatorController()
		{
			Absolidlesitting.ABParentMom_IdleSittingController();
		}
	}
}