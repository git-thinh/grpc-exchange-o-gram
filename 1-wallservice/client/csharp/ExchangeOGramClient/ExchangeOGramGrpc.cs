// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: exchange_o_gram.proto
// Original file comments:
// Protobuf definition for Exchange-O-Gram
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using grpc = global::Grpc.Core;

namespace ExchangeOGram {
  public static partial class WallService
  {
    static readonly string __ServiceName = "exchange_o_gram.WallService";

    static readonly grpc::Marshaller<global::ExchangeOGram.PostToWallRequest> __Marshaller_PostToWallRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::ExchangeOGram.PostToWallRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::ExchangeOGram.PostToWallResponse> __Marshaller_PostToWallResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::ExchangeOGram.PostToWallResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::ExchangeOGram.GetWallPostsRequest> __Marshaller_GetWallPostsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::ExchangeOGram.GetWallPostsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::ExchangeOGram.GetWallPostsResponse> __Marshaller_GetWallPostsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::ExchangeOGram.GetWallPostsResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::ExchangeOGram.PostToWallRequest, global::ExchangeOGram.PostToWallResponse> __Method_PostToWall = new grpc::Method<global::ExchangeOGram.PostToWallRequest, global::ExchangeOGram.PostToWallResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "PostToWall",
        __Marshaller_PostToWallRequest,
        __Marshaller_PostToWallResponse);

    static readonly grpc::Method<global::ExchangeOGram.GetWallPostsRequest, global::ExchangeOGram.GetWallPostsResponse> __Method_GetWallPosts = new grpc::Method<global::ExchangeOGram.GetWallPostsRequest, global::ExchangeOGram.GetWallPostsResponse>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "GetWallPosts",
        __Marshaller_GetWallPostsRequest,
        __Marshaller_GetWallPostsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::ExchangeOGram.ExchangeOGramReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of WallService</summary>
    public abstract partial class WallServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::ExchangeOGram.PostToWallResponse> PostToWall(global::ExchangeOGram.PostToWallRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task GetWallPosts(global::ExchangeOGram.GetWallPostsRequest request, grpc::IServerStreamWriter<global::ExchangeOGram.GetWallPostsResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for WallService</summary>
    public partial class WallServiceClient : grpc::ClientBase<WallServiceClient>
    {
      /// <summary>Creates a new client for WallService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public WallServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for WallService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public WallServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected WallServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected WallServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::ExchangeOGram.PostToWallResponse PostToWall(global::ExchangeOGram.PostToWallRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return PostToWall(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::ExchangeOGram.PostToWallResponse PostToWall(global::ExchangeOGram.PostToWallRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_PostToWall, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::ExchangeOGram.PostToWallResponse> PostToWallAsync(global::ExchangeOGram.PostToWallRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return PostToWallAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::ExchangeOGram.PostToWallResponse> PostToWallAsync(global::ExchangeOGram.PostToWallRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_PostToWall, null, options, request);
      }
      public virtual grpc::AsyncServerStreamingCall<global::ExchangeOGram.GetWallPostsResponse> GetWallPosts(global::ExchangeOGram.GetWallPostsRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetWallPosts(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncServerStreamingCall<global::ExchangeOGram.GetWallPostsResponse> GetWallPosts(global::ExchangeOGram.GetWallPostsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_GetWallPosts, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override WallServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new WallServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(WallServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_PostToWall, serviceImpl.PostToWall)
          .AddMethod(__Method_GetWallPosts, serviceImpl.GetWallPosts).Build();
    }

  }
}
#endregion
