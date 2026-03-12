using Project_Pkdsim.ANIMATOR.Parents.Lopunny.Dad.idlebaseanimation.IdleSitting;
using Project_Pkdsim.ANIMATOR.Parents.Lopunny.Dad.idlebaseanimation.IdleStanding;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Lopunny.Dad.idlebaseanimation
{
	public class LopunnyParentDad_IdleAnimatorController : MonoBehaviour
	{
		private LOParentDad_IdleStanding LopunnyParentDadidlestanding;

		private LOParentDad_IdleSitting LopunnyParentDadidlesitting;

		public void LOParentDad_IdleAnimatorController()
		{
			LOParentDad_IdleStandingAnimatorController();
			LOParentDad_IdleSittingAnimatorController();
		}
		private void LOParentDad_IdleStandingAnimatorController()
		{
			LopunnyParentDadidlestanding.LOParentDad_IdleStandingController();
		}
		private void LOParentDad_IdleSittingAnimatorController()
		{
			LopunnyParentDadidlesitting.LOParentDad_IdleSittingController();
		}
	}
}