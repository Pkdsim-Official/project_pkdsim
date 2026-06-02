using project_pkdsim.ANIMATOR.Parents.Tsareena.Dad.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Tsareena.Dad.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Tsareena.Dad.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Tsareena.Dad.converteranimations
{
	public class TsareenaParentDad_ConverterAnimatorController : MonoBehaviour 
	{
		private TParentDad_SittingTo Tsareenasittingto;
		
		private TParentDad_WalkingTo Tsareenawalkingto;
		
		private TParentDad_IdleTo Tsareenaidleto;

		public void TParentDad_ConverterAnimatorController()
		{
			Tsareenawalkingto.TParentDad_WalkingToController();

			Tsareenaidleto.TParentDad_IdleToController();
			
			Tsareenasittingto.TParentDad_SittingToController();	
		}
	}
}