using Project_Pkdsim.ANIMATOR.Parents.Pheromosa.Dad.converteranimations.IdleTo;
using Project_Pkdsim.ANIMATOR.Parents.Pheromosa.Dad.converteranimations.SittingTo;
using Project_Pkdsim.ANIMATOR.Parents.Pheromosa.Dad.converteranimations.WalkingTo;
using UnityEngine;

namespace Project_Pkdsim.ANIMATOR.Parents.Pheromosa.Dad.converteranimations
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