namespace MailDistributing.Contract
{
    public interface IMailDistributor
    {
        void Start();
        void Distribute();
        void SentComplete();
    }
}