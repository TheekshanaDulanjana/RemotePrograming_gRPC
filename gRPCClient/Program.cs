using Grpc.Net.Client;
using GrpcServer;

var channel = GrpcChannel.ForAddress("http://localhost:5090");
var client = new Calculator.CalculatorClient(channel);

var reply = await client.AddNumbersAsync(new AddRequest { Number1 = 10, Number2 = 20 });
Console.WriteLine($"Result: {reply.Result}");
