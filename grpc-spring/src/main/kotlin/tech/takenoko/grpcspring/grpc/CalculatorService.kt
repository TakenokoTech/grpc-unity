package tech.takenoko.grpcspring.grpc

import io.grpc.stub.StreamObserver
import org.lognet.springboot.grpc.GRpcService
import tech.takenoko.grpcspring.proto.CalculatorGrpc.CalculatorImplBase
import tech.takenoko.grpcspring.proto.CalculatorOuterClass.AdditionRequest
import tech.takenoko.grpcspring.proto.CalculatorOuterClass.AdditionReply

@GRpcService
class CalculatorService : CalculatorImplBase() {
    override fun add(request: AdditionRequest?, responseObserver: StreamObserver<AdditionReply>?) {
        val added = request?.added ?: 0
        val add = request?.add ?: 0
        val replyBuilder = AdditionReply.newBuilder().setResult(added+add)
        responseObserver?.onNext(replyBuilder.build())
        responseObserver?.onCompleted()
    }
}