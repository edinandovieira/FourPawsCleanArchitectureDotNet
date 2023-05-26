namespace FourPawsCleanArchitecture.Domain.Entities
{
    public class Login
    {
        public Guid Codigo { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public string Status { get; set; }
        public string Token { get; set; }
    }
}
