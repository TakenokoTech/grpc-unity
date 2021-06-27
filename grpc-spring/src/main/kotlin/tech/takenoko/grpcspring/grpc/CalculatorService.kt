package tech.takenoko.grpcspring.grpc

import org.lognet.springboot.grpc.GRpcService
import tech.takenoko.grpcspring.proto.CalculatorGrpcKt.CalculatorCoroutineImplBase
import tech.takenoko.grpcspring.proto.CalculatorOuterClass.AdditionRequest
import tech.takenoko.grpcspring.proto.CalculatorOuterClass.AdditionReply

/**
 * grpcurl -plaintext -d '{"added": 1, "add": 2}' localhost:6565 Greeter
 */
@GRpcService
class CalculatorService : CalculatorCoroutineImplBase() {
    override suspend fun add(request: AdditionRequest): AdditionReply {
        val added = request.added
        val add = request.add
        return AdditionReply.newBuilder().setResult(added+add).build()
    }
}
