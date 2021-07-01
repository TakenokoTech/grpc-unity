package tech.takenoko.grpcspring.grpc

import kotlinx.coroutines.delay
import kotlinx.coroutines.flow.Flow
import kotlinx.coroutines.flow.flow
import org.lognet.springboot.grpc.GRpcService
import tech.takenoko.grpcspring.proto.GreeterGrpcKt
import tech.takenoko.grpcspring.proto.GreeterOuterClass.HelloReply
import tech.takenoko.grpcspring.proto.GreeterOuterClass.HelloRequest

/**
 * $grpcurl -plaintext -d '{"message": "world"}' localhost:6565 tech.takenoko.grpcspring.proto.Greeter/SayHelloStream
 */
@GRpcService
class GreeterService : GreeterGrpcKt.GreeterCoroutineImplBase() {
    override fun sayHelloStream(request: HelloRequest): Flow<HelloReply> = flow {
        val message = request.message
        while (true) {
            delay(1000)
            emit(HelloReply.newBuilder().setMessage("Hello, ${message}").build())
        }
    }
}