using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Pheromosa.Mom.converteranimations.IdleTo;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Pheromosa.Mom.converteranimations.SittingTo;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Pheromosa.Mom.converteranimations.WalkingTo;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Pheromosa.Mom.converteranimations
{
	public class PheromosaParentMom_ConverterAnimatorController : MonoBehaviour 
	{
		private PHParentMom_SittingTo PheromosaParentMomSittingto;
		
		private PHParentMom_WalkingTo PheromosaParentMomWalkingto;
		
		private PHParentMom_IdleTo PheromosaParentMomIdleto;

		public void PHParentMom_ConverterAnimatorController()
		{
			PheromosaParentMomWalkingto.PHParentMom_WalkingToController();

			PheromosaParentMomIdleto.PHParentMom_IdleToController();

			PheromosaParentMomSittingto.PHParentMom_SittingToController();	
		}
	}
}