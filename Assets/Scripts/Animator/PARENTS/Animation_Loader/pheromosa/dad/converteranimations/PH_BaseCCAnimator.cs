using project_pkdsim.ANIMATOR.Parents.Pheromosa.Dad.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Pheromosa.Dad.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Pheromosa.Dad.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Pheromosa.Dad.converteranimations
{
	public class PheromosaParentDad_ConverterAnimatorController : MonoBehaviour
	{
		private PHParentDad_SittingTo PheromosaParentDadsittingto;

		private PHParentDad_WalkingTo PheromosaParentDadwalkingto;

		private PHParentDad_IdleTo PheromosaParentDadidleto;

		public void PHParentDad_ConverterAnimatorController()
		{
			PheromosaParentDadwalkingto.PHParentDad_WalkingToController();

			PheromosaParentDadidleto.PHParentDad_IdleToController();

			PheromosaParentDadsittingto.PHParentDad_SittingToController();
		}
	}
}