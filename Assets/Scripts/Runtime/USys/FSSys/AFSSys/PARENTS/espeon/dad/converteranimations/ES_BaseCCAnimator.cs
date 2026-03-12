using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Espeon.Dad.converteranimations.SittingTo;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Espeon.Dad.converteranimations.WalkingTo;
using Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Espeon.Dad.converteranimations.IdleTo;
using UnityEngine;

namespace Project_Pkdsim.USys.FailSafeSys.AnimatorFailSafeSys.ANIMATOR.Parents.Espeon.idlebaseanimation
{
	public class Espeon_AnimatorConverterController : MonoBehaviour 
	{
		private ES_IdleTo Espeon_idleto;
		
		private ES_WalkingTo Espeon_walkingto;

		private ES_SittingTo Espeon_sittingto;
		private void Espeon_Base_IdleAnimatorController()
		{
			Espeon_walkingto.ES_WalkingToController();

			Espeon_idleto.ES_IdleToController();
			
			Espeon_sittingto.ES_SittingToController();
		}
	}
}