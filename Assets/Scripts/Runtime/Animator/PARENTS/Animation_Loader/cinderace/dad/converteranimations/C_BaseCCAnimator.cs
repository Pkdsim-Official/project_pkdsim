using Project_Pkdsim.ANIMATOR.Parents.Cinderace.Dad.converteranimations.IdleTo;
using Project_Pkdsim.ANIMATOR.Parents.Cinderace.Dad.converteranimations.SittingTo;
using Project_Pkdsim.ANIMATOR.Parents.Cinderace.Dad.converteranimations.WalkingTo;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Cinderace.Dad.converteranimations
{
	public class CinderaceParentDad_ConverterAnimatorController : MonoBehaviour
	{
		private CParentDad_SittingTo CinderaceSittingto;

		private CParentDad_WalkingTo CinderaceWalkingto;

		private CParentDad_IdleTo CinderaceIdleto;

		public void CParentDad_ConverterAnimatorController()
		{
			CinderaceWalkingto.CParentDad_WalkingToController();

			CinderaceIdleto.CParentDad_IdleToController();

			CinderaceSittingto.CParentDad_SittingToController();
		}
	}
}