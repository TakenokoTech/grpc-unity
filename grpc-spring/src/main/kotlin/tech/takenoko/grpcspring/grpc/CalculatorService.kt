package tech.takenoko.grpcspring.grpc

import io.grpc.stub.StreamObserver
import org.lognet.springboot.grpc.GRpcService
import tech.takenoko.grpcspring.proto.CalculatorGrpc.CalculatorImplBase
import tech.takenoko.grpcspring.proto.CalculatorGrpcKt.CalculatorCoroutineImplBase
import tech.takenoko.grpcspring.proto.CalculatorOuterClass.AdditionRequest
import tech.takenoko.grpcspring.proto.CalculatorOuterClass.AdditionReply

/**
 * grpcurl -plaintext -d '{"added": 1, "add": 2}' localhost:6565 Greeter
 */
@GRpcService
class CalculatorServiceKt : CalculatorCoroutineImplBase() {
    override suspend fun add(request: AdditionRequest): AdditionReply {
        val added = request.added
        val add = request.add
        return AdditionReply.newBuilder().setResult(added+add).build()
    }
}

// @GRpcService
class CalculatorService : CalculatorImplBase() {
    override fun add(request: AdditionRequest?, responseObserver: StreamObserver<AdditionReply>?) {
        val added = request?.added ?: 0
        val add = request?.add ?: 0
        val replyBuilder = AdditionReply.newBuilder().setResult(added+add)
        responseObserver?.onNext(replyBuilder.build())
        responseObserver?.onCompleted()
    }
}