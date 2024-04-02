namespace EjemploOracle.Services
{
    public class ResponseService<T>
    {
        public T? ResponseObject { get; set; }
        public string? Error { get; set; }
        public int Status { get; set; }
        public bool? Success { get; set; }

        public ResponseService()
        {
            Status = 200;
        }

        public void AgregarBadRequest(string message)
        {
            Status = 400;
            Error = message;
        }

        public void AgregarInternalServerError(string message)
        {
            Status = 500;
            Error = message;
        }
    }
}
