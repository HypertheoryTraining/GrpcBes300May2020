using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using RoutingGrpcService.Protos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoutingGrpcService.Services
{
    public class RouteService : DrivingRouter.DrivingRouterBase
    {
        public override async Task<RouteResponse> PlanRoute(RouteRequest request, ServerCallContext context)
        {

            var response = new RouteResponse();
            response.Miles = new Random().Next(15, 200);
            response.Steps.Add("Go the traffic light");
            response.Steps.Add("Turn Left");
            response.Steps.Add("You have arrived");
            response.DrivingTime = Timestamp.FromDateTime(DateTime.Now.AddMinutes(response.Miles).ToUniversalTime());
            return response;
        }
    }
}
