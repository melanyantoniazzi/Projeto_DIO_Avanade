// Essa interface Irepositorio é so para determinar que ele tenha os metodos de listagem de retornar id, inserir, excluir...Para garantir que as classes que implementem essa interface terão esses metodos 
using System.Collections.Generic;

namespace DIO.Series.Interfaces
{
    public interface IRepositorio<T>
    {
        List<T> Lista();

        T RetornaPorId(int id);

        void Insere(T entidade);

        void Exclui(int id);

        void Atualiza(int id, T entidade);

        int ProximoId();
    }        
    
}