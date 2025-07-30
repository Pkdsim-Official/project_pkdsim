using project_pkdsim.ANIMATOR.Parents.Tsareena.converteranimations.IdleTo;
using project_pkdsim.ANIMATOR.Parents.Tsareena.converteranimations.SittingTo;
using project_pkdsim.ANIMATOR.Parents.Tsareena.converteranimations.WalkingTo;
using UnityEngine;

namespace project_pkdsim.ANIMATOR.Parents.Tsareena.converteranimations
{
	public class TsareenaConverterAnimatorController : MonoBehaviour 
	{
		private TSittingTo Tsareenasittingto;
		
		private TWalkingTo Tsareenawalkingto;
		
		private TIdleTo Tsareenaidleto;

		public void TConverterToAnimatorController()
		{
			Tsareenawalkingto.TWalkingToController();

			Tsareenaidleto.T_IdleToController();
			
			Tsareenasittingto.TSittingToController();	
		}
	}
}