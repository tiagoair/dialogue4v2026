using UnityEngine;

namespace IA.Inimigo
{
    public class InimigoPerseguicaoBehaviour : StateMachineBehaviour
    {
        private InimigoController inimigo;
        
        public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo,
            int layerIndex)
        {
            inimigo = animator.GetComponent<InimigoController>();
        }

        public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo,
            int layerIndex)
        {
            inimigo.transform.position += (inimigo.PlayerTransform.position-inimigo.transform.position).normalized 
                                          * inimigo.VelocidadeMovimento * Time.deltaTime;
        }
        
    }
}