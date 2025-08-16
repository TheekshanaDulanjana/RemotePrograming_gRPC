using Grpc.Core;

namespace GrpcServer.Services
{
    public class CalculatorService : Calculator.CalculatorBase
    {
        public override Task<AddReply> AddNumbers(AddRequest request, ServerCallContext context)
        {
            int sum = request.Number1 + request.Number2;
            return Task.FromResult(new AddReply { Result = sum });
        }
    }
}
