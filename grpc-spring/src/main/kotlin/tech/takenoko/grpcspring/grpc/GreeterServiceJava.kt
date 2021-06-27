package tech.takenoko.grpcspring.grpc

// @GRpcService
/*
class GreeterServiceJava : CalculatorImplBase() {
    override fun add(request: CalculatorOuterClass.AdditionRequest?, responseObserver: StreamObserver<CalculatorOuterClass.AdditionReply>?) {
        val added = request?.added ?: 0
        val add = request?.add ?: 0
        val replyBuilder = CalculatorOuterClass.AdditionReply.newBuilder().setResult(added+add)
        responseObserver?.onNext(replyBuilder.build())
        responseObserver?.onCompleted()
    }
}
*/