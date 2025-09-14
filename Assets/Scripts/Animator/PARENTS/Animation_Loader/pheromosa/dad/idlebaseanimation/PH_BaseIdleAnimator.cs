using project_pkdsim.ANIMATOR.Parents.Pheromosa.Dad.idlebaseanimation.IdleSitting;
using project_pkdsim.ANIMATOR.Parents.Pheromosa.Dad.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Pheromosa.Dad.idlebaseanimation
{
	public class PheromosaParentDad_IdleAnimatorController : MonoBehaviour
	{
		private PHParentDad_IdleStanding PHParentDadidlestanding;

		private PHParentDad_IdleSitting PHParentDadidlesitting;

		public void PHParentDad_IdleAnimatorController()
		{
			PHParentDad_IdleStandingAnimatorController();
			PHParentDad_IdleSittingAnimatorController();
		}
		private void PHParentDad_IdleStandingAnimatorController()
		{
			PHParentDadidlestanding.PHParentDad_IdleStandingController();
		}
		private void PHParentDad_IdleSittingAnimatorController()
		{
			PHParentDadidlesitting.PHParentDad_IdleSittingController();
		}
	}
}