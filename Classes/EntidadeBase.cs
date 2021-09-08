//Montamos essa classe EntidadeBase para ter um Id em todas as classes que herdar dela e uma classe abstrata.
namespace DIO.Series
{
    public abstract class EntidadeBase
    {
        public int Id { get; protected set; }
    }
    
}