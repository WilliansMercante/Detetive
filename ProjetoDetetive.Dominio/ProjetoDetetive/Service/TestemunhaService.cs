using ProjetoDetetive.Dominio.ProjetoDetetive.Repository;
using ProjetoDetetive.Dominio.ProjetoDetetive.Service.Interface;

namespace ProjetoDetetive.Dominio.ProjetoDetetive.Service
{
    public class TestemunhaService : ITestemunhaService
    {
        private readonly IAssassinatoRepository _assassinatoRepository;

        public TestemunhaService
        (
            IAssassinatoRepository assassinatoRepository
        )
        {
            _assassinatoRepository = assassinatoRepository;
        }

        public int Testemunha(int idArma, int idLocal, int idSuspeito)
        {
            var assassinatoDM = _assassinatoRepository.ObterUltimo();

            if (idArma == assassinatoDM.IdArma && idLocal == assassinatoDM.IdLocal && idSuspeito == assassinatoDM.IdSuspeito)
            {
                return 0;
            }
            else if (idArma == assassinatoDM.IdArma && idLocal == assassinatoDM.IdLocal && idSuspeito != assassinatoDM.IdSuspeito)
            {
                return 1;
            }
            else if (idArma == assassinatoDM.IdArma && idLocal != assassinatoDM.IdLocal && idSuspeito == assassinatoDM.IdSuspeito)
            {
                return 2;
            }
            else if (idArma != assassinatoDM.IdArma && idLocal == assassinatoDM.IdLocal && idSuspeito == assassinatoDM.IdSuspeito)
            {
                return 3;
            }
            else if (idArma != assassinatoDM.IdArma && idLocal != assassinatoDM.IdLocal && idSuspeito == assassinatoDM.IdSuspeito)
            {
                Random random = new Random();
                return random.Next(2, 4);
            }
            else if (idArma != assassinatoDM.IdArma && idLocal == assassinatoDM.IdLocal && idSuspeito != assassinatoDM.IdSuspeito)
            {
                Random random = new Random();
                var retorno = random.Next(1, 3);
                if (retorno == 2)
                {
                    retorno = 3;
                }
                return retorno;
            }
            else if (idArma == assassinatoDM.IdArma && idLocal != assassinatoDM.IdLocal && idSuspeito != assassinatoDM.IdSuspeito)
            {
                Random random = new Random();
                return random.Next(1, 3);
            }
            else
            {
                Random random = new Random();
                return random.Next(1, 4);
            }
        }
    }
}
